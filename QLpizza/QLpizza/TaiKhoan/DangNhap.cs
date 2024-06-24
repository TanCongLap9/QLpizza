using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QLpizza.Properties;

namespace QLpizza
{
    public partial class DangNhap : Form
    {
        public static NguoiDungModel thongTinHienTai;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // Đọc thông tin đăng nhập đã lưu
            Settings settings = Settings.Default;
            if (!string.IsNullOrEmpty(settings.TenDangNhap))
            {
                tTenDangNhap.Text = settings.TenDangNhap;
                tMatKhau.Text = settings.MatKhau;
                bLuuThongTin.Checked = true;
            }
            tNguonDuLieu.Text = settings.NguonDuLieu;
            cCheDoKetNoi.SelectedIndex = settings.CheDoKetNoi;
            tTenDangNhapSql.Text = settings.TenDangNhapSql;
            tMatKhauSql.Text = settings.MatKhauSql;
            SqlUtils.BuildConnection(tNguonDuLieu.Text, cCheDoKetNoi.SelectedIndex, tTenDangNhapSql.Text, tMatKhauSql.Text);
        }
        
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            SetInputsEnabled(false);
            try
            {
                lStatus.Text = "Đang đăng nhập...";
                // Lấy các thông tin của người đăng nhập
                DataTable table = await SqlUtils.QueryAsync(
                    "PROC_NGUOIDUNG_DANGNHAP",
                    new Dictionary<string, object>()
                    {
                        ["TenDangNhap"] = tTenDangNhap.Text
                    },
                    null,
                    CommandType.StoredProcedure);
                if (table.Rows.Count == 0)
                {
                    SetError(tTenDangNhap, "Tài khoản không tìm thấy.");
                    lStatus.Text = string.Empty;
                    return;
                }
                DataRow firstRow = table.Rows[0];
                if (firstRow.Field<string>("MatKhau") != PasswordEncoder.Encode(firstRow.Field<string>("MaND"), tMatKhau.Text))
                {
                    SetError(tMatKhau, "Mật khẩu nhập không đúng.");
                    lStatus.Text = string.Empty;
                    return;
                }
                if (firstRow.Field<bool>("TrangThaiDangNhap") != false)
                {
                    lStatus.Text = "Người này đang được đăng nhập ở một máy tính khác.";
                    return;
                }
                // Cập nhật thông tin đăng nhập hiện tại
                thongTinHienTai = new NguoiDungModel()
                {
                    MaND = firstRow.Field<string>("MaND"),
                    HoTen = firstRow.Field<string>("HoTen"),
                    TenDangNhap = firstRow.Field<string>("TenDangNhap"),
                    Email = firstRow.Field<string>("Email"),
                    SDT = firstRow.Field<string>("SDT"),
                    GioiTinh = firstRow.Field<string>("GioiTinh"),
                    NgaySinh = firstRow.Field<DateTime>("NgaySinh"),
                    MaCongViec = firstRow.Field<string>("MaCongViec"),
                    MaQuyen = firstRow.Field<string>("MaQuyen")
                };
                foreach (DataRow row in table.Rows)
                {
                    thongTinHienTai.Quyen[row.Field<string>("TenForm")] = new int[] {
                        row.Field<int>("DuocDoc"),
                        row.Field<int>("DuocGhi")
                    };
                }
                // Sửa đổi trạng thái đăng nhập
                int rowsAffected = await SqlUtils.ExecuteNonQueryAsync(
                    "UPDATE NGUOIDUNG SET TrangThaiDangNhap = 1 WHERE MaND = @MaND;",
                    new Dictionary<string, object>() { ["MaND"] = thongTinHienTai.MaND }
                );
                if (rowsAffected == 0)
                {
                    lStatus.Text = "Không thể cập nhật trạng thái đăng nhập.";
                    return;
                }
                // Lưu thông tin
                Settings settings = Settings.Default;
                settings.TenDangNhap = settings.MatKhau = null;
                if (bLuuThongTin.Checked)
                {
                    settings.TenDangNhap = tTenDangNhap.Text;
                    settings.MatKhau = tMatKhau.Text;
                }
                settings.Save();
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra: " + exc.Message;
            }
            finally
            {
                SetInputsEnabled(true);
                SqlUtils.Conn.Close();
            }
            if (thongTinHienTai != null)
            {
                lStatus.Text = "Đăng nhập thành công.";
                this.Hide();
                FormChinh formChinh = new FormChinh();
                formChinh.FormClosed += ShowForm;
                formChinh.Show();
            }
        }

        private void cCheDoDangNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cCheDoKetNoi.SelectedIndex == 0)
                tTenDangNhapSql.Text = tMatKhauSql.Text = "";
            tTenDangNhapSql.Enabled = tMatKhauSql.Enabled = bHienMatKhauSql.Enabled = cCheDoKetNoi.SelectedIndex != 0;
        }

        private void ConnectionSettings_Validated(object sender, EventArgs e)
        {
            Settings settings = Settings.Default;
            settings.NguonDuLieu = tNguonDuLieu.Text;
            settings.CheDoKetNoi = cCheDoKetNoi.SelectedIndex;
            settings.TenDangNhapSql = tTenDangNhapSql.Text;
            settings.MatKhauSql = tMatKhauSql.Text;
            settings.Save();
            SqlUtils.BuildConnection(tNguonDuLieu.Text, cCheDoKetNoi.SelectedIndex, tTenDangNhapSql.Text, tMatKhauSql.Text);
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            foreach (Control ctl in new Control[] { tTenDangNhap, tMatKhau })
                if (string.IsNullOrWhiteSpace(ctl.Text))
                {
                    SetError(ctl, "Vui lòng điền thông tin này.");
                    tabControl1.SelectedTab = tabPage1;
                    valid = false;
                }
            if (!valid) return valid;
            foreach (Control ctl in new Control[] { tNguonDuLieu })
                if (string.IsNullOrWhiteSpace(ctl.Text))
                {
                    SetError(ctl, "Vui lòng điền thông tin này.");
                    tabControl1.SelectedTab = tabPage2;
                    valid = false;
                }
            foreach (ComboBox ctl in new ComboBox[] { cCheDoKetNoi })
                if (cCheDoKetNoi.SelectedIndex == -1)
                {
                    SetError(ctl, "Vui lòng điền thông tin này.");
                    tabControl1.SelectedTab = tabPage1;
                    valid = false;
                }
            if (cCheDoKetNoi.SelectedIndex != 0)
                foreach (Control ctl in new Control[] { tTenDangNhapSql, tMatKhauSql })
                    if (string.IsNullOrWhiteSpace(ctl.Text))
                    {
                        SetError(ctl, "Vui lòng điền thông tin này.");
                        tabControl1.SelectedTab = tabPage2;
                        valid = false;
                    }
            return valid;
        }

        private void ShowForm(object sender, EventArgs e)
        {
            lStatus.Text = string.Empty;
            this.Show();
        }

        #region Điều hướng

        private void btnTuyChinhKetNoi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void lDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DangKy().ShowDialog();
            this.Show();
        }

        private void lQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new QuenMatKhau().ShowDialog();
            this.Show();
        }

        #endregion

        #region InputControls

        private void InputControl_Enter(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.AccentBackColor;
            SetError((Control)sender, string.Empty);
        }

        private void InputControl_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.OutlineColor;
            SetError((Control)sender, string.Empty);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_check_box_24px :
                Resources.ic_check_box_outline_blank_24px;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            new Dictionary<CheckBox, TextBox>
            {
                [bHienMatKhau] = tMatKhau,
                [bHienMatKhauSql] = tMatKhauSql
            }[chk].PasswordChar = chk.Checked ? '\0' : '●';
            chk.Image = chk.Checked ? Resources.ic_visibility_24px : Resources.ic_visibility_off_24px;
        }

        private void SetError(Control control, string value)
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
                tTenDangNhap, tMatKhau,
                tNguonDuLieu, cCheDoKetNoi,
                tTenDangNhapSql, tMatKhauSql
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tabPage1, tabPage2
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
