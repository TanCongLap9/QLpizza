using QLpizza.CustomComponents;
using QLpizza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza.QuanLy
{
    // Form quản lý bảng chính và bảng phụ chứa những hàm chung
    public class FormQuanLyDoi : Form
    {
        protected TabControl TabControl { get; set; }
        protected FieldsBoxWindow MasterFieldsBox { get; set; }
        protected FieldsBoxWindow DetailFieldsBox { get; set; }
        protected ErrorProvider ErrorProvider { get; set; }
        protected Button MasterShuffleButton { get; set; }
        protected Button DetailShuffleButton { get; set; }
        protected Control MasterIdField { get; set; }
        protected Tuple<Control, Control> Search { get; set; }
        protected TabPage MasterPage { get; set; }
        protected TabPage DetailPage { get; set; }
        protected Control DetailIdField { get; set; }
        protected Control DetailIdGetFromMasterField { get; set; }
        protected bool DetailSelectAll { get; set; }
        protected Control DetailTargetIdField { get; set; }
        protected Button ToMaster { get; set; }
        protected Button ToDetail { get; set; }
        protected Control[] Fields { get; set; }
        protected TextBox PasswordField { get; set; }
        protected CheckBox[] CheckBoxes { get; set; }
        protected RadioButton[] RadioButtons { get; set; }
        protected CheckBox ShowPasswordButton { get; set; }
        protected Button CloseButton { get; set; }
        protected Button OkButton { get; set; }
        private string password = "";

        public FormQuanLyDoi()
        {
            Load += FormQuanLyDoi_Load;
        }

        protected async void FormQuanLyDoi_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            FormClosing += FormQuanLyDoi_FormClosing;
            FormClosed += FormQuanLyDoi_FormClosed;
            if (MasterShuffleButton != null)
                MasterShuffleButton.Click += MasterShuffleButton_Click;
            if (DetailShuffleButton != null)
                DetailShuffleButton.Click += DetailShuffleButton_Click;
            if (Fields != null)
                foreach (Control ctl in Fields)
                {
                    ctl.Enter += InputControl_Enter;
                    ctl.Leave += InputControl_Leave;
                }
            if (ToMaster != null)
                ToMaster.Click += ToMaster_Click;
            if (ToDetail != null)
                ToDetail.Click += ToDetail_Click;
            if (CloseButton != null)
                CloseButton.Click += CloseButton_Click;
            if (OkButton != null)
                OkButton.Click += OkButton_Click;
            if (CheckBoxes != null)
                foreach (CheckBox chk in CheckBoxes)
                    chk.CheckedChanged += CheckBox_CheckedChanged;
            if (RadioButtons != null)
                foreach (RadioButton rad in RadioButtons)
                    rad.CheckedChanged += RadioButton_CheckedChanged;
            if (ShowPasswordButton != null)
                ShowPasswordButton.Click += ShowPasswordButton_CheckedChanged;
            MasterFieldsBox.Updating += MasterFieldsBox_Updating;
            MasterFieldsBox.Updated += MasterFieldsBox_Updated;
            MasterFieldsBox.FieldsFilled += MasterFieldsBox_FieldsFilled;
            MasterFieldsBox.Cleared += MasterFieldsBox_Cleared;
            DetailFieldsBox.Updating += DetailFieldsBox_Updating;
            DetailFieldsBox.Cleared += DetailFieldsBox_Cleared;
            DetailFieldsBox.FieldsFilled += DetailFieldsBox_FieldsFilled;
            DetailFieldsBox.Updated += DetailFieldsBox_Updated;
            if (TabControl != null)
            {
                TabControl.Selecting += TabControl_Selecting;
                TabControl.Deselecting += TabControl_Deselecting;
            }
            if (Search != null)
            {
                Search.Item1.TextChanged += Search_TextChanged;
                Search.Item2.TextChanged += Search_TextChanged;
            }
            await RunLoadData();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Control search = sender as Control;
            FieldsBoxWindow fieldsBox = new Dictionary<Control, FieldsBoxWindow> {
                [Search.Item1] = MasterFieldsBox,
                [Search.Item2] = DetailFieldsBox
            }[search];
            ListBox listBox = fieldsBox.ListBox;

            if (string.IsNullOrWhiteSpace(search.Text) || listBox == null) return;
            for (int i = 0; i < listBox.Items.Count; i++)
                if (SearchUtils.Contains(search.Text, listBox.GetItemText(listBox.Items[i])))
                {
                    fieldsBox.SelectedIndex = i;
                    return;
                }
            fieldsBox.SelectedIndex = -1;
        }

        private void ToDetail_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = DetailPage;
        }

        private void ToMaster_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = MasterPage;
        }

        protected void FormQuanLyDoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormChinh.CloseSilently)
                if (!MasterFieldsBox.ConfirmUnsavedChanges())
                    e.Cancel = true;
        }
        protected virtual async void MasterShuffleButton_Click(object sender, EventArgs e)
        {
            MasterIdField.Text = await MaGenerator.Ma(FieldsBoxWindow.GetFieldName(MasterIdField));
        }

        protected virtual async void DetailShuffleButton_Click(object sender, EventArgs e)
        {
            DetailTargetIdField.Text = await MaGenerator.Ma(FieldsBoxWindow.GetFieldName(DetailTargetIdField));
        }


        #region FieldsBoxes

        protected virtual void MasterFieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            if (PasswordField != null)
            {
                password = PasswordField.Text;
                PasswordField.Text = "";
            }
            if (MasterShuffleButton != null)
                MasterShuffleButton.Enabled = false;
            ClearAllErrors();
        }

        protected virtual void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            ClearAllErrors();
        }
        
        protected virtual void MasterFieldsBox_Updated(object sender, EventArgs e)
        {
            if (PasswordField != null)
            {
                password = PasswordField.Text;
                PasswordField.Text = "";
            }
            if (MasterFieldsBox.RowsAffected == 0) return;
            if (MasterShuffleButton != null)
                MasterShuffleButton.Enabled = false;
        }

        protected virtual void MasterFieldsBox_Cleared(object sender, EventArgs e)
        {
            if (MasterShuffleButton != null)
                MasterShuffleButton.Enabled = true;
            if (PasswordField != null)
                password = "";
            ClearAllErrors();
        }

        protected virtual void DetailFieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            if (DetailShuffleButton != null)
                DetailShuffleButton.Enabled = false;
            ClearAllErrors();
        }

        protected virtual void DetailFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            ClearAllErrors();
        }

        protected virtual void DetailFieldsBox_Updated(object sender, EventArgs e)
        {
            if (DetailFieldsBox.RowsAffected == 0) return;
            if (DetailShuffleButton != null)
                DetailShuffleButton.Enabled = false;
        }

        protected virtual void DetailFieldsBox_Cleared(object sender, EventArgs e)
        {
            if (DetailShuffleButton != null)
                DetailShuffleButton.Enabled = true;
            FieldsBoxWindow.SetFieldValue(DetailIdField, MasterFieldsBox.SelectedRow.Field<string>(FieldsBoxWindow.GetFieldName(MasterIdField)));
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
                    SetError(control, string.Empty);
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

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected virtual async Task LoadData()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            
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
                    : PasswordEncoder.Encode(MasterIdField.Text.Trim(), PasswordField.Text.Trim()); // Mật khẩu mới
        }

        protected void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == MasterPage)
                MasterFieldsBox.UpdateButton?.PerformClick();
            else if (TabControl.SelectedTab == DetailPage)
                DetailFieldsBox.UpdateButton?.PerformClick();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    if (TabControl.SelectedTab == MasterPage)
                        MasterFieldsBox.UpdateButton?.PerformClick();
                    else if (TabControl.SelectedTab == DetailPage)
                        DetailFieldsBox.UpdateButton?.PerformClick();
                    break;
                case Keys.Control | Keys.N:
                    if (TabControl.SelectedTab == MasterPage)
                        MasterFieldsBox.NewButton?.PerformClick();
                    else if (TabControl.SelectedTab == DetailPage)
                        DetailFieldsBox.NewButton?.PerformClick();
                    break;
                case Keys.Control | Keys.D:
                case Keys.Delete:
                    if (TabControl.SelectedTab == MasterPage && MasterFieldsBox.ListBox.Focused)
                        MasterFieldsBox.DeleteButton?.PerformClick();
                    else if (TabControl.SelectedTab == DetailPage && DetailFieldsBox.ListBox.Focused)
                        DetailFieldsBox.DeleteButton?.PerformClick();
                    break;
                case Keys.Control | Keys.W:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected virtual async void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == MasterPage)
                MasterFieldsBox.SelectedIndex = MasterFieldsBox.SelectedIndex;
            else if (e.TabPage == DetailPage)
            {
                if (MasterFieldsBox.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Cần phải chọn dữ liệu trong bảng chính để xem chi tiết.",
                        "Chọn dữ liệu trước tiên",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                    e.Cancel = true;
                    return;
                }
                DetailFieldsBox.SelectCommand =
                    $"SELECT * FROM {DetailFieldsBox.TableName}" + (
                        DetailSelectAll ? "" : DetailIdGetFromMasterField != null ?
                        $@"
                            WHERE {FieldsBoxWindow.GetFieldName(DetailIdField)} =
                            '{MasterFieldsBox.SelectedRow.Field<string>(
                                FieldsBoxWindow.GetFieldName(DetailIdGetFromMasterField)
                             )}'
                        " :
                        $@"
                            WHERE {FieldsBoxWindow.GetFieldName(DetailIdField)} =
                            '{MasterFieldsBox.SelectedRow.Field<string>(
                                FieldsBoxWindow.GetFieldName(MasterIdField)
                            )}'
                        "
                    );
                if (DetailFieldsBox.Fields.Count == 0)
                    await DetailFieldsBox.Load();
                else
                {
                    await DetailFieldsBox.UpdateTable();
                    DetailFieldsBox.SelectedIndex = DetailFieldsBox.Table.Rows.Count != 0 ? 0 : -1;
                }
            }
        }

        private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == MasterPage)
                e.Cancel = !MasterFieldsBox.ConfirmUnsavedChanges();
            else if (e.TabPage == DetailPage)
                e.Cancel = !DetailFieldsBox.ConfirmUnsavedChanges();
        }

        private void FormQuanLyDoi_FormClosed(object sender, EventArgs e)
        {
            SqlUtils.Conn.Close();
        }
    }
}
