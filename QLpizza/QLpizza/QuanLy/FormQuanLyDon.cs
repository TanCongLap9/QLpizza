using QLpizza.CustomComponents;
using QLpizza.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.QuanLy
{
    // Form quản lý bảng chính chứa những hàm chung
    public class FormQuanLyDon : Form
    {
        protected FieldsBoxWindow FieldsBox { get; set; }
        protected ErrorProvider ErrorProvider { get; set; }
        protected TextBox PasswordField { get; set; }
        protected Control[] Fields { get; set; }
        protected Control IdField { get; set; }
        protected CheckBox[] CheckBoxes { get; set; }
        protected RadioButton[] RadioButtons { get; set; }
        protected CheckBox ShowPasswordButton { get; set; }
        protected Button ShuffleButton { get; set; }
        protected Button CloseButton { get; set; }
        protected Control Search { get; set; }
        private string password = "";

        public FormQuanLyDon()
        {
            Load += FormQuanLyDon_Load;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected virtual async Task LoadData()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {

        }

        protected virtual async void FormQuanLyDon_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            FormClosing += FormQuanLyDon_FormClosing;
            FormClosed += FormQuanLyDon_FormClosed;
            if (ShuffleButton != null)
                ShuffleButton.Click += ShuffleButton_Click;
            if (Fields != null)
                foreach (Control ctl in Fields)
                {
                    ctl.Enter += InputControl_Enter;
                    ctl.Leave += InputControl_Leave;
                }
            if (CloseButton != null)
                CloseButton.Click += CloseButton_Click;
            if (CheckBoxes != null)
                foreach (CheckBox chk in CheckBoxes)
                    chk.CheckedChanged += CheckBox_CheckedChanged;
            if (RadioButtons != null)
                foreach (RadioButton rad in RadioButtons)
                    rad.CheckedChanged += RadioButton_CheckedChanged;
            if (ShowPasswordButton != null)
                ShowPasswordButton.Click += ShowPasswordButton_CheckedChanged;
            FieldsBox.Updating += FieldsBox_Updating;
            FieldsBox.Updated += FieldsBox_Updated;
            FieldsBox.FieldsFilled += FieldsBox_FieldsFilled;
            FieldsBox.Cleared += FieldsBox_Cleared;
            if (Search != null)
                Search.TextChanged += Search_TextChanged;
            await RunLoadData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text) || FieldsBox.ListBox == null) return;
            ListBox listBox = FieldsBox.ListBox;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (SearchUtils.Contains(Search.Text, listBox.GetItemText(listBox.Items[i])))
                {
                    FieldsBox.SelectedIndex = i;
                    return;
                }
            }
            FieldsBox.SelectedIndex = -1;
        }

        private async Task RunLoadData()
        {
            while (true)
                try
                {
                    await LoadData();
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
        }

        protected void ShowPassword()
        {
            if (PasswordField != null)
                PasswordField.Text = string.IsNullOrEmpty(PasswordField.Text.Trim())
                    ? password // Mật khẩu cũ
                    : PasswordEncoder.Encode(IdField.Text.Trim(), PasswordField.Text.Trim()); // Mật khẩu mới
        }

        protected void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    FieldsBox.UpdateButton?.PerformClick();
                    break;
                case Keys.Control | Keys.N:
                    FieldsBox.NewButton?.PerformClick();
                    break;
                case Keys.Control | Keys.D:
                case Keys.Delete:
                    if (FieldsBox.ListBox != null && FieldsBox.ListBox.Focused)
                        FieldsBox.DeleteButton?.PerformClick();
                    break;
                case Keys.Control | Keys.W:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected virtual void FormQuanLyDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormChinh.CloseSilently)
                if (!FieldsBox.ConfirmUnsavedChanges())
                    e.Cancel = true;
        }

        private void FormQuanLyDon_FormClosed(object sender, EventArgs e)
        {
            SqlUtils.Conn.Close();
        }

        protected virtual async void ShuffleButton_Click(object sender, EventArgs e)
        {
            IdField.Text = await MaGenerator.Ma(FieldsBoxWindow.GetFieldName(IdField));
        }

        #region FieldsBox

        protected virtual void FieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            if (PasswordField != null)
            {
                password = PasswordField.Text;
                PasswordField.Text = "";
            }
            if (ShuffleButton != null)
                ShuffleButton.Enabled = false;
            ClearAllErrors();
        }

        protected virtual void FieldsBox_Updating(object sender, CancelEventArgs e)
        {
            ClearAllErrors();
        }

        protected virtual void FieldsBox_Updated(object sender, EventArgs e)
        {
            if (PasswordField != null)
            {
                password = PasswordField.Text;
                PasswordField.Text = "";
            }
            if (FieldsBox.RowsAffected == 0) return;
            if (ShuffleButton != null)
                ShuffleButton.Enabled = false;
        }

        protected virtual void FieldsBox_Cleared(object sender, EventArgs e)
        {
            if (ShuffleButton != null)
                ShuffleButton.Enabled = true;
            if (PasswordField != null)
                password = "";
            ClearAllErrors();
        }

        #endregion

        #region InputControls

        protected void InputControl_Enter(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.AccentBackColor;
            SetError((Control)sender, string.Empty);
        }

        protected void InputControl_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.OutlineColor;
            SetError((Control)sender, string.Empty);
        }

        protected void SetError(Control control, string value)
        {
            control.Parent.ForeColor =
                string.IsNullOrEmpty(value) ?
                    Settings.Default.OutlineColor :
                    Settings.Default.InputErrorForeColor;
            ErrorProvider.SetError(control, value);
        }

        protected void ClearAllErrors()
        {
            if (Fields != null)
                foreach (Control control in Fields)
                    SetError(control, null);
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_check_box_24px :
                Resources.ic_check_box_outline_blank_24px;
        }

        protected void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkBox = (RadioButton)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_radio_button_checked_24px :
                Resources.ic_radio_button_unchecked_24px;
        }

        protected void ShowPasswordButton_CheckedChanged(object sender, EventArgs e)
        {
            PasswordField.PasswordChar = ShowPasswordButton.Checked ? '\0' : '●';
            ShowPasswordButton.Image = ShowPasswordButton.Checked ? Resources.ic_visibility_24px : Resources.ic_visibility_off_24px;
        }

        #endregion
    }
}
