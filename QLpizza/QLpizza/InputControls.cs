using QLpizza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLpizza
{
    public partial class InputControls : Form
    {
        public InputControls()
        {
            InitializeComponent();
        }

        #region InputControls

        private void nutTaiHinh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string fileName = Path.GetFileName(openFileDialog1.FileName);
            textBox2.Text = fileName;
        }

        private void nutHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = checkBox1.Checked ? '\0' : '●';
            checkBox5.Image = checkBox5.Checked ? Resources.ic_visibility_24px : Resources.ic_visibility_off_24px;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_check_box_24px :
                Resources.ic_check_box_outline_blank_24px;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkBox = (RadioButton)sender;
            checkBox.Image = checkBox.Checked ?
                Resources.ic_radio_button_checked_24px :
                Resources.ic_radio_button_unchecked_24px;
        }

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
            if (!string.IsNullOrEmpty(value))
                control.Parent.ForeColor = Settings.Default.InputErrorForeColor;
            errorProvider1.SetError(control, value);
        }

        #endregion

        private void panel3_Validated(object sender, EventArgs e)
        {
            SetError((Control)sender, "Test");
        }

    }
}
