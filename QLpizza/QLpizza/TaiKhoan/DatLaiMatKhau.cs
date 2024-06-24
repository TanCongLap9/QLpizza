using QLpizza.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLpizza
{
    public partial class DatLaiMatKhau : Form
    {
        private NguoiDungModel model;

        public DatLaiMatKhau(NguoiDungModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private async void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            SetInputsEnabled(false);
            try
            {
                int rowsAffected = await SqlUtils.ExecuteNonQueryAsync(
                    "UPDATE NGUOIDUNG SET MatKhau = @MatKhau WHERE MaND = @MaND",
                    new Dictionary<string, object>
                    {
                        ["MatKhau"] = tMatKhau.Text,
                        ["MaND"] = model.MaND
                    });
                if (rowsAffected != 0)
                {
                    MessageBox.Show("Quý khách đã khôi phục tài khoản thành công.\nHãy đăng nhập với mật khẩu mới để sử dụng tài khoản.", "Khôi phục thành công");
                    this.Close();
                }
                else throw new Exception("User not found");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình khôi phục. Hãy thử lại lần sau.\n" + exc.Message, "Khôi phục thất bại");
            }
            finally
            {
                SetInputsEnabled(true);
                tMatKhau.Text = tXacNhanMatKhau.Text;
                SqlUtils.Conn.Close();
            }
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tMatKhau, tXacNhanMatKhau })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) return valid;
            if ((error = Validator.MatKhau(tMatKhau.Text)) != null)
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
            tMatKhau.Text = PasswordEncoder.Encode(model.MaND, tMatKhau.Text);
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
            tMatKhau.PasswordChar = tXacNhanMatKhau.PasswordChar = bHienMatKhau.Checked ? '\0' : '●';
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
                tMatKhau, tXacNhanMatKhau
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tableLayoutPanel2,
                btnKhoiPhuc
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
