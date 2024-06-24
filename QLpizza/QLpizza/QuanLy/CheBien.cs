using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace QLpizza.QuanLy
{
    public partial class CheBien : FormQuanLyDoi
    {
        private DataTable nlTable;
        private string whereString;

        public CheBien()
        {
            InitializeComponent();
            base.TabControl = tabControl1;
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.MasterIdField = tMaCheBien;
            base.DetailIdGetFromMasterField = cMaCT;
            base.DetailIdField = tMaCT2;
            base.MasterPage = tabPage2;
            base.DetailPage = tabPage3;
            base.ToDetail = btnXemChiTiet;
            base.MasterShuffleButton = btnShuffle;
            base.Search = Tuple.Create<Control, Control>(tTimKiemPhieuCheBien, tTimKiemCongThuc);
            base.RadioButtons = new RadioButton[] {
                chkTimMaHD, chkTimNgayLap };
            base.Fields = new Control[] {
                dTuNgay, dDenNgay, tMaCheBienTim,
                tMaCheBien, tMaHD, cMaNV, cMaCT,
                dNgayLap, dThoiGianLap, tMaCT2, cMaNL,
                nSoLuong, tDVT, nThoiGianCheBien };
            base.CloseButton = (Button)this.CancelButton;
            base.OkButton = (Button)this.AcceptButton;
        }

        private void CheBien_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            fieldsBox2.AutoFields.Add(tDVT, () => {
                foreach (DataRow nlRow in nlTable.Rows)
                    if (nlRow.Field<string>("MaNL") == fieldsBox2.SelectedRow.Field<string>("MaNL"))
                        return Task.FromResult<object>(nlRow.Field<string>("DonViTinh"));
                return null;
            });
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaNV.DataSource = SqlUtils.Query("SELECT MaND, HoTen FROM NGUOIDUNG WHERE MaCongViec <> 'KH00V'");
            cMaNL.DataSource = nlTable = SqlUtils.Query("SELECT MaNL, TenNL, DonViTinh FROM NGUYENLIEU");
            cMaCT.DataSource = SqlUtils.Query("SELECT MaCongThuc, TenPizza, " +
                "MaCongThuc + ' - ' + TenPizza AS Display FROM CONGTHUC " +
                "JOIN CHITIETHOADON ON CONGTHUC.MaPizza = CHITIETHOADON.MaPizza " +
                "JOIN PIZZA ON CHITIETHOADON.MaPizza = PIZZA.MaPizza");
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!ValidateTimKiemInput()) return;
            Dictionary<string, object> parameters = null;
            if (chkTimNgayLap.Checked)
            {
                whereString = $"NgayLap BETWEEN '{dTuNgay.Value.ToString("yyyy-MM-dd")}' AND '{dDenNgay.Value.Date.ToString("yyyy-MM-dd")}'";
            }
            else if (chkTimMaHD.Checked)
            {
                whereString = $"MaCheBien = '{tMaCheBienTim.Text.Trim()}'";
            }

            string queryString = $@"
SELECT TOP 50 MaCheBien, CONGTHUC.MaCongThuc, TenPizza
FROM CHEBIEN
JOIN CONGTHUC ON CHEBIEN.MaCongThuc = CONGTHUC.MaCongThuc
JOIN PIZZA ON CONGTHUC.MaPizza = PIZZA.MaPizza
WHERE {whereString}
ORDER BY NgayLap DESC, ThoiGianLap DESC";
            DataTable result = await SqlUtils.QueryAsync(queryString, parameters);
            dgvKetQua.DataSource = result;
            btnQuanLy.Enabled = true;
        }

        private async void btnQuanLy_Click(object sender, EventArgs e)
        {
            string queryString = $@"
SELECT TOP 50 *
FROM CHEBIEN WHERE {whereString}
ORDER BY NgayLap DESC, ThoiGianLap DESC";
            fieldsBox1.SelectCommand = queryString;
            await fieldsBox1.Load();
            tabControl1.SelectedTab = tabPage2;
        }

        private void tMaHD_Validated(object sender, EventArgs e)
        {
            cMaCT.DataSource = SqlUtils.Query(
                "SELECT MaCongThuc, TenPizza, " +
                "MaCongThuc + ' - ' + TenPizza AS Display FROM CONGTHUC " +
                "JOIN CHITIETHOADON ON CONGTHUC.MaPizza = CHITIETHOADON.MaPizza " +
                "JOIN PIZZA ON CHITIETHOADON.MaPizza = PIZZA.MaPizza " +
                "WHERE MaHoaDon = @MaHoaDon",
                new Dictionary<string, object>
                {
                    ["MaHoaDon"] = tMaHD.Text.Trim()
                });
        }

        private bool ValidateTimKiemInput()
        {
            ClearAllErrors();
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
                foreach (Control txt in new Control[] { tMaCheBienTim })
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        SetError(txt, "Đây là thông tin bắt buộc.");
                        valid = false;
                    }
                if (!valid) return valid;
                if (!Regex.IsMatch(tMaCheBienTim.Text.Trim(), @"^[A-Z0-9]{8}B$"))
                {
                    SetError(tMaCheBienTim, "Vui lòng nhập mã đúng dạng: xxxxxxxxB, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                    valid = false;
                }
                if (!valid) return valid;
            }
            return valid;
        }

        protected override void MasterFieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            base.MasterFieldsBox_FieldsFilled(sender, e);
            cMaCT.DataSource = SqlUtils.Query("SELECT MaCongThuc, TenPizza, " +
                "MaCongThuc + ' - ' + TenPizza AS Display FROM CONGTHUC " +
                "JOIN PIZZA ON CONGTHUC.MaPizza = PIZZA.MaPizza ",
                new Dictionary<string, object>
                {
                    ["MaHoaDon"] = tMaHD.Text.Trim()
                });
            cMaCT.SelectedValue = fieldsBox1.SelectedRow.Field<object>("MaCongThuc");
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaCheBien })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (Control txt in new Control[] { tMaHD })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc. Vào form quản lý hoá đơn để biết các mã hoá đơn.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cMaNV, cMaCT })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^[A-Z0-9]{8}B$").IsMatch(tMaCheBien.Text.Trim()))
            {
                SetError(tMaCheBien, "Vui lòng nhập mã đúng dạng: xxxxxxxxB, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaCheBien FROM CHEBIEN"), "MaCheBien", tMaCheBien.Text.Trim())) != null)
                {
                    SetError(tMaCheBien, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void MasterFieldsBox_Cleared(object sender, EventArgs e)
        {
            base.MasterFieldsBox_Cleared(sender, e);
            cMaNV.SelectedValue = DangNhap.thongTinHienTai.MaND;
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
            e.Value = string.Format("{0} ({1:d} {2:t})",
                row.Field<string>("MaCheBien"),
                row.Field<DateTime>("NgayLap"),
                row.Field<TimeSpan>("ThoiGianLap"));
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            foreach (DataRow nlRow in nlTable.Rows)
                if (row.Field<string>("MaNL") == nlRow.Field<string>("MaNL"))
                {
                    e.Value = string.Format("{0} ({1:g3} {2})",
                        nlRow.Field<string>("TenNL"),
                        row.Field<double>("SoLuong"),
                        nlRow.Field<string>("DonViTinh"));
                    break;
                }
        }
    }
}
