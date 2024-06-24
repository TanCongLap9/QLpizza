using QLpizza.CustomComponents;
using QLpizza.Properties;
using QLpizza.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.BanHang
{
    public partial class MuaPizza : Form
    {
        private List<PizzaModel> models = new List<PizzaModel>();
        private bool scheduleClose;
        private SqlDataAdapter gioHangAdapter;
        private DataTable gioHangTable = new DataTable();
        private XacNhanThanhToan xacNhanThanhToan;
        private Point gioHangScroll;
        private DataTable loaiTable;

        public MuaPizza()
        {
            InitializeComponent();
        }

        private async void Pizza_Load(object sender, EventArgs e)
        {
            while (true)
                try
                {
                    // Tải dữ liệu vào combobox
                    loaiTable = await SqlUtils.QueryAsync("SELECT * FROM LOAIPIZZA");
                    DataRow tatCa = loaiTable.NewRow();
                    tatCa.ItemArray = new object[] { null, "Tất cả" };
                    loaiTable.Rows.InsertAt(tatCa, 0);
                    cMaLoai.DataSource = loaiTable;
                    
                    // Tải CSDL giỏ hàng
                    gioHangAdapter = SqlUtils.GetDataAdpater("SELECT * FROM GIOHANG WHERE MaND = @MaND",
                        new Dictionary<string, object>
                        {
                            ["MaND"] = DangNhap.thongTinHienTai.MaND
                        });
                    gioHangAdapter.Fill(gioHangTable);
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
            btnThanhToan.Enabled = btnHuyGioHang.Enabled = gioHangTable.Rows.Count != 0;
            UpdateSoLuong();
            UpdateThanhTien();
            bgwPizza.RunWorkerAsync();
        }

        private async void btnDat_Click(object sender, EventArgs e)
        {
            gioHangScroll = new Point(-flpGioHang.AutoScrollPosition.X, -flpGioHang.AutoScrollPosition.Y);
            SetInputsEnabled(false);
            btnDat.Enabled = false;
            try
            {
                int cacPizzaSelectedIndex = (int)flpPizza.Tag;
                PizzaModel model = models[cacPizzaSelectedIndex];

                DataRow[] gioHangRowsResult = gioHangTable.Select($"MaPizza = '{model.MaPizza}'");
                if (gioHangRowsResult.Length == 0) // Chưa có trong giỏ hàng
                {
                    DataRow row = gioHangTable.NewRow();
                    row.SetField("MaND", DangNhap.thongTinHienTai.MaND);
                    row.SetField("MaPizza", model.MaPizza);
                    row.SetField("SoLuong", nSoLuong.Value);
                    gioHangTable.Rows.Add(row);
                }
                else // Đã có trong giỏ hàng
                {
                    int soLuong = gioHangRowsResult[0].Field<int>("SoLuong");
                    gioHangRowsResult[0].SetField("SoLuong", soLuong + nSoLuong.Value);
                }
                await Task.Run(() => gioHangAdapter.Update(gioHangTable));
                lStatus.Text = "Đã đặt món vào giỏ hàng.";
                UpdateGioHang();
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong lúc đặt hàng: " + exc.Message;
            }
            finally
            {
                SetInputsEnabled(true);
                btnDat.Enabled = true;
            }
        }

        private void tTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UpdatePizza(sender, e);
        }

        private void UpdatePizza(object sender, EventArgs e)
        {
            if (bgwPizza.IsBusy)
                bgwPizza.CancelAsync();
            while (bgwPizza.IsBusy)
                Application.DoEvents();
            btnDat.Enabled = false;
            bgwPizza.RunWorkerAsync();
        }

        #region GioHang

        private void bGioHang_CheckedChanged(object sender, EventArgs e)
        {
            if (bGioHang.Checked) // Expand
            {
                pnlGioHang.Show();
                bgwGioHang.RunWorkerAsync();
            }
            else
            {
                ClearList(flpGioHang);
                pnlGioHang.Hide();
            }
        }

        private void btnHuyGioHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc chắn muốn huỷ giỏ hàng hiện tại không? Hành động này không thể hoàn tác.",
                "Huỷ giỏ hàng", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
            ) != DialogResult.Yes) return;
            try
            {
                foreach (DataRow row in gioHangTable.Rows)
                    row.Delete();
                gioHangAdapter.Update(gioHangTable);
                lStatus.Text = "Đã huỷ giỏ hàng.";
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong quá trình huỷ giỏ hàng: " + exc.Message;
            }
            UpdateGioHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            xacNhanThanhToan = new XacNhanThanhToan()
            {
                MdiParent = this.MdiParent
            };
            xacNhanThanhToan.FormClosed += xacNhanThanhToan_FormClosed;
            Enabled = false;
            xacNhanThanhToan.Show();
        }

        private void UpdateGioHang()
        {
            UpdateSoLuong();
            UpdateThanhTien();
            btnThanhToan.Enabled = btnHuyGioHang.Enabled = gioHangTable.Rows.Count != 0;
            if (bGioHang.Checked)
                bgwGioHang.RunWorkerAsync();
        }

        private void UpdateSoLuong()
        {
            label2.Text = (
                from DataRow row
                in gioHangTable.Rows
                select row.Field<int>("SoLuong")
            ).Sum().ToString();
        }

        private void UpdateThanhTien()
        {
            nThanhTien.Value = Convert.ToDecimal(SqlUtils.ExecuteScalar("PROC_GIOHANG_THANHTIEN",
                new Dictionary<string, object>
                {
                    ["MaND"] = DangNhap.thongTinHienTai.MaND
                }, CommandType.StoredProcedure));
        }

        private void xacNhanThanhToan_FormClosed(object sender, EventArgs e)
        {
            Enabled = true;
            if (xacNhanThanhToan.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    "Hoá đơn đã được thanh toán thành công.\n" +
                    "Quý khách vui lòng đến quầy chờ nhân viên xử lý hoá đơn.\n" +
                    "\n" +
                    "Xin chân thành cảm ơn quý khách đã lựa chọn dịch vụ cửa hàng Pizza HIT của chúng tôi!",
                    "Thanh toán thành công");
                ((FormChinh)this.MdiParent).OpenForm(
                    new HoaDon()
                    {
                        WhereString = $"MaHoaDon = '{xacNhanThanhToan.MaHoaDon}'",
                        ReadOnly = true,
                        CanSearch = false,
                        ShowKhachTra = false,
                        ShowQR = true
                    });
                Close();
            }
        }

        #endregion

        #region Danh sách

        private void bgwPizza_DoWork(object sender, DoWorkEventArgs e)
        {
            object loai = DBNull.Value;

            Invoke(new Action(() =>
            {
                SetInputsEnabled(false);
                loai = cMaLoai.SelectedValue;
                picPizzaLoading.Show();
                ClearList(flpPizza);
            }));

            using (SqlDataReader reader = SqlUtils.ExecuteReader(
                "SELECT * FROM PIZZA WHERE (@MaLoai IS NULL OR MaLoai = @MaLoai) AND NgungBan = 0",
                new Dictionary<string, object>()
                {
                    ["MaLoai"] = loai
                }))
            {
                int i = 0;
                models = new List<PizzaModel>();
                try
                {
                    while (reader.Read())
                    {
                        if (bgwPizza.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        string tenPizza = reader.GetFieldValue<string>(reader.GetOrdinal("TenPizza"));
                        if (!SearchUtils.Contains(tTimKiem.Text.Trim(), tenPizza)) continue;

                        models.Add(new PizzaModel()
                        {
                            MaPizza = reader.GetFieldValue<string>(reader.GetOrdinal("MaPizza")),
                            TenPizza = tenPizza,
                            FileHinh = Path.Combine(Settings.Default.PizzaPath, reader.GetFieldValue<string>(reader.GetOrdinal("FileHinh"))),
                            GiaBan = reader.GetFieldValue<int>(reader.GetOrdinal("GiaBan")),
                            MaLoai = reader.GetFieldValue<string>(reader.GetOrdinal("MaLoai")),
                            SoLuong = 1
                        });

                        PizzaModel model = models[i];
                        PizzaItem item = new PizzaItem(model, i, false, true);
                        item.ItemClick += PizzaItem_Click;

                        Invoke(new Action(() =>
                        {
                            flpPizza.Controls.Add(item);
                        }));
                        i++;
                    }
                }
                finally
                {
                    SqlUtils.Conn.Close();
                }
            }
        }

        private void bgwGioHang_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke(new Action(() =>
            {
                SetInputsEnabled(false);
                picGioHangLoading.Show();
                ClearList(flpGioHang);
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
                            FileHinh = Path.Combine(Settings.Default.PizzaPath, reader.GetFieldValue<string>(reader.GetOrdinal("FileHinh"))),
                            GiaBan = reader.GetFieldValue<int>(reader.GetOrdinal("GiaBan")),
                            MaLoai = reader.GetFieldValue<string>(reader.GetOrdinal("MaLoai")),
                            SoLuong = reader.GetFieldValue<int>(reader.GetOrdinal("SoLuong"))
                        };

                        PizzaItem item = new PizzaItem(model, i, true, false);
                        item.ValueChanged += PizzaItem_ValueChanged;
                        item.Delete += PizzaItem_Delete;

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

        private void bgwPizzaWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picPizzaLoading.Hide();
            flpPizza.Enabled = true;
            SetInputsEnabled(true);
            if (scheduleClose && !bgwGioHang.IsBusy && e.Cancelled) Close();
        }

        private void bgwGioHang_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picGioHangLoading.Hide();
            flpGioHang.Enabled = true;
            SetInputsEnabled(true);
            flpGioHang.AutoScrollPosition = gioHangScroll;
            if (scheduleClose && !bgwPizza.IsBusy && e.Cancelled) Close();
        }

        private void ClearList(Panel list)
        {
            list.Tag = null;
            list.SuspendLayout();
            while (list.Controls.Count != 0)
            {
                Control ctl = list.Controls[0];
                if (!ctl.IsDisposed) ctl.Dispose();
                else list.Controls.Remove(ctl);
            }
            list.ResumeLayout();
        }

        #endregion

        #region PizzaItem

        private void PizzaItem_Click(object sender, EventArgs e)
        {
            btnDat.Enabled = true;
        }

        private void PizzaItem_ValueChanged(object sender, EventArgs e)
        {
            PizzaItem item = (PizzaItem)sender;
            PizzaModel model = item.Model;
            try
            {
                DataRow[] gioHangRowsResult = gioHangTable.Select($"MaPizza = '{model.MaPizza}'");
                if (gioHangRowsResult.Length != 0)
                {
                    gioHangRowsResult[0].SetField("SoLuong", model.SoLuong);
                    gioHangAdapter.Update(gioHangRowsResult);
                    lStatus.Text = "Đã thay đổi số lượng món đặt.";
                }
                else lStatus.Text = "Không tìm thấy món cần thay đổi số lượng.";
                UpdateSoLuong();
                UpdateThanhTien();
                lStatus.Text = "Đã thay đổi số lượng món đặt.";
            }
            catch (SqlException exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong quá trình thay đổi số lượng: " + exc.Message;
            }
        }

        private void PizzaItem_Delete(object sender, EventArgs e)
        {
            gioHangScroll = new Point(-flpGioHang.AutoScrollPosition.X, -flpGioHang.AutoScrollPosition.Y);
            PizzaItem item = (PizzaItem)sender;
            PizzaModel model = item.Model;
            try
            {
                DataRow[] gioHangRowsResult = gioHangTable.Select($"MaPizza = '{model.MaPizza}'");
                if (gioHangRowsResult.Length != 0)
                {
                    gioHangRowsResult[0].Delete();
                    gioHangAdapter.Update(gioHangRowsResult);
                    lStatus.Text = "Đã xoá món khỏi giỏ hàng.";
                }
                else lStatus.Text = "Không tìm thấy món cần xoá.";
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong lúc xoá món: " + exc.Message;
            }
            UpdateGioHang();
        }

        #endregion

        #region InputControls

        private void InputControl_Enter(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.AccentBackColor;
        }

        private void InputControl_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.OutlineColor;
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[] {
                cMaLoai,
                tTimKiem,
                nSoLuong,
                bGioHang,
                flpPizza,
                flpGioHang
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pizza_FormClosing(object sender, FormClosingEventArgs e)
        {
            scheduleClose = true;
            if (bgwPizza.IsBusy) {
                bgwPizza.CancelAsync();
                e.Cancel = true;
            }
            if (bgwGioHang.IsBusy) {
                bgwGioHang.CancelAsync();
                e.Cancel = true;
            }
        }
    }
}