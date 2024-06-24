
namespace QLpizza
{
    partial class QuenMatKhau
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
            this.tTenDangNhap = new System.Windows.Forms.TextBox();
            this.tMaKhoiPhuc = new System.Windows.Forms.MaskedTextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGuiEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(153, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khôi phục tài khoản";
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
            // tTenDangNhap
            // 
            this.tTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tTenDangNhap.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tTenDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tTenDangNhap.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tTenDangNhap, 8);
            this.tTenDangNhap.Location = new System.Drawing.Point(49, 24);
            this.tTenDangNhap.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tTenDangNhap.Name = "tTenDangNhap";
            this.tTenDangNhap.Size = new System.Drawing.Size(354, 21);
            this.tTenDangNhap.TabIndex = 0;
            this.tTenDangNhap.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tTenDangNhap.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // tMaKhoiPhuc
            // 
            this.tMaKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMaKhoiPhuc.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMaKhoiPhuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMaKhoiPhuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMaKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMaKhoiPhuc.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMaKhoiPhuc, 8);
            this.tMaKhoiPhuc.Location = new System.Drawing.Point(49, 24);
            this.tMaKhoiPhuc.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tMaKhoiPhuc.Mask = "000000";
            this.tMaKhoiPhuc.Name = "tMaKhoiPhuc";
            this.tMaKhoiPhuc.Size = new System.Drawing.Size(354, 21);
            this.tMaKhoiPhuc.TabIndex = 0;
            this.tMaKhoiPhuc.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tMaKhoiPhuc.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // tEmail
            // 
            this.tEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tEmail.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tEmail.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tEmail, 8);
            this.tEmail.Location = new System.Drawing.Point(49, 24);
            this.tEmail.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(354, 21);
            this.tEmail.TabIndex = 0;
            this.tEmail.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tEmail.Leave += new System.EventHandler(this.InputControl_Leave);
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
            this.thoat.Text = "×";
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
            this.btnKhoiPhuc.Location = new System.Drawing.Point(32, 408);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Padding = new System.Windows.Forms.Padding(4);
            this.btnKhoiPhuc.Size = new System.Drawing.Size(520, 38);
            this.btnKhoiPhuc.TabIndex = 3;
            this.btnKhoiPhuc.Text = "KHÔI PHỤC";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.ColumnCount = 2;
            this.panel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel10.Controls.Add(this.panel1, 0, 0);
            this.panel10.Controls.Add(this.groupBox1, 0, 2);
            this.panel10.Controls.Add(this.groupBox2, 0, 1);
            this.panel10.Controls.Add(this.btnGuiEmail, 1, 1);
            this.panel10.Location = new System.Drawing.Point(32, 116);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(16);
            this.panel10.RowCount = 3;
            this.panel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel10.Size = new System.Drawing.Size(520, 245);
            this.panel10.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tTenDangNhap);
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
            this.panel1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::QLpizza.Properties.Resources.ic_person_24px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tMaKhoiPhuc);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(16, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã khôi phục";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::QLpizza.Properties.Resources.ic_dialpad_24px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tEmail);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(16, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox2.Size = new System.Drawing.Size(444, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::QLpizza.Properties.Resources.ic_alternate_email_24px;
            this.pictureBox3.Location = new System.Drawing.Point(9, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnGuiEmail
            // 
            this.btnGuiEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuiEmail.AutoSize = true;
            this.btnGuiEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuiEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiEmail.FlatAppearance.BorderSize = 0;
            this.btnGuiEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiEmail.Image = global::QLpizza.Properties.Resources.ic_send_24px;
            this.btnGuiEmail.Location = new System.Drawing.Point(468, 104);
            this.btnGuiEmail.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnGuiEmail.MinimumSize = new System.Drawing.Size(36, 36);
            this.btnGuiEmail.Name = "btnGuiEmail";
            this.btnGuiEmail.Size = new System.Drawing.Size(36, 36);
            this.btnGuiEmail.TabIndex = 2;
            this.btnGuiEmail.UseVisualStyleBackColor = false;
            this.btnGuiEmail.Click += new System.EventHandler(this.btnGuiEmail_Click);
            // 
            // QuenMatKhau
            // 
            this.AcceptButton = this.btnKhoiPhuc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Name = "QuenMatKhau";
            this.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.Text = "Pizza HIT [Quên mật khẩu]";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.TableLayoutPanel panel10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.TextBox tTenDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tMaKhoiPhuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuiEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}