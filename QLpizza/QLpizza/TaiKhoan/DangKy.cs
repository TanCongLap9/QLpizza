using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using QLpizza.Properties;
using System.Net.Http;

namespace QLpizza
{
    public partial class DangKy : Form
    {
        private string maXacThuc;

        public DangKy()
        {
            InitializeComponent();
        }

        private async void DangKy_Load(object sender, EventArgs e)
        {
            await fieldsBox1.Load(-1);
            tMaND.Text = await MaGenerator.MaND();
            tMaQH.Text = "QH005";
            tMaCV.Text = "KH00V";
        }

        private async void btnGuiEmail_Click(object sender, EventArgs e)
        {
            if (!ValidateEmailInput()) return;
            SetInputsEnabled(false);
            try
            {
                maXacThuc = MaGenerator.Pin();
                using (HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri(Settings.Default.WebApp)
                })
                {
                    try
                    {
                        await client.GetAsync($"?type=accountCreation&to={tEmail.Text.Trim()}&id={maXacThuc}");
                        MessageBox.Show($"Một tin nhắn email đã được gửi đến {tEmail.Text.Trim()}.\nVui lòng xem hộp thư để nhận mã xác nhận.", "Đã gửi email");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(
                            "Có lỗi xảy ra trong quá trình gửi email. Quý khách vui lòng thử lại sau.\n" + exc.Message,
                            "Không thể gửi email",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            finally
            {
                SetInputsEnabled(true);
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tabPage1, tabPage2
            }) ctl.Enabled = enabled;
        }

        private bool ValidateEmailInput()
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tEmail })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    tabControl1.SelectedTab = tabPage1;
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) return valid;
            if ((error = Validator.Email(tEmail.Text)) != null)
            {
                tabControl1.SelectedTab = tabPage1;
                SetError(tEmail, error);
                valid = false;
            }
            if (!valid) return valid;
            return valid;
        }

        #region FieldsBox

        private void FieldsBox_Updating(object sender, CancelEventArgs e)
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tHoTen, tEmail, tSdt })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    tabControl1.SelectedTab = tabPage1;
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cGioiTinh })
                if (cbo.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage1;
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (MaskedTextBox mtx in new MaskedTextBox[] { tMaXacThuc })
                if (!mtx.MaskCompleted)
                {
                    tabControl1.SelectedTab = tabPage1;
                    SetError(mtx, "Đây là thông tin bắt buộc. Vui lòng nhấn vào nút gửi email để lấy mã xác thực.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if ((error = Validator.Email(tEmail.Text)) != null)
            {
                tabControl1.SelectedTab = tabPage1;
                SetError(tEmail, error);
                valid = false;
            }
            tSdt.Text = tSdt.Text.Replace(" ", "").Replace("(", "").Replace(")", "");
            if ((error = Validator.Sdt(tSdt.Text)) != null)
            {
                tabControl1.SelectedTab = tabPage1;
                SetError(tSdt, error);
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (tMaXacThuc.Text.Trim() != maXacThuc)
            {
                tabControl1.SelectedTab = tabPage1;
                SetError(tMaXacThuc, "Mã xác thực không đúng.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            foreach (TextBoxBase txt in new TextBoxBase[] { tTaiKhoan, tMatKhau, tXacNhanMatKhau })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    tabControl1.SelectedTab = tabPage2;
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if ((error = Validator.MatKhau(tMatKhau.Text)) != null)
            {
                tabControl1.SelectedTab = tabPage2;
                SetError(tMatKhau, error);
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (tMatKhau.Text != tXacNhanMatKhau.Text)
            {
                tabControl1.SelectedTab = tabPage2;
                SetError(tXacNhanMatKhau, "Vui lòng ghi lại đúng mật khẩu đã nhập.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (Validator.Id(SqlUtils.Query("SELECT TenDangNhap FROM NGUOIDUNG"), "TenDangNhap", tTaiKhoan.Text) != null)
            {
                tabControl1.SelectedTab = tabPage2;
                SetError(tTaiKhoan, "Tài khoản này đã được sử dụng. Vui lòng nhập tài khoản khác.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            tMatKhau.Text = PasswordEncoder.Encode(tMaND.Text, tMatKhau.Text);
        }

        private void FieldsBox_Updated(object sender, EventArgs e)
        {
            tMatKhau.Text = tXacNhanMatKhau.Text;
            if (fieldsBox1.RowsAffected != 0)
            {
                MessageBox.Show("Quý khách đã tạo tài khoản thành công.\nVui lòng đăng nhập để sử dụng tài khoản.", "Tạo tài khoản thành công.");
                Close();
            }
            else MessageBox.Show("Không thể tạo tài khoản. Vui lòng thử lại lần sau.", "Không thể tạo tài khoản.");
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

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tMatKhau.PasswordChar = tXacNhanMatKhau.PasswordChar =
                bHienMatKhau.Checked ? '\0' : '●';
            bHienMatKhau.Image =
                bHienMatKhau.Checked ?
                Resources.ic_visibility_24px :
                Resources.ic_visibility_off_24px;
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
                tHoTen, dNgaySinh, tEmail, tSdt, tMaXacThuc,
                cGioiTinh, tTaiKhoan, tMatKhau, tXacNhanMatKhau,
                nTrangThaiDangNhap, tMaND, tMaCV, tMaQH
            }) SetError(control, string.Empty);
        }

        #endregion

        private void ok_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
                btnTiep.PerformClick();
            else if (tabControl1.SelectedTab == tabPage2)
                btnDangKy.PerformClick();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlUtils.Conn.Close();
        }
    }
}