namespace QLpizza.QuanLy
{
    partial class CongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongViec));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tMaCV = new System.Windows.Forms.TextBox();
            this.tTenCV = new System.Windows.Forms.TextBox();
            this.tMoTa = new System.Windows.Forms.TextBox();
            this.nMucLuong = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.fieldsBox1 = new QLpizza.CustomComponents.FieldsBoxWindow(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnThemCongViec = new System.Windows.Forms.Button();
            this.btnLuuCongViec = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstCongViec = new System.Windows.Forms.ListBox();
            this.thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tTimKiemCongViec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMucLuong)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.fieldsBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
            // 
            // tMaCV
            // 
            this.tMaCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMaCV.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMaCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMaCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMaCV.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMaCV, 8);
            this.tMaCV.Location = new System.Drawing.Point(49, 24);
            this.tMaCV.Margin = new System.Windows.Forms.Padding(16, 0, 40, 0);
            this.tMaCV.Name = "tMaCV";
            this.tMaCV.Size = new System.Drawing.Size(106, 21);
            this.tMaCV.TabIndex = 0;
            this.tMaCV.Tag = "MaCongViec,Id";
            // 
            // tTenCV
            // 
            this.tTenCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tTenCV.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tTenCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tTenCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tTenCV.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tTenCV, 8);
            this.tTenCV.Location = new System.Drawing.Point(49, 24);
            this.tTenCV.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tTenCV.Name = "tTenCV";
            this.tTenCV.Size = new System.Drawing.Size(150, 21);
            this.tTenCV.TabIndex = 0;
            this.tTenCV.Tag = "TenCongViec";
            // 
            // tMoTa
            // 
            this.tMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tMoTa.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMoTa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMoTa.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMoTa, 8);
            this.tMoTa.Location = new System.Drawing.Point(49, 23);
            this.tMoTa.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tMoTa.Multiline = true;
            this.tMoTa.Name = "tMoTa";
            this.tMoTa.Size = new System.Drawing.Size(398, 71);
            this.tMoTa.TabIndex = 0;
            this.tMoTa.Tag = "MoTa";
            // 
            // nMucLuong
            // 
            this.nMucLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nMucLuong.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.nMucLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nMucLuong.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.nMucLuong, 8);
            this.nMucLuong.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMucLuong.Location = new System.Drawing.Point(49, 23);
            this.nMucLuong.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.nMucLuong.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nMucLuong.Name = "nMucLuong";
            this.nMucLuong.Size = new System.Drawing.Size(378, 24);
            this.nMucLuong.TabIndex = 0;
            this.nMucLuong.Tag = "MucLuong";
            this.nMucLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nMucLuong.ThousandsSeparator = true;
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
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
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
            // fieldsBox1
            // 
            this.fieldsBox1.Controls.Add(this.label3);
            this.fieldsBox1.Controls.Add(this.tableLayoutPanel1);
            this.fieldsBox1.Controls.Add(this.btnLuuCongViec);
            this.fieldsBox1.Controls.Add(this.btnThemCongViec);
            this.fieldsBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsBox1.ListBox = this.lstCongViec;
            this.fieldsBox1.Location = new System.Drawing.Point(200, 0);
            this.fieldsBox1.Margin = new System.Windows.Forms.Padding(0);
            this.fieldsBox1.Name = "fieldsBox1";
            this.fieldsBox1.NewButton = this.btnThemCongViec;
            this.fieldsBox1.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.fieldsBox1.Size = new System.Drawing.Size(584, 440);
            this.fieldsBox1.StatusLabel = this.lStatus;
            this.fieldsBox1.TabIndex = 1;
            this.fieldsBox1.TableName = "CONGVIEC";
            this.fieldsBox1.UpdateButton = this.btnLuuCongViec;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(166, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản lý công việc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 292);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShuffle);
            this.groupBox1.Controls.Add(this.tMaCV);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(240, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã công việc";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShuffle.BackColor = global::QLpizza.Properties.Settings.Default.AccentBackColor;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = global::QLpizza.Properties.Resources.ic_shuffle_white_24px;
            this.btnShuffle.Location = new System.Drawing.Point(195, 17);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(36, 36);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::QLpizza.Properties.Resources.ic_id_card_24px;
            this.pictureBox3.Location = new System.Drawing.Point(9, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tTenCV);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(264, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox2.Size = new System.Drawing.Size(240, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên công việc";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = global::QLpizza.Properties.Resources.ic_work_24px;
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
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tMoTa);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox3.Location = new System.Drawing.Point(16, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox3.Size = new System.Drawing.Size(488, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mô tả";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QLpizza.Properties.Resources.ic_description_24px;
            this.pictureBox5.Location = new System.Drawing.Point(9, 23);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nMucLuong);
            this.groupBox4.Controls.Add(this.pictureBox8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox4.Location = new System.Drawing.Point(16, 87);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox4.Size = new System.Drawing.Size(488, 63);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mức lương";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceVariantColor;
            this.label2.Location = new System.Drawing.Point(459, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "₫";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox8.Image = global::QLpizza.Properties.Resources.ic_payments_24px;
            this.pictureBox8.Location = new System.Drawing.Point(9, 23);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // btnThemCongViec
            // 
            this.btnThemCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCongViec.AutoSize = true;
            this.btnThemCongViec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemCongViec.BackColor = global::QLpizza.Properties.Settings.Default.AccentBackColor;
            this.btnThemCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCongViec.FlatAppearance.BorderSize = 0;
            this.btnThemCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCongViec.Image = global::QLpizza.Properties.Resources.ic_add_white_24px;
            this.btnThemCongViec.Location = new System.Drawing.Point(512, 384);
            this.btnThemCongViec.Margin = new System.Windows.Forms.Padding(0);
            this.btnThemCongViec.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnThemCongViec.Name = "btnThemCongViec";
            this.btnThemCongViec.Size = new System.Drawing.Size(40, 40);
            this.btnThemCongViec.TabIndex = 3;
            this.btnThemCongViec.UseVisualStyleBackColor = false;
            // 
            // btnLuuCongViec
            // 
            this.btnLuuCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuCongViec.AutoSize = true;
            this.btnLuuCongViec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuuCongViec.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnLuuCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCongViec.FlatAppearance.BorderSize = 0;
            this.btnLuuCongViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnLuuCongViec.ImageKey = "ic_save_24px.png";
            this.btnLuuCongViec.ImageList = this.imageList1;
            this.btnLuuCongViec.Location = new System.Drawing.Point(32, 388);
            this.btnLuuCongViec.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuuCongViec.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnLuuCongViec.Name = "btnLuuCongViec";
            this.btnLuuCongViec.Padding = new System.Windows.Forms.Padding(4);
            this.btnLuuCongViec.Size = new System.Drawing.Size(74, 36);
            this.btnLuuCongViec.TabIndex = 2;
            this.btnLuuCongViec.Text = "LƯU";
            this.btnLuuCongViec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCongViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuCongViec.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_save_24px.png");
            // 
            // lstCongViec
            // 
            this.lstCongViec.BackColor = System.Drawing.Color.White;
            this.lstCongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCongViec.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.lstCongViec.FormattingEnabled = true;
            this.lstCongViec.ItemHeight = 20;
            this.lstCongViec.Location = new System.Drawing.Point(0, 26);
            this.lstCongViec.Margin = new System.Windows.Forms.Padding(0);
            this.lstCongViec.Name = "lstCongViec";
            this.lstCongViec.Size = new System.Drawing.Size(200, 414);
            this.lstCongViec.TabIndex = 1;
            this.lstCongViec.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.danhSach_Format);
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(30, 30);
            this.thoat.TabIndex = 2;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstCongViec);
            this.panel1.Controls.Add(this.tTimKiemCongViec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 440);
            this.panel1.TabIndex = 0;
            // 
            // tTimKiemCongViec
            // 
            this.tTimKiemCongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTimKiemCongViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.tTimKiemCongViec.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.tTimKiemCongViec.Location = new System.Drawing.Point(0, 0);
            this.tTimKiemCongViec.Margin = new System.Windows.Forms.Padding(0);
            this.tTimKiemCongViec.Name = "tTimKiemCongViec";
            this.tTimKiemCongViec.Size = new System.Drawing.Size(200, 26);
            this.tTimKiemCongViec.TabIndex = 0;
            // 
            // CongViec
            // 
            this.AcceptButton = this.btnLuuCongViec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.fieldsBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "CongViec";
            this.Text = "Pizza HIT [Quản lý công việc]";
            this.Load += new System.EventHandler(this.CongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMucLuong)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.fieldsBox1.ResumeLayout(false);
            this.fieldsBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLpizza.CustomComponents.FieldsBoxWindow fieldsBox1;
        private System.Windows.Forms.ListBox lstCongViec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.Button btnLuuCongViec;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tTimKiemCongViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tTenCV;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tMaCV;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tMoTa;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nMucLuong;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}