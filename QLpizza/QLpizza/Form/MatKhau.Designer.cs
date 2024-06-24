namespace QLpizza
{
    partial class MatKhau
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
            this.thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tMatKhau = new System.Windows.Forms.TextBox();
            this.tXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.tMatKhauCu = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bHienMatKhau = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(30, 30);
            this.thoat.TabIndex = 3;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
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
            // tMatKhauCu
            // 
            this.tMatKhauCu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMatKhauCu.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMatKhauCu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMatKhauCu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMatKhauCu, 8);
            this.tMatKhauCu.Location = new System.Drawing.Point(49, 24);
            this.tMatKhauCu.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tMatKhauCu.Name = "tMatKhauCu";
            this.tMatKhauCu.PasswordChar = '●';
            this.tMatKhauCu.Size = new System.Drawing.Size(354, 21);
            this.tMatKhauCu.TabIndex = 0;
            this.tMatKhauCu.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tMatKhauCu.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMatKhau.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDoiMatKhau.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(32, 348);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoiMatKhau.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Padding = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhau.Size = new System.Drawing.Size(520, 36);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.bHienMatKhau, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 68);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 245);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bHienMatKhau
            // 
            this.bHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bHienMatKhau.Appearance = System.Windows.Forms.Appearance.Button;
            this.bHienMatKhau.AutoSize = true;
            this.bHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHienMatKhau.FlatAppearance.BorderSize = 0;
            this.bHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHienMatKhau.Image = global::QLpizza.Properties.Resources.ic_visibility_off_24px;
            this.bHienMatKhau.Location = new System.Drawing.Point(468, 104);
            this.bHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.bHienMatKhau.MaximumSize = new System.Drawing.Size(36, 36);
            this.bHienMatKhau.MinimumSize = new System.Drawing.Size(36, 36);
            this.bHienMatKhau.Name = "bHienMatKhau";
            this.bHienMatKhau.Size = new System.Drawing.Size(36, 36);
            this.bHienMatKhau.TabIndex = 3;
            this.bHienMatKhau.UseVisualStyleBackColor = true;
            this.bHienMatKhau.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tXacNhanMatKhau);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(16, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox2.Size = new System.Drawing.Size(444, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập lại mật khẩu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = global::QLpizza.Properties.Resources.ic_password_24px;
            this.pictureBox4.Location = new System.Drawing.Point(9, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tMatKhauCu);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox3.Location = new System.Drawing.Point(16, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox3.Size = new System.Drawing.Size(444, 63);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu cũ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.Image = global::QLpizza.Properties.Resources.ic_password_24px;
            this.pictureBox5.Location = new System.Drawing.Point(9, 23);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tMatKhau);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu mới";
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
            // MatKhau
            // 
            this.AcceptButton = this.btnDoiMatKhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MatKhau";
            this.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.Text = "Pizza HIT [Đổi mật khẩu]";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox bHienMatKhau;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tXacNhanMatKhau;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tMatKhauCu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}