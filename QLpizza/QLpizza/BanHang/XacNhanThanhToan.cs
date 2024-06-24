using QLpizza.CustomComponents;
using QLpizza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace QLpizza.BanHang
{
    public partial class XacNhanThanhToan : Form
    {
        private bool scheduleClose;
        private DataTable gioHangTable;
        public string MaHoaDon;

        public XacNhanThanhToan()
        {
            InitializeComponent();
        }

        private async void XacNhanThanhToan_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu vào combobox
            while (true)
                try
                {
                    cMaBan.DataSource = await SqlUtils.QueryAsync(
                        "SELECT MaBan, TenBan AS TenBan FROM BAN;"
                    );
                    break;
                }
                catch (Exception exc)
                {
                    switch (MessageBox.Show(
                            "Không thể tải dữ liệu.",
                            "Lỗi tải dữ liệu",
                            MessageBoxButtons.AbortRetryIgnore,
                            MessageBoxIcon.Error))
                    {
                        case DialogResult.Abort:
                            throw exc;
                        case DialogResult.Ignore:
                            return;
                    }
                }

            // Tải CSDL giỏ hàng
            gioHangTable = await SqlUtils.QueryAsync(
                "SELECT * FROM GIOHANG WHERE MaND = @MaND",
                new Dictionary<string, object>
                {
                    ["MaND"] = DangNhap.thongTinHienTai.MaND
                });
            UpdateThanhTien();

            bgwGioHang.RunWorkerAsync();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (MessageBox.Show(
                "Trước khi tiến hành thanh toán, xin quý khách vui " +
                "lòng xem xét và kiểm tra kỹ thông tin một lần nữa " +
                "để đảm bảo tính chính xác.\n" +
                "Quý khách có chắc chắn muốn thanh toán hoá đơn này?",
                "Thanh toán hoá đơn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;

            MaHoaDon = await MaGenerator.MaHoaDon();
            DateTime ngayDat = DateTime.Today;
            TimeSpan thoiGianDat = DateTime.Now.TimeOfDay;

            // Chèn vào CSDL trên web
            this.Enabled = false;
            StringBuilder sb = new StringBuilder();
            sb.Append(
                $"?type=insert&" +
                $"maHoaDon={MaHoaDon}&" +
                $"maBan={cMaBan.SelectedValue}&" +
                $"tenBan={cMaBan.Text.Trim()}&" +
                $"maKH={DangNhap.thongTinHienTai.MaND}&" +
                $"hoTen={DangNhap.thongTinHienTai.HoTen}&" +
                $"ngayDat={ngayDat.ToString("yyyy-MM-dd")}&" +
                $"thoiGianDat={thoiGianDat.ToString("hh\\:mm\\:ss")}&" +
                $@"phuongThucThanhToan={(
                    chkTienMat.Checked ? 0 :
                    chkTheTinDung.Checked ? 1 :
                    chkViDienTu.Checked ? 2 :
                    3)}&" +
                $"ghiChu={tGhiChu.Text.Trim()}&" +
                $"khachTra={0}&");

            foreach (DataRow row in (await SqlUtils.QueryAsync(
                @"SELECT GIOHANG.*, TenPizza, GiaBan FROM GIOHANG
JOIN PIZZA ON GIOHANG.MaPizza = PIZZA.MaPizza
WHERE MaND = @MaND", new Dictionary<string, object>
                {
                    ["MaND"] = DangNhap.thongTinHienTai.MaND
                })).Rows)
                sb.Append(
                    $"maPizza={row.Field<string>("MaPizza")}&" +
                    $"tenPizza={row.Field<string>("TenPizza")}&" +
                    $"donGia={row.Field<int>("GiaBan")}&" +
                    $"soLuong={row.Field<int>("SoLuong")}&");
            
            sb.Remove(sb.Length - 1, 1); // Bỏ dấu & cuối

            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(Settings.Default.WebApp)
            };
            try
            {
                await client.GetAsync(sb.ToString());
            }
            catch (Exception exc)
            {

            }

            // Chèn vào CSDL SQL Server
            SqlTransaction trans = (await SqlUtils.OpenAsync()).BeginTransaction();
            try
            {
                await SqlUtils.ExecuteNonQueryAsync(
                    "INSERT INTO HOADON VALUES (@MaHoaDon, @MaKH, @MaNV, @MaBan, " +
                    "@NgayDat, @ThoiGianDat, @PhuongThucThanhToan, @KhachTra, " +
                    "@GhiChu)",
                    new Dictionary<string, object>()
                    {
                        ["MaHoaDon"] = MaHoaDon,
                        ["MaKH"] = DangNhap.thongTinHienTai.MaND,
                        ["MaNV"] = DBNull.Value,
                        ["MaBan"] = cMaBan.SelectedValue,
                        ["NgayDat"] = ngayDat,
                        ["ThoiGianDat"] = thoiGianDat,
                        ["PhuongThucThanhToan"] =
                            chkTienMat.Checked ? 0 :
                            chkTheTinDung.Checked ? 1 :
                            chkViDienTu.Checked ? 2 :
                            3,
                        ["KhachTra"] = 0,
                        ["GhiChu"] = tGhiChu.Text.Trim()
                    }, default, trans);

                foreach (DataRow row in gioHangTable.Rows)
                    await SqlUtils.ExecuteNonQueryAsync(
                        "INSERT INTO CHITIETHOADON VALUES (@MaHoaDon, @MaPizza, @SoLuong)",
                        new Dictionary<string, object>()
                        {
                            ["MaHoaDon"] = MaHoaDon,
                            ["MaPizza"] = row.Field<string>("MaPizza"),
                            ["SoLuong"] = row.Field<int>("SoLuong")
                        }, default, trans);

                await SqlUtils.ExecuteNonQueryAsync(
                    "DELETE FROM GIOHANG WHERE MaND = @MaND",
                    new Dictionary<string, object>
                    {
                        ["MaND"] = DangNhap.thongTinHienTai.MaND
                    }, default, trans);
                
                trans.Commit();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exc)
            {
                trans.Rollback();
                MessageBox.Show(
                    "Có lỗi xảy ra trong lúc thanh toán. " +
                    "Quý khách vui lòng thử lại lần sau.\n" + exc.Message,
                    "Thanh toán thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = false;
            }
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            foreach (ComboBox cbo in new ComboBox[] { cMaBan })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) return valid;
            return valid;
        }

        private void UpdateThanhTien()
        {
            label2.Text = label6.Text = Convert.ToInt64(
                SqlUtils.ExecuteScalar(
                    "PROC_GIOHANG_THANHTIEN",
                    new Dictionary<string, object>
                    {
                        ["MaND"] = DangNhap.thongTinHienTai.MaND
                    }, CommandType.StoredProcedure)
            ).ToString("n0") + " \u20ab";
        }

        private void bgwGioHang_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() =>
            {
                SetInputsEnabled(false);
                picGioHangLoading.Show();

                flpGioHang.Tag = null;
                flpGioHang.SuspendLayout();
                while (flpGioHang.Controls.Count != 0)
                    flpGioHang.Controls[0].Dispose();
                flpGioHang.ResumeLayout();
            }));


            using (SqlDataReader reader = SqlUtils.ExecuteReader(
                "PROC_GIOHANG_PIZZA",
                new Dictionary<string, object>
                {
                    ["MaND"] = DangNhap.thongTinHienTai.MaND
                },
                CommandType.StoredProcedure
            ))
            {
                try
                {
                    for (int i = 0; reader.Read(); i++)
                    {
                        if (bgwGioHang.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        PizzaModel model = new PizzaModel()
                        {
                            MaPizza = reader.GetFieldValue<string>(reader.GetOrdinal("MaPizza")),
                            TenPizza = reader.GetFieldValue<string>(reader.GetOrdinal("TenPizza")),
                            FileHinh = Path.Combine(
                                Settings.Default.PizzaPath,
                                reader.GetFieldValue<string>(reader.GetOrdinal("FileHinh"))
                            ),
                            GiaBan = reader.GetFieldValue<int>(reader.GetOrdinal("GiaBan")),
                            MaLoai = reader.GetFieldValue<string>(reader.GetOrdinal("MaLoai")),
                            SoLuong = reader.GetFieldValue<int>(reader.GetOrdinal("SoLuong"))
                        };

                        PizzaItem item = new PizzaItem(model, i, true, false);
                        item.SoLuong.Enabled = false;
                        item.Xoa.Hide();

                        Invoke(new Action(() =>
                        {
                            flpGioHang.Controls.Add(item);
                        }));
                    }
                }
                finally
                {
                    SqlUtils.Conn.Close();
                }
            }
        }

        private void bgwGioHang_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picGioHangLoading.Hide();
            flpGioHang.Enabled = true;
            SetInputsEnabled(true);
            if (scheduleClose) Close();
        }

        #region InputControls

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkBox = (RadioButton)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_radio_button_checked_24px :
                Resources.ic_radio_button_unchecked_24px;
        }

        protected void SetError(Control control, string value)
        {
            control.Parent.ForeColor =
                string.IsNullOrEmpty(value) ?
                    Settings.Default.OutlineColor :
                    Settings.Default.InputErrorForeColor;
            errorProvider1.SetError(control, value);
        }

        private void ClearAllErrors()
        {
            foreach (Control control in new Control[]
            {
                cMaBan
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                    flpGioHang,
                    groupBox2,
                    cMaBan,
                    btnThanhToan
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XacNhanThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            scheduleClose = true;
            if (bgwGioHang.IsBusy)
            {
                e.Cancel = true;
                bgwGioHang.CancelAsync();
            }
        }
    }
}
