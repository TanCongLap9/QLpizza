
namespace QLpizza
{
    partial class DatLaiMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.tMatKhau = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bHienMatKhau = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt lại mật khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(182, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điền các thông tin sau để\r\ntiến hành khôi phục tài khoản.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
            // 
            // tXacNhanMatKhau
            // 
            this.tXacNhanMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tXacNhanMatKhau.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tXacNhanMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tXacNhanMatKhau.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tXacNhanMatKhau, 8);
            this.tXacNhanMatKhau.Location = new System.Drawing.Point(49, 24);
            this.tXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tXacNhanMatKhau.Name = "tXacNhanMatKhau";
            this.tXacNhanMatKhau.PasswordChar = '●';
            this.tXacNhanMatKhau.Size = new System.Drawing.Size(354, 21);
            this.tXacNhanMatKhau.TabIndex = 0;
            this.tXacNhanMatKhau.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tXacNhanMatKhau.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // tMatKhau
            // 
            this.tMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMatKhau.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMatKhau.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMatKhau, 8);
            this.tMatKhau.Location = new System.Drawing.Point(49, 24);
            this.tMatKhau.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tMatKhau.Name = "tMatKhau";
            this.tMatKhau.PasswordChar = '●';
            this.tMatKhau.Size = new System.Drawing.Size(354, 21);
            this.tMatKhau.TabIndex = 0;
            this.tMatKhau.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tMatKhau.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(30, 30);
            this.thoat.TabIndex = 4;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.FlatAppearance.BorderSize = 0;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(32, 358);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Padding = new System.Windows.Forms.Padding(4);
            this.btnKhoiPhuc.Size = new System.Drawing.Size(520, 38);
            this.btnKhoiPhuc.TabIndex = 3;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.bHienMatKhau, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 116);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 174);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // bHienMatKhau
            // 
            this.bHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bHienMatKhau.Appearance = System.Windows.Forms.Appearance.Button;
            this.bHienMatKhau.AutoSize = true;
            this.bHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHienMatKhau.FlatAppearance.BorderSize = 0;
            this.bHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHienMatKhau.Image = global::QLpizza.Properties.Resources.ic_visibility_off_24px;
            this.bHienMatKhau.Location = new System.Drawing.Point(468, 69);
            this.bHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bHienMatKhau.MinimumSize = new System.Drawing.Size(36, 36);
            this.bHienMatKhau.Name = "bHienMatKhau";
            this.tableLayoutPanel2.SetRowSpan(this.bHienMatKhau, 2);
            this.bHienMatKhau.Size = new System.Drawing.Size(36, 36);
            this.bHienMatKhau.TabIndex = 2;
            this.bHienMatKhau.UseVisualStyleBackColor = true;
            this.bHienMatKhau.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tXacNhanMatKhau);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập lại mật khẩu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::QLpizza.Properties.Resources.ic_password_24px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tMatKhau);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.panel1.Size = new System.Drawing.Size(444, 63);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = false;
            this.panel1.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::QLpizza.Properties.Resources.ic_password_24px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DatLaiMatKhau
            // 
            this.AcceptButton = this.btnKhoiPhuc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Name = "DatLaiMatKhau";
            this.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.Text = "Pizza HIT [Đặt lại mật khẩu]";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox bHienMatKhau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tXacNhanMatKhau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.TextBox tMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}