namespace QLpizza.BanHang
{
    partial class XacNhanThanhToan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkViDienTu = new System.Windows.Forms.RadioButton();
            this.chkTheTinDung = new System.Windows.Forms.RadioButton();
            this.chkTienMat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgwGioHang = new System.ComponentModel.BackgroundWorker();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cMaBan = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTiep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picGioHangLoading = new System.Windows.Forms.PictureBox();
            this.flpGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tGhiChu = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGioHangLoading)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkViDienTu);
            this.groupBox2.Controls.Add(this.chkTheTinDung);
            this.groupBox2.Controls.Add(this.chkTienMat);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(606, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phương thức thanh toán";
            // 
            // chkViDienTu
            // 
            this.chkViDienTu.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkViDienTu.AutoSize = true;
            this.chkViDienTu.FlatAppearance.BorderSize = 0;
            this.chkViDienTu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.chkViDienTu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.chkViDienTu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.chkViDienTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkViDienTu.ForeColor = System.Drawing.Color.Green;
            this.chkViDienTu.Image = global::QLpizza.Properties.Resources.ic_radio_button_unchecked_24px;
            this.chkViDienTu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkViDienTu.Location = new System.Drawing.Point(5, 51);
            this.chkViDienTu.Margin = new System.Windows.Forms.Padding(0);
            this.chkViDienTu.MinimumSize = new System.Drawing.Size(0, 32);
            this.chkViDienTu.Name = "chkViDienTu";
            this.chkViDienTu.Size = new System.Drawing.Size(91, 32);
            this.chkViDienTu.TabIndex = 1;
            this.chkViDienTu.Text = "Ví điện tử";
            this.chkViDienTu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkViDienTu.UseVisualStyleBackColor = false;
            this.chkViDienTu.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // chkTheTinDung
            // 
            this.chkTheTinDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTheTinDung.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTheTinDung.AutoSize = true;
            this.chkTheTinDung.FlatAppearance.BorderSize = 0;
            this.chkTheTinDung.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.chkTheTinDung.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.chkTheTinDung.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.chkTheTinDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTheTinDung.ForeColor = System.Drawing.Color.Green;
            this.chkTheTinDung.Image = global::QLpizza.Properties.Resources.ic_radio_button_unchecked_24px;
            this.chkTheTinDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTheTinDung.Location = new System.Drawing.Point(303, 19);
            this.chkTheTinDung.Margin = new System.Windows.Forms.Padding(0);
            this.chkTheTinDung.MinimumSize = new System.Drawing.Size(0, 32);
            this.chkTheTinDung.Name = "chkTheTinDung";
            this.chkTheTinDung.Size = new System.Drawing.Size(109, 32);
            this.chkTheTinDung.TabIndex = 1;
            this.chkTheTinDung.Text = "Thẻ tín dụng";
            this.chkTheTinDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkTheTinDung.UseVisualStyleBackColor = false;
            this.chkTheTinDung.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // chkTienMat
            // 
            this.chkTienMat.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTienMat.AutoSize = true;
            this.chkTienMat.Checked = true;
            this.chkTienMat.FlatAppearance.BorderSize = 0;
            this.chkTienMat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.chkTienMat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.chkTienMat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.chkTienMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTienMat.ForeColor = System.Drawing.Color.Green;
            this.chkTienMat.Image = global::QLpizza.Properties.Resources.ic_radio_button_checked_24px;
            this.chkTienMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTienMat.Location = new System.Drawing.Point(5, 19);
            this.chkTienMat.Margin = new System.Windows.Forms.Padding(0);
            this.chkTienMat.MinimumSize = new System.Drawing.Size(0, 32);
            this.chkTienMat.Name = "chkTienMat";
            this.chkTienMat.Size = new System.Drawing.Size(89, 32);
            this.chkTienMat.TabIndex = 0;
            this.chkTienMat.TabStop = true;
            this.chkTienMat.Text = "Tiền mặt";
            this.chkTienMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkTienMat.UseVisualStyleBackColor = false;
            this.chkTienMat.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thành tiền";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(406, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "300,000 đ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bgwGioHang
            // 
            this.bgwGioHang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGioHang_DoWork);
            this.bgwGioHang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGioHang_RunWorkerCompleted);
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(30, 30);
            this.thoat.TabIndex = 6;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cMaBan);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox4.Size = new System.Drawing.Size(606, 63);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bàn";
            // 
            // cMaBan
            // 
            this.cMaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cMaBan.DisplayMember = "TenBan";
            this.cMaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cMaBan.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.cMaBan.IntegralHeight = false;
            this.cMaBan.Location = new System.Drawing.Point(49, 20);
            this.cMaBan.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.cMaBan.Name = "cMaBan";
            this.cMaBan.Size = new System.Drawing.Size(516, 30);
            this.cMaBan.TabIndex = 0;
            this.cMaBan.ValueMember = "MaBan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::QLpizza.Properties.Resources.ic_table_restaurant_24px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTiep);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(606, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Các món đã đặt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTiep
            // 
            this.btnTiep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTiep.AutoSize = true;
            this.btnTiep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTiep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiep.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(76)))));
            this.btnTiep.Location = new System.Drawing.Point(271, 427);
            this.btnTiep.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnTiep.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Padding = new System.Windows.Forms.Padding(3);
            this.btnTiep.Size = new System.Drawing.Size(64, 36);
            this.btnTiep.TabIndex = 3;
            this.btnTiep.Text = "TIẾP";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(406, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "300,000 đ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picGioHangLoading);
            this.groupBox1.Controls.Add(this.flpGioHang);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các món đã đặt";
            // 
            // picGioHangLoading
            // 
            this.picGioHangLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGioHangLoading.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.picGioHangLoading.Image = global::QLpizza.Properties.Resources.material_spinner2;
            this.picGioHangLoading.Location = new System.Drawing.Point(271, 158);
            this.picGioHangLoading.Margin = new System.Windows.Forms.Padding(0);
            this.picGioHangLoading.Name = "picGioHangLoading";
            this.picGioHangLoading.Size = new System.Drawing.Size(64, 64);
            this.picGioHangLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGioHangLoading.TabIndex = 1;
            this.picGioHangLoading.TabStop = false;
            this.picGioHangLoading.Visible = false;
            // 
            // flpGioHang
            // 
            this.flpGioHang.AutoScroll = true;
            this.flpGioHang.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.flpGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGioHang.Location = new System.Drawing.Point(3, 17);
            this.flpGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.flpGioHang.Name = "flpGioHang";
            this.flpGioHang.Size = new System.Drawing.Size(600, 361);
            this.flpGioHang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vui lòng kiểm tra lại các món\r\nđã đặt trước khi tiếp tục.";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thành tiền";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThanhToan);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(606, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Điền thông tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(76)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnThanhToan.Location = new System.Drawing.Point(242, 427);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnThanhToan.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Size = new System.Drawing.Size(122, 36);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.BackColor = global::QLpizza.Properties.Settings.Default.InputBackColor;
            this.groupBox10.Controls.Add(this.tGhiChu);
            this.groupBox10.Controls.Add(this.pictureBox6);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox10.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox10.Location = new System.Drawing.Point(0, 167);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox10.Size = new System.Drawing.Size(606, 158);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ghi chú";
            // 
            // tGhiChu
            // 
            this.tGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tGhiChu.BackColor = global::QLpizza.Properties.Settings.Default.InputBackColor;
            this.tGhiChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tGhiChu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.tGhiChu.Location = new System.Drawing.Point(49, 23);
            this.tGhiChu.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tGhiChu.Multiline = true;
            this.tGhiChu.Name = "tGhiChu";
            this.tGhiChu.Size = new System.Drawing.Size(516, 119);
            this.tGhiChu.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QLpizza.Properties.Resources.ic_description_24px;
            this.pictureBox6.Location = new System.Drawing.Point(9, 23);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
            // 
            // XacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(614, 512);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.MinimumSize = new System.Drawing.Size(360, 460);
            this.Name = "XacNhanThanhToan";
            this.Text = "Pizza HIT [Xác nhận thanh toán]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XacNhanThanhToan_FormClosing);
            this.Load += new System.EventHandler(this.XacNhanThanhToan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGioHangLoading)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bgwGioHang;
        private System.Windows.Forms.RadioButton chkTheTinDung;
        private System.Windows.Forms.RadioButton chkTienMat;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cMaBan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picGioHangLoading;
        private System.Windows.Forms.FlowLayoutPanel flpGioHang;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox tGhiChu;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton chkViDienTu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}