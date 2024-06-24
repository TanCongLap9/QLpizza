namespace QLpizza.BanHang
{
    partial class MuaPizza
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
                gioHangAdapter.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuaPizza));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.GroupBox();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cMaLoai = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bGioHang = new System.Windows.Forms.CheckBox();
            this.btnDat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picPizzaLoading = new System.Windows.Forms.PictureBox();
            this.flpPizza = new System.Windows.Forms.FlowLayoutPanel();
            this.bgwPizza = new System.ComponentModel.BackgroundWorker();
            this.bgwGioHang = new System.ComponentModel.BackgroundWorker();
            this.pnlGioHang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picGioHangLoading = new System.Windows.Forms.PictureBox();
            this.flpGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nThanhTien = new System.Windows.Forms.NumericUpDown();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnHuyGioHang = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.thoat = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaLoading)).BeginInit();
            this.pnlGioHang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGioHangLoading)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nThanhTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.bGioHang);
            this.panel4.Controls.Add(this.btnDat);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.panel4.Size = new System.Drawing.Size(784, 540);
            this.panel4.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel13.Controls.Add(this.nSoLuong);
            this.panel13.Controls.Add(this.pictureBox9);
            this.panel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel13.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.panel13.Location = new System.Drawing.Point(217, 461);
            this.panel13.Margin = new System.Windows.Forms.Padding(0, 0, 16, 8);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.panel13.Size = new System.Drawing.Size(270, 63);
            this.panel13.TabIndex = 5;
            this.panel13.TabStop = false;
            this.panel13.Text = "Số lượng";
            // 
            // nSoLuong
            // 
            this.nSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nSoLuong.BackColor = global::QLpizza.Properties.Settings.Default.InputBackColor;
            this.nSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nSoLuong.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.nSoLuong.Location = new System.Drawing.Point(49, 23);
            this.nSoLuong.Margin = new System.Windows.Forms.Padding(16, 0, 24, 0);
            this.nSoLuong.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(188, 24);
            this.nSoLuong.TabIndex = 1;
            this.nSoLuong.Tag = "MucLuong";
            this.nSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSoLuong.ThousandsSeparator = true;
            this.nSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox9.Image = global::QLpizza.Properties.Resources.ic_content_copy_24px;
            this.pictureBox9.Location = new System.Drawing.Point(9, 23);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.TabIndex = 4;
            this.pictureBox9.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cMaLoai);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(79, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 32, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox2.Size = new System.Drawing.Size(287, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại pizza";
            // 
            // cMaLoai
            // 
            this.cMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cMaLoai.DisplayMember = "TenLoai";
            this.cMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cMaLoai.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.cMaLoai.IntegralHeight = false;
            this.cMaLoai.Location = new System.Drawing.Point(49, 20);
            this.cMaLoai.Margin = new System.Windows.Forms.Padding(16, 0, 24, 0);
            this.cMaLoai.Name = "cMaLoai";
            this.cMaLoai.Size = new System.Drawing.Size(205, 30);
            this.cMaLoai.TabIndex = 0;
            this.cMaLoai.ValueMember = "MaLoai";
            this.cMaLoai.SelectionChangeCommitted += new System.EventHandler(this.UpdatePizza);
            this.cMaLoai.Enter += new System.EventHandler(this.InputControl_Enter);
            this.cMaLoai.Leave += new System.EventHandler(this.InputControl_Leave);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tTimKiem);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(398, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 16);
            this.groupBox1.Size = new System.Drawing.Size(289, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // tTimKiem
            // 
            this.tTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tTimKiem.BackColor = global::QLpizza.Properties.Settings.Default.InputBackColor;
            this.tTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tTimKiem.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.tTimKiem.Location = new System.Drawing.Point(49, 24);
            this.tTimKiem.Margin = new System.Windows.Forms.Padding(16, 0, 24, 0);
            this.tTimKiem.Name = "tTimKiem";
            this.tTimKiem.Size = new System.Drawing.Size(207, 21);
            this.tTimKiem.TabIndex = 0;
            this.tTimKiem.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tTimKiem_KeyUp);
            this.tTimKiem.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::QLpizza.Properties.Resources.ic_search_24px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(703, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bGioHang
            // 
            this.bGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGioHang.Appearance = System.Windows.Forms.Appearance.Button;
            this.bGioHang.AutoSize = true;
            this.bGioHang.BackColor = global::QLpizza.Properties.Settings.Default.AccentBackColor;
            this.bGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGioHang.FlatAppearance.BorderSize = 0;
            this.bGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGioHang.Image = global::QLpizza.Properties.Resources.ic_shopping_cart_white_24px;
            this.bGioHang.Location = new System.Drawing.Point(739, 26);
            this.bGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.bGioHang.MinimumSize = new System.Drawing.Size(36, 36);
            this.bGioHang.Name = "bGioHang";
            this.bGioHang.Size = new System.Drawing.Size(36, 36);
            this.bGioHang.TabIndex = 3;
            this.bGioHang.UseVisualStyleBackColor = false;
            this.bGioHang.CheckedChanged += new System.EventHandler(this.bGioHang_CheckedChanged);
            // 
            // btnDat
            // 
            this.btnDat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDat.AutoSize = true;
            this.btnDat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDat.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDat.Enabled = false;
            this.btnDat.FlatAppearance.BorderSize = 0;
            this.btnDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDat.Location = new System.Drawing.Point(503, 477);
            this.btnDat.Margin = new System.Windows.Forms.Padding(0);
            this.btnDat.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnDat.Name = "btnDat";
            this.btnDat.Padding = new System.Windows.Forms.Padding(4);
            this.btnDat.Size = new System.Drawing.Size(64, 36);
            this.btnDat.TabIndex = 6;
            this.btnDat.Text = "ĐẶT";
            this.btnDat.UseVisualStyleBackColor = false;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.panel3.Controls.Add(this.picPizzaLoading);
            this.panel3.Controls.Add(this.flpPizza);
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 371);
            this.panel3.TabIndex = 4;
            // 
            // picPizzaLoading
            // 
            this.picPizzaLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPizzaLoading.Image = global::QLpizza.Properties.Resources.material_spinner2;
            this.picPizzaLoading.Location = new System.Drawing.Point(360, 153);
            this.picPizzaLoading.Margin = new System.Windows.Forms.Padding(0);
            this.picPizzaLoading.Name = "picPizzaLoading";
            this.picPizzaLoading.Size = new System.Drawing.Size(64, 64);
            this.picPizzaLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizzaLoading.TabIndex = 0;
            this.picPizzaLoading.TabStop = false;
            this.picPizzaLoading.Visible = false;
            // 
            // flpPizza
            // 
            this.flpPizza.AutoScroll = true;
            this.flpPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPizza.Location = new System.Drawing.Point(0, 0);
            this.flpPizza.Margin = new System.Windows.Forms.Padding(0);
            this.flpPizza.Name = "flpPizza";
            this.flpPizza.Size = new System.Drawing.Size(784, 371);
            this.flpPizza.TabIndex = 0;
            // 
            // bgwPizza
            // 
            this.bgwPizza.WorkerSupportsCancellation = true;
            this.bgwPizza.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwPizza_DoWork);
            this.bgwPizza.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwPizzaWorker_RunWorkerCompleted);
            // 
            // bgwGioHang
            // 
            this.bgwGioHang.WorkerSupportsCancellation = true;
            this.bgwGioHang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGioHang_DoWork);
            this.bgwGioHang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGioHang_RunWorkerCompleted);
            // 
            // pnlGioHang
            // 
            this.pnlGioHang.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.pnlGioHang.Controls.Add(this.panel1);
            this.pnlGioHang.Controls.Add(this.panel2);
            this.pnlGioHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGioHang.Location = new System.Drawing.Point(0, 0);
            this.pnlGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGioHang.Name = "pnlGioHang";
            this.pnlGioHang.Padding = new System.Windows.Forms.Padding(8);
            this.pnlGioHang.Size = new System.Drawing.Size(336, 540);
            this.pnlGioHang.TabIndex = 1;
            this.pnlGioHang.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picGioHangLoading);
            this.panel1.Controls.Add(this.flpGioHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 424);
            this.panel1.TabIndex = 0;
            // 
            // picGioHangLoading
            // 
            this.picGioHangLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picGioHangLoading.Image = global::QLpizza.Properties.Resources.material_spinner2;
            this.picGioHangLoading.Location = new System.Drawing.Point(128, 180);
            this.picGioHangLoading.Margin = new System.Windows.Forms.Padding(0);
            this.picGioHangLoading.Name = "picGioHangLoading";
            this.picGioHangLoading.Size = new System.Drawing.Size(64, 64);
            this.picGioHangLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGioHangLoading.TabIndex = 0;
            this.picGioHangLoading.TabStop = false;
            this.picGioHangLoading.Visible = false;
            // 
            // flpGioHang
            // 
            this.flpGioHang.AutoScroll = true;
            this.flpGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGioHang.Location = new System.Drawing.Point(0, 0);
            this.flpGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.flpGioHang.Name = "flpGioHang";
            this.flpGioHang.Size = new System.Drawing.Size(320, 424);
            this.flpGioHang.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btnHuyGioHang);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(8, 432);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 100);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nThanhTien);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox3.Location = new System.Drawing.Point(1, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 11);
            this.groupBox3.Size = new System.Drawing.Size(319, 53);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceVariantColor;
            this.label4.Location = new System.Drawing.Point(290, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "₫";
            // 
            // nThanhTien
            // 
            this.nThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nThanhTien.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.nThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nThanhTien.Enabled = false;
            this.nThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nThanhTien.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.nThanhTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nThanhTien.Location = new System.Drawing.Point(49, 18);
            this.nThanhTien.Margin = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.nThanhTien.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nThanhTien.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nThanhTien.Name = "nThanhTien";
            this.nThanhTien.Size = new System.Drawing.Size(233, 24);
            this.nThanhTien.TabIndex = 0;
            this.nThanhTien.Tag = "";
            this.nThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nThanhTien.ThousandsSeparator = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox7.Image = global::QLpizza.Properties.Resources.ic_payments_24px;
            this.pictureBox7.Location = new System.Drawing.Point(9, 18);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // btnHuyGioHang
            // 
            this.btnHuyGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyGioHang.AutoSize = true;
            this.btnHuyGioHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuyGioHang.BackColor = System.Drawing.Color.Tomato;
            this.btnHuyGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyGioHang.FlatAppearance.BorderSize = 0;
            this.btnHuyGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHuyGioHang.ImageKey = "ic_shopping_cart_off_24px.png";
            this.btnHuyGioHang.ImageList = this.imageList1;
            this.btnHuyGioHang.Location = new System.Drawing.Point(167, 64);
            this.btnHuyGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnHuyGioHang.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnHuyGioHang.Name = "btnHuyGioHang";
            this.btnHuyGioHang.Padding = new System.Windows.Forms.Padding(4);
            this.btnHuyGioHang.Size = new System.Drawing.Size(153, 36);
            this.btnHuyGioHang.TabIndex = 2;
            this.btnHuyGioHang.Text = "HUỶ GIỎ HÀNG";
            this.btnHuyGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyGioHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyGioHang.UseVisualStyleBackColor = false;
            this.btnHuyGioHang.Click += new System.EventHandler(this.btnHuyGioHang_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_shopping_cart_off_24px.png");
            this.imageList1.Images.SetKeyName(1, "ic_payments_24px.png");
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhToan.AutoSize = true;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnThanhToan.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.btnThanhToan.ImageKey = "ic_payments_24px.png";
            this.btnThanhToan.ImageList = this.imageList1;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 64);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.btnThanhToan.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Size = new System.Drawing.Size(140, 36);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lStatus
            // 
            this.lStatus.AutoToolTip = true;
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 0);
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // MuaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.pnlGioHang);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Name = "MuaPizza";
            this.Text = "Pizza HIT [Mua pizza]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pizza_FormClosing);
            this.Load += new System.EventHandler(this.Pizza_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaLoading)).EndInit();
            this.pnlGioHang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGioHangLoading)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nThanhTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpGioHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picPizzaLoading;
        private System.Windows.Forms.Panel pnlGioHang;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker bgwPizza;
        public System.Windows.Forms.FlowLayoutPanel flpPizza;
        private System.ComponentModel.BackgroundWorker bgwGioHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picGioHangLoading;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox bGioHang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHuyGioHang;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cMaLoai;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox panel13;
        private System.Windows.Forms.NumericUpDown nSoLuong;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nThanhTien;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}