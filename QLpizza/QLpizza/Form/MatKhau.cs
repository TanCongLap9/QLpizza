using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLpizza.Properties;

namespace QLpizza
{
    public partial class MatKhau : Form
    {
        private string matKhauCu, matKhau;
        public MatKhau()
        {
            InitializeComponent();
        }

        private async void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            SetInputsEnabled(false);
            try
            {
                int rowsAffected = await SqlUtils.ExecuteNonQueryAsync(
                    "UPDATE NGUOIDUNG SET MatKhau = @MatKhauMoi WHERE MaND = @MaND AND MatKhau = @MatKhauCu",
                    new Dictionary<string, object>()
                    {
                        ["MaND"] = DangNhap.thongTinHienTai.MaND,
                        ["MatKhauCu"] = tMatKhauCu.Text.Trim(),
                        ["MatKhauMoi"] = tMatKhau.Text.Trim()
                    }
                );
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Đổi mật khẩu thành công");
                    this.Close();
                }
                else SetError(tMatKhauCu, "Mật khẩu cũ nhập sai.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình đổi mật khẩu. Quý khách thử lại lần sau.\n" + exc.Message);
            }
            finally
            {
                SetInputsEnabled(true);
                tMatKhauCu.Text = matKhauCu;
                tMatKhau.Text = matKhau;
                SqlUtils.Conn.Close();
            }
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tMatKhauCu, tMatKhau, tXacNhanMatKhau })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) return valid;
            if ((error = Validator.MatKhau(tMatKhau.Text.Trim())) != null)
            {
                SetError(tMatKhau, error);
                valid = false;
            }
            if (!valid) return valid;
            if (tMatKhau.Text != tXacNhanMatKhau.Text)
            {
                SetError(tXacNhanMatKhau, "Vui lòng ghi lại đúng mật khẩu đã nhập.");
                valid = false;
            }
            if (!valid) return valid;
            matKhauCu = tMatKhauCu.Text.Trim();
            matKhau = tMatKhau.Text.Trim();
            tMatKhauCu.Text = PasswordEncoder.Encode(DangNhap.thongTinHienTai.MaND, tMatKhauCu.Text.Trim());
            tMatKhau.Text = PasswordEncoder.Encode(DangNhap.thongTinHienTai.MaND, tMatKhau.Text.Trim());
            return valid;
        }

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
            tMatKhau.PasswordChar = tXacNhanMatKhau.PasswordChar = tMatKhauCu.PasswordChar = bHienMatKhau.Checked ? '\0' : '●';
            bHienMatKhau.Image = bHienMatKhau.Checked ? Resources.ic_visibility_24px : Resources.ic_visibility_off_24px;
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
                tMatKhauCu, tMatKhau, tXacNhanMatKhau
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tableLayoutPanel2,
                btnDoiMatKhau
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
