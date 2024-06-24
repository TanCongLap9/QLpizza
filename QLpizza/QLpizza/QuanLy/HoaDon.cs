using QLpizza.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.QuanLy
{
    public partial class HoaDon : FormQuanLyDoi
    {
        private DataTable pizzaTable;
        public string WhereString { get; set; }
        public bool ReadOnly { get; set; } = false;
        public bool CanSearch { get; set; } = true;
        public bool ShowKhachTra { get; set; } = true;
        public bool ShowQR { get; set; } = false;

        public HoaDon()
        {
            InitializeComponent();
            base.TabControl = tabControl1;
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.MasterIdField = tMaHD;
            base.DetailIdField = tMaHD2;
            base.MasterPage = tabPage2;
            base.DetailPage = tabPage3;
            base.Search = Tuple.Create<Control, Control>(tTimKiemHoaDon, tTimKiemChiTiet);
            base.ToDetail = btnXemChiTiet;
            base.RadioButtons = new RadioButton[] { chkTimNgayLap, chkTimMaHD };
            base.MasterShuffleButton = btnShuffle;
            base.Fields = new Control[] {
                dTuNgay, dDenNgay, tMaHDTim, tMaHD,
                cMaKH, cMaNV, cMaBan, dNgayDat,
                dThoiGianDat, nKhachTra, tMaHD2, cMaPizza, tGhiChu,
                nSoLuong, nTongTien };
            base.CloseButton = (Button)this.CancelButton;
            this.OkButton = (Button)this.AcceptButton;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            picMaQR.Visible = ShowQR;
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = ReadOnly ||
                (DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0);
            panel18.Enabled = btnTimKiem.Enabled = CanSearch;
            groupBox12.Visible = groupBox13.Visible = groupBox8.Visible = ShowKhachTra;
            if (!ShowKhachTra) this.Text = "Xem hoá đơn";
            fieldsBox1.AutoFields.Add(nThanhTien, async () =>
            {
                object result = await SqlUtils.ExecuteScalarAsync("PROC_HOADON_TONGTIEN",
                    new Dictionary<string, object>()
                    {
                        ["MaHoaDon"] = fieldsBox1.SelectedRow.Field<string>("MaHoaDon")
                    }, CommandType.StoredProcedure);
                return Convert.ToInt64(result);
            });
            fieldsBox2.AutoFields.Add(nGiaBan, async () =>
            {
                object result = await SqlUtils.ExecuteScalarAsync(
                    "SELECT GiaBan FROM PIZZA WHERE MaPizza = @MaPizza",
                    new Dictionary<string, object>()
                    {
                        ["MaPizza"] = fieldsBox2.SelectedRow.Field<string>("MaPizza")
                    });
                return Convert.ToInt64(result);
            });
            fieldsBox2.AutoFields.Add(nTongTien, async () =>
            {
                object result = await SqlUtils.ExecuteScalarAsync(
                    "PROC_HOADON_TONGTIEN",
                    new Dictionary<string, object>()
                    {
                        ["MaHoaDon"] = fieldsBox1.SelectedRow.Field<string>("MaHoaDon"),
                        ["MaPizza"] = fieldsBox2.SelectedRow.Field<string>("MaPizza")
                    }, CommandType.StoredProcedure);
                return Convert.ToInt64(result);
            });
            if (WhereString != null)
            {
                btnQuanLy.Enabled = true;
                btnQuanLy.PerformClick();
                btnQuanLy.Enabled = false;
            }
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaBan.DataSource = SqlUtils.Query("SELECT MaBan, TenBan FROM BAN;");
            // Khách hàng đặt cũng có thể là nhân viên luôn thì sao?...
            cMaKH.DataSource = SqlUtils.Query("SELECT MaND, HoTen, MaND + ' (' + HoTen + ')' AS Display FROM NGUOIDUNG");
            cMaNV.DataSource = SqlUtils.Query("SELECT MaND, HoTen, MaND + ' (' + HoTen + ')' AS Display FROM NGUOIDUNG WHERE MaCongViec <> 'KH00V'");
            cMaPizza.DataSource = pizzaTable = SqlUtils.Query("SELECT MaPizza, TenPizza FROM PIZZA");
            cPhuongThucTra.DataSource = new Tuple<int, string>[] {
                Tuple.Create(0, "Tiền mặt"),
                Tuple.Create(1, "Thẻ tín dụng"),
                Tuple.Create(2, "Ví điện tử"),
            };
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!ValidateTimKiemInput()) return;
            Dictionary<string, object> parameters = null;
            if (chkTimNgayLap.Checked)
            {
                WhereString = $"NgayDat BETWEEN '{dTuNgay.Value.ToString("yyyy-MM-dd")}' AND '{dDenNgay.Value.Date.ToString("yyyy-MM-dd")}'";
            }
            else if (chkTimMaHD.Checked)
            {
                WhereString = $"MaHoaDon = '{tMaHDTim.Text.Trim()}'";
            }

            string queryString = $@"
SELECT TOP 50 MaHoaDon, KHACHHANG.HoTen AS HoTenKH, NHANVIEN.HoTen AS HoTenNV, KhachTra, NgayDat, ThoiGianDat
FROM HOADON
LEFT JOIN NGUOIDUNG NHANVIEN ON HOADON.MaNV = NHANVIEN.MaND
LEFT JOIN NGUOIDUNG KHACHHANG ON HOADON.MaKH = KHACHHANG.MaND
WHERE {WhereString}
ORDER BY NgayDat DESC, ThoiGianDat DESC";
            DataTable result = await SqlUtils.QueryAsync(queryString, parameters);
            dgvKetQua.DataSource = result;
            btnQuanLy.Enabled = result.Rows.Count != 0;
        }

        private async void btnQuanLy_Click(object sender, EventArgs e)
        {
            string queryString = $@"
SELECT TOP 50 *
FROM HOADON WHERE {WhereString}
ORDER BY NgayDat DESC, ThoiGianDat DESC";
            fieldsBox1.SelectCommand = queryString;
            await fieldsBox1.Load();
            tabControl1.SelectedTab = tabPage2;
        }

        private bool ValidateTimKiemInput()
        {
            bool valid = true;
            if (chkTimNgayLap.Checked)
            {
                if (dDenNgay.Value.Date < dTuNgay.Value.Date)
                {
                    SetError(dDenNgay, "Ngày kết thúc không thể trước ngày bắt đầu.");
                    valid = false;
                }
                if (!valid) return valid;
                if (dDenNgay.Value.Date.Subtract(dTuNgay.Value.Date) > TimeSpan.FromDays(30))
                {
                    SetError(dDenNgay, "Số ngày tìm kiếm tối đa là 30 ngày kể từ ngày bắt đầu.");
                    valid = false;
                }
                if (!valid) return valid;
            }
            else if (chkTimMaHD.Checked)
            {
                foreach (Control txt in new Control[] { tMaHDTim })
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        SetError(txt, "Đây là thông tin bắt buộc.");
                        valid = false;
                    }
                if (!valid) return valid;
                if (!Regex.IsMatch(tMaHDTim.Text.Trim(), @"^[A-Z0-9]{8}H$"))
                {
                    SetError(tMaHDTim, "Vui lòng nhập mã đúng dạng: xxxxH, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                    valid = false;
                }
                if (!valid) return valid;
            }
            return valid;
        }

        private void UpdateTienThoi(object sender, EventArgs e)
        {
            nTienThoi.Value = nKhachTra.Value - nThanhTien.Value;
        }

        private void UpdateTienThoi(object sender, KeyEventArgs e)
        {
            decimal value;
            if (decimal.TryParse(nKhachTra.Text.Replace(",", string.Empty).Replace(".", string.Empty), out value))
                nTienThoi.Value = value - nThanhTien.Value;
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaHD })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cMaBan, cMaKH })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^[A-Z0-9]{8}H$").IsMatch(tMaHD.Text.Trim()))
            {
                SetError(tMaHD, "Vui lòng nhập mã đúng dạng: xxxxH, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex != -1 && nKhachTra.Value < nThanhTien.Value)
            {
                SetError(nKhachTra, "Vui lòng nhập số tiền lớn hơn hoặc bằng thành tiền.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaHoaDon FROM HOADON"), "MaHoaDon", tMaHD.Text.Trim())) != null)
                {
                    SetError(tMaHD, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
            if (cMaNV.SelectedIndex == -1)
                cMaNV.SelectedValue = DangNhap.thongTinHienTai.MaND;
        }

        protected override void MasterFieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            base.MasterFieldsBox_FieldsFilled(sender, e);
            if (ShowQR)
                picMaQR.Image = QRCodeHelper.GetQRCode(
                    Settings.Default.WebApp + "?id=" + tMaHD.Text,
                    2, Color.Black, Color.White, QRCodeGenerator.ECCLevel.L,
                    icon: Resources.pizza_hit, iconBorderWidth: 2);
        }
        
        protected override void MasterFieldsBox_Cleared(object sender, EventArgs e)
        {
            base.MasterFieldsBox_Cleared(sender, e);
            btnShuffle.Enabled = false;
        }

        protected override void DetailFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.DetailFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (ComboBox cbo in new ComboBox[] { cMaPizza })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox2.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaPizza FROM PIZZA"), "MaPizza", cMaPizza.SelectedValue.ToString())) != null)
                {
                    SetError(cMaPizza, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((fieldsBox1.Fields == null || fieldsBox1.Fields.Count == 0) && (e.TabPage == tabPage2 || e.TabPage == tabPage3))
            {
                MessageBox.Show(
                    "Tìm kiếm và nhấn nút quản lý để tải dữ liệu.",
                    "Chưa nạp dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }
            base.TabControl_Selecting(sender, e);
        }

        private void danhSach1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            e.Value = string.Format("{0} ({1:d} {2:t}){3}",
                row.Field<string>("MaHoaDon"),
                row.Field<DateTime>("NgayDat"),
                row.Field<TimeSpan>("ThoiGianDat"),
                row.Field<int>("KhachTra") == 0 ? " - Mới" : string.Empty);
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            foreach (DataRow nlRow in pizzaTable.Rows)
                if (nlRow.Field<string>("MaPizza") == row.Field<string>("MaPizza"))
                {
                    e.Value = string.Format("{0} x{1}",
                        nlRow.Field<string>("TenPizza"),
                        row.Field<int>("SoLuong"));
                    break;
                }
        }
    }
}
