namespace QLpizza.QuanLy
{
    partial class NguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguyenLieu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tMaNL = new System.Windows.Forms.TextBox();
            this.tTenNL = new System.Windows.Forms.TextBox();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            this.tDVT = new System.Windows.Forms.TextBox();
            this.nDonGia = new System.Windows.Forms.NumericUpDown();
            this.lstNguyenLieu = new System.Windows.Forms.ListBox();
            this.btnLuuNguyenLieu = new System.Windows.Forms.Button();
            this.fieldsBox1 = new QLpizza.CustomComponents.FieldsBoxWindow(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemNguyenLieu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tTimKiemNguyenLieu = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDonGia)).BeginInit();
            this.fieldsBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_save_24px.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            // 
            // lStatus
            // 
            this.lStatus.AutoToolTip = true;
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 0);
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
            // 
            // tMaNL
            // 
            this.tMaNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMaNL.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMaNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMaNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMaNL.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMaNL, 8);
            this.tMaNL.Location = new System.Drawing.Point(49, 24);
            this.tMaNL.Margin = new System.Windows.Forms.Padding(16, 0, 40, 0);
            this.tMaNL.Name = "tMaNL";
            this.tMaNL.Size = new System.Drawing.Size(104, 21);
            this.tMaNL.TabIndex = 0;
            this.tMaNL.Tag = "MaNL,Id";
            // 
            // tTenNL
            // 
            this.tTenNL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tTenNL.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tTenNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tTenNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTenNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tTenNL.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tTenNL, 8);
            this.tTenNL.Location = new System.Drawing.Point(49, 24);
            this.tTenNL.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tTenNL.Name = "tTenNL";
            this.tTenNL.Size = new System.Drawing.Size(202, 21);
            this.tTenNL.TabIndex = 0;
            this.tTenNL.Tag = "TenNL";
            // 
            // nSoLuong
            // 
            this.nSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nSoLuong.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.nSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nSoLuong.DecimalPlaces = 2;
            this.nSoLuong.Enabled = false;
            this.nSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nSoLuong.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.nSoLuong, 8);
            this.nSoLuong.Location = new System.Drawing.Point(9, 23);
            this.nSoLuong.Margin = new System.Windows.Forms.Padding(0, 0, 32, 0);
            this.nSoLuong.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nSoLuong.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(188, 24);
            this.nSoLuong.TabIndex = 0;
            this.nSoLuong.Tag = "SoLuong,Disabled";
            this.nSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSoLuong.ThousandsSeparator = true;
            // 
            // tDVT
            // 
            this.tDVT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tDVT.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tDVT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tDVT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tDVT.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tDVT, 8);
            this.tDVT.Location = new System.Drawing.Point(49, 24);
            this.tDVT.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tDVT.Name = "tDVT";
            this.tDVT.Size = new System.Drawing.Size(202, 21);
            this.tDVT.TabIndex = 0;
            this.tDVT.Tag = "DonViTinh";
            // 
            // nDonGia
            // 
            this.nDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nDonGia.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.nDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nDonGia.Enabled = false;
            this.nDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nDonGia.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.nDonGia, 8);
            this.nDonGia.Location = new System.Drawing.Point(49, 23);
            this.nDonGia.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.nDonGia.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nDonGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDonGia.Name = "nDonGia";
            this.nDonGia.Size = new System.Drawing.Size(128, 24);
            this.nDonGia.TabIndex = 0;
            this.nDonGia.Tag = "DonGia";
            this.nDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDonGia.ThousandsSeparator = true;
            this.nDonGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstNguyenLieu
            // 
            this.lstNguyenLieu.BackColor = System.Drawing.Color.White;
            this.lstNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNguyenLieu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.lstNguyenLieu.FormattingEnabled = true;
            this.lstNguyenLieu.ItemHeight = 20;
            this.lstNguyenLieu.Location = new System.Drawing.Point(0, 26);
            this.lstNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.lstNguyenLieu.Name = "lstNguyenLieu";
            this.lstNguyenLieu.Size = new System.Drawing.Size(200, 414);
            this.lstNguyenLieu.TabIndex = 1;
            this.lstNguyenLieu.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.danhSach_Format);
            // 
            // btnLuuNguyenLieu
            // 
            this.btnLuuNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuNguyenLieu.AutoSize = true;
            this.btnLuuNguyenLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuuNguyenLieu.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnLuuNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuNguyenLieu.FlatAppearance.BorderSize = 0;
            this.btnLuuNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLuuNguyenLieu.ImageKey = "ic_save_24px.png";
            this.btnLuuNguyenLieu.ImageList = this.imageList1;
            this.btnLuuNguyenLieu.Location = new System.Drawing.Point(32, 388);
            this.btnLuuNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuuNguyenLieu.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnLuuNguyenLieu.Name = "btnLuuNguyenLieu";
            this.btnLuuNguyenLieu.Padding = new System.Windows.Forms.Padding(4);
            this.btnLuuNguyenLieu.Size = new System.Drawing.Size(74, 36);
            this.btnLuuNguyenLieu.TabIndex = 2;
            this.btnLuuNguyenLieu.Text = "LƯU";
            this.btnLuuNguyenLieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuNguyenLieu.UseVisualStyleBackColor = false;
            // 
            // fieldsBox1
            // 
            this.fieldsBox1.Controls.Add(this.tableLayoutPanel1);
            this.fieldsBox1.Controls.Add(this.label3);
            this.fieldsBox1.Controls.Add(this.btnThemNguyenLieu);
            this.fieldsBox1.Controls.Add(this.btnLuuNguyenLieu);
            this.fieldsBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsBox1.ListBox = this.lstNguyenLieu;
            this.fieldsBox1.Location = new System.Drawing.Point(200, 0);
            this.fieldsBox1.Margin = new System.Windows.Forms.Padding(0, 0, 48, 8);
            this.fieldsBox1.Name = "fieldsBox1";
            this.fieldsBox1.NewButton = this.btnThemNguyenLieu;
            this.fieldsBox1.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.fieldsBox1.Size = new System.Drawing.Size(634, 440);
            this.fieldsBox1.StatusLabel = this.lStatus;
            this.fieldsBox1.TabIndex = 1;
            this.fieldsBox1.TableName = "NGUYENLIEU";
            this.fieldsBox1.UpdateButton = this.btnLuuNguyenLieu;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 245);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnShuffle);
            this.groupBox6.Controls.Add(this.tMaNL);
            this.groupBox6.Controls.Add(this.pictureBox15);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox6.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox6.Location = new System.Drawing.Point(16, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox6.Size = new System.Drawing.Size(238, 63);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mã nguyên liệu";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShuffle.BackColor = global::QLpizza.Properties.Settings.Default.AccentBackColor;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = global::QLpizza.Properties.Resources.ic_shuffle_white_24px;
            this.btnShuffle.Location = new System.Drawing.Point(193, 17);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(36, 36);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox15.Image = global::QLpizza.Properties.Resources.ic_id_card_24px;
            this.pictureBox15.Location = new System.Drawing.Point(9, 23);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(24, 24);
            this.pictureBox15.TabIndex = 4;
            this.pictureBox15.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tTenNL);
            this.groupBox5.Controls.Add(this.pictureBox14);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox5.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox5.Location = new System.Drawing.Point(262, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox5.Size = new System.Drawing.Size(292, 63);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tên nguyên liệu";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox14.Image = global::QLpizza.Properties.Resources.ic_grocery_24px;
            this.pictureBox14.Location = new System.Drawing.Point(9, 23);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(24, 24);
            this.pictureBox14.TabIndex = 4;
            this.pictureBox14.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.nSoLuong);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox14.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox14.Location = new System.Drawing.Point(16, 87);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox14.Size = new System.Drawing.Size(238, 63);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Số lượng tồn";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.nDonGia);
            this.groupBox11.Controls.Add(this.pictureBox24);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox11.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox11.Location = new System.Drawing.Point(16, 158);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox11.Size = new System.Drawing.Size(238, 63);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Đơn giá";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceVariantColor;
            this.label20.Location = new System.Drawing.Point(209, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 22);
            this.label20.TabIndex = 1;
            this.label20.Text = "₫";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox24.Image = global::QLpizza.Properties.Resources.ic_payments_24px;
            this.pictureBox24.Location = new System.Drawing.Point(9, 23);
            this.pictureBox24.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(24, 24);
            this.pictureBox24.TabIndex = 4;
            this.pictureBox24.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tDVT);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(262, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(292, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn vị tính";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::QLpizza.Properties.Resources.ic_category_24px;
            this.pictureBox3.Location = new System.Drawing.Point(9, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(178, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản lý nguyên liệu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNguyenLieu.AutoSize = true;
            this.btnThemNguyenLieu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemNguyenLieu.BackColor = global::QLpizza.Properties.Settings.Default.AccentBackColor;
            this.btnThemNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNguyenLieu.FlatAppearance.BorderSize = 0;
            this.btnThemNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNguyenLieu.Image = global::QLpizza.Properties.Resources.ic_add_white_24px;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(562, 384);
            this.btnThemNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemNguyenLieu.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(40, 40);
            this.btnThemNguyenLieu.TabIndex = 3;
            this.btnThemNguyenLieu.UseVisualStyleBackColor = false;
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(30, 30);
            this.thoat.TabIndex = 2;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstNguyenLieu);
            this.panel2.Controls.Add(this.tTimKiemNguyenLieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 0;
            // 
            // tTimKiemNguyenLieu
            // 
            this.tTimKiemNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTimKiemNguyenLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tTimKiemNguyenLieu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.tTimKiemNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.tTimKiemNguyenLieu.Margin = new System.Windows.Forms.Padding(0);
            this.tTimKiemNguyenLieu.Name = "tTimKiemNguyenLieu";
            this.tTimKiemNguyenLieu.Size = new System.Drawing.Size(200, 26);
            this.tTimKiemNguyenLieu.TabIndex = 0;
            // 
            // NguyenLieu
            // 
            this.AcceptButton = this.btnLuuNguyenLieu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.fieldsBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "NguyenLieu";
            this.Text = "Pizza HIT [Quản lý nguyên liệu]";
            this.Load += new System.EventHandler(this.NguyenLieu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDonGia)).EndInit();
            this.fieldsBox1.ResumeLayout(false);
            this.fieldsBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstNguyenLieu;
        private CustomComponents.FieldsBoxWindow fieldsBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLuuNguyenLieu;
        private System.Windows.Forms.Button btnThemNguyenLieu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tTimKiemNguyenLieu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tMaNL;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tTenNL;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown nSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDVT;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nDonGia;
        private System.Windows.Forms.PictureBox pictureBox24;
    }
}