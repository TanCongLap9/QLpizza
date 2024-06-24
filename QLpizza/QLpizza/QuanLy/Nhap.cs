using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.QuanLy
{
    public partial class Nhap : FormQuanLyDoi
    {
        private DataTable nguyenLieuTable;
        private string whereString;

        public Nhap()
        {
            InitializeComponent();
            base.TabControl = tabControl1;
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.MasterIdField = tMaNhap;
            base.DetailIdField = tMaNhap2;
            base.ToDetail = btnXemChiTiet;
            base.MasterPage = tabPage2;
            base.DetailPage = tabPage3;
            base.MasterShuffleButton = shuffle;
            base.Search = Tuple.Create<Control, Control>(tTimKiemNhap, tTimKiemChiTiet);
            base.RadioButtons = new RadioButton[] { chkTimNgayLap, chkTimMaNhap };
            base.Fields = new Control[] {
                dTuNgay, dDenNgay, tMaNhapTim, tMaNhap,
                groupBox7, cMaNV, dNgayNhap, dThoiGianNhap,
                tMaNhap2, cMaNL, nSoLuong, tDVT
            };
            base.CloseButton = (Button)this.CancelButton;
            base.OkButton = (Button)this.AcceptButton;
        }

        private void Nhap_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            fieldsBox1.AutoFields.Add(nThanhTien, async () => {
                object result = await SqlUtils.ExecuteScalarAsync("PROC_NHAP_TONGTIEN",
                    new Dictionary<string, object>()
                    {
                        ["MaNhap"] = fieldsBox1.SelectedRow.Field<string>("MaNhap")
                    }, CommandType.StoredProcedure
                );
                return Convert.ToInt64(result);
            });
            fieldsBox2.AutoFields.Add(nDonGia, async () =>
            {
                object result = await SqlUtils.ExecuteScalarAsync("SELECT DonGia FROM NGUYENLIEU WHERE MaNL = @MaNL",
                    new Dictionary<string, object>()
                    {
                        ["MaNL"] = fieldsBox2.SelectedRow.Field<string>("MaNL")
                    });
                return Convert.ToInt64(result);
            });
            fieldsBox2.AutoFields.Add(nTongTien, async () =>
            {
                object result = await SqlUtils.ExecuteScalarAsync("PROC_NHAP_TONGTIEN",
                    new Dictionary<string, object>()
                    {
                        ["MaNhap"] = fieldsBox1.SelectedRow.Field<string>("MaNhap"),
                        ["MaNL"] = fieldsBox2.SelectedRow.Field<string>("MaNL")
                    }, CommandType.StoredProcedure);
                return Convert.ToInt64(result);
            });
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaNCC.DataSource = SqlUtils.Query("SELECT MaNCC, TenNCC FROM NHACUNGCAP;");
            cMaNV.DataSource = SqlUtils.Query(
                "SELECT MaND, HoTen, MaND + ' (' + HoTen + ')' AS Display FROM NGUOIDUNG WHERE MaCongViec <> 'KH00V'"
            );
            cMaNL.DataSource = nguyenLieuTable = SqlUtils.Query("SELECT MaNL, TenNL, DonViTinh FROM NGUYENLIEU;");
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
            else if (chkTimMaNhap.Checked)
            {
                foreach (Control txt in new Control[] { tMaNhapTim })
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        SetError(txt, "Đây là thông tin bắt buộc.");
                        valid = false;
                    }
                if (!valid) return valid;
                if (!Regex.IsMatch(tMaNhapTim.Text.Trim(), @"^[A-Z0-9]{4}O$"))
                {
                    SetError(
                        tMaNhapTim,
                        "Vui lòng nhập mã đúng dạng: xxxxO, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số."
                    );
                    valid = false;
                }
                if (!valid) return valid;
            }
            return valid;
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!ValidateTimKiemInput()) return;
            Dictionary<string, object> parameters = null;
            if (chkTimNgayLap.Checked)
            {
                whereString = $"NgayNhap BETWEEN '{dTuNgay.Value:yyyy-MM-dd}' AND '{dDenNgay.Value.Date:yyyy-MM-dd}'";
            }
            else if (chkTimMaNhap.Checked)
            {
                whereString = $"MaNhap = '{tMaNhapTim.Text.Trim()}'";
            }

            string queryString = $@"
SELECT TOP 50 MaNhap, NHANVIEN.HoTen AS HoTenNV, NgayNhap, ThoiGianNhap
FROM NHAP
JOIN NGUOIDUNG NHANVIEN ON NHAP.MaNV = NHANVIEN.MaND
WHERE {whereString}
ORDER BY NgayNhap DESC, ThoiGianNhap DESC";
            DataTable result = await SqlUtils.QueryAsync(queryString, parameters);
            dgvKetQua.DataSource = result;
            btnQuanLy.Enabled = true;
        }

        private async void btnQuanLy_Click(object sender, EventArgs e)
        {
            string queryString = $@"
SELECT TOP 50 *
FROM NHAP WHERE {whereString}
ORDER BY NgayNhap DESC, ThoiGianNhap DESC";
            fieldsBox1.SelectCommand = queryString;
            await fieldsBox1.Load();
            tabControl1.SelectedTab = tabPage2;
        }

        private void cMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cMaNL.SelectedIndex == -1)
            {
                tDVT.Text = string.Empty;
                return;
            }
            foreach (DataRow nlRow in nguyenLieuTable.Rows)
                if (nlRow.Field<string>("MaNL") == cMaNL.SelectedValue.ToString()) {
                    tDVT.Text = nlRow.Field<string>("DonViTinh");
                    break;
                }
        }

        private void nSoLuong_ValueChanged(object sender, EventArgs e)
        {
            nThanhTien.Value = nDonGia.Value * nSoLuong.Value;
        }

        protected override void MasterFieldsBox_Cleared(object sender, EventArgs e)
        {
            base.MasterFieldsBox_Cleared(sender, e);
            cMaNV.SelectedValue = DangNhap.thongTinHienTai.MaND;
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaNhap })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cMaNCC, cMaNV })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^[A-Z0-9]{4}O$").IsMatch(tMaNhap.Text.Trim()))
            {
                SetError(tMaNhap,
                    "Vui lòng nhập mã đúng dạng: xxxxO, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số."
                );
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaNhap FROM NHAP"), "MaNhap", tMaNhap.Text.Trim())) != null)
                {
                    SetError(tMaNhap, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void DetailFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.DetailFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (ComboBox cbo in new ComboBox[] { cMaNL })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox2.SelectedIndex == -1)
            {
                if ((error = Validator.Id(fieldsBox2.Table, "MaNL", cMaNL.SelectedValue.ToString())) != null)
                {
                    SetError(cMaNL, error);
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
            e.Value = string.Format("{0} ({1:d} {2:t})",
                row.Field<string>("MaNhap"),
                row.Field<DateTime>("NgayNhap"),
                row.Field<TimeSpan>("ThoiGianNhap"));
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            foreach (DataRow nlRow in nguyenLieuTable.Rows)
                if (nlRow.Field<string>("MaNL") == row.Field<string>("MaNL"))
                {
                    e.Value = string.Format("{0} ({1} {2})",
                        nlRow.Field<string>("TenNL"),
                        row.Field<double>("SoLuong"),
                        nlRow.Field<string>("DonViTinh"));
                    break;
                }
        }
    }
}
