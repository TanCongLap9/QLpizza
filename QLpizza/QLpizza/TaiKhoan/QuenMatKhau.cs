using QLpizza.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza
{
    public partial class QuenMatKhau : Form
    {
        private string maKhoiPhuc;

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private async void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            SetInputsEnabled(false);
            try
            {
                DataTable table = new DataTable();
                if (!await ValidateInfo(table)) return;
                DataRow firstRow = table.Rows[0];
                this.Hide();
                new DatLaiMatKhau(
                    new NguoiDungModel() {
                        MaND = firstRow.Field<string>("MaND")
                    }
                ).ShowDialog();
                this.Close();
            }
            finally
            {
                SetInputsEnabled(true);
                SqlUtils.Conn.Close();
            }
        }

        private async void btnGuiEmail_Click(object sender, EventArgs e)
        {
            if (!ValidateEmailInput()) return;
            SetInputsEnabled(false);
            try
            {
                if (!await ValidateInfo()) return;
                maKhoiPhuc = MaGenerator.Pin();
                HttpClient client = new HttpClient()
                {
                    BaseAddress = new Uri(Settings.Default.WebApp)
                };
                try
                {
                    await client.GetAsync($"?type=forgetPassword&to={tEmail.Text.Trim()}&id={maKhoiPhuc}");
                    MessageBox.Show($"Một tin nhắn email đã được gửi đến {tEmail.Text.Trim()}.\nVui lòng xem hộp thư để nhận mã khôi phục.", "Đã gửi email");
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
            finally
            {
                SetInputsEnabled(true);
            }
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tTenDangNhap, tEmail })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (MaskedTextBox mtx in new MaskedTextBox[] { tMaKhoiPhuc })
                if (!mtx.MaskCompleted)
                {
                    SetError(mtx, "Đây là thông tin bắt buộc. Vui lòng nhấn vào nút gửi email để lấy mã khôi phục.");
                    valid = false;
                }
            if (!valid) return valid;
            if ((error = Validator.Email(tEmail.Text.Trim())) != null)
            {
                SetError(tEmail, error);
                valid = false;
            }
            if (!valid) return valid;
            if (tMaKhoiPhuc.Text.Trim() != maKhoiPhuc)
            {
                SetError(tMaKhoiPhuc, "Mã khôi phục không đúng.");
                valid = false;
            }
            if (!valid) return valid;
            return valid;
        }

        private bool ValidateEmailInput()
        {
            ClearAllErrors();
            bool valid = true;
            string error;
            foreach (TextBoxBase txt in new TextBoxBase[] { tTenDangNhap, tEmail })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) return valid;
            if ((error = Validator.Email(tEmail.Text.Trim())) != null)
            {
                SetError(tEmail, error);
                valid = false;
            }
            if (!valid) return valid;
            return valid;
        }

        private async Task<bool> ValidateInfo(DataTable table = null)
        {
            if (table == null) table = new DataTable();
            await SqlUtils.QueryAsync(
                "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @TenDangNhap",
                new Dictionary<string, object>
                {
                    ["TenDangNhap"] = tTenDangNhap.Text
                }, table);
            if (table.Rows.Count == 0)
            {
                SetError(tTenDangNhap, "Tài khoản này không tồn tại.");
                return false;
            }
            if (table.Rows[0].Field<string>("Email") != tEmail.Text.Trim())
            {
                SetError(tEmail, "Đây không phải là email của người dùng này.");
                return false;
            }
            return true;
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
                tTenDangNhap, tEmail, tMaKhoiPhuc
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                panel10,
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
