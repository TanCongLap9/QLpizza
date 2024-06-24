namespace QLpizza
{
    partial class TraCuu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cBang = new System.Windows.Forms.ComboBox();
            this.tMa = new System.Windows.Forms.TextBox();
            this.tDuLieu = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.dgvKetQua);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox1.Location = new System.Drawing.Point(32, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox1.Size = new System.Drawing.Size(720, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả tra cứu";
            this.groupBox1.Visible = false;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.label24.Location = new System.Drawing.Point(3, 220);
            this.label24.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(548, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Lưu ý: Để tránh gây gián đoạn, chỉ 50 kết quả tra cứu đầu tiên sẽ được trả về.";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AllowUserToDeleteRows = false;
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Font = new System.Drawing.Font("Arial", 12F);
            this.dgvKetQua.Location = new System.Drawing.Point(3, 22);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(0);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(714, 182);
            this.dgvKetQua.TabIndex = 0;
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.FlatAppearance.BorderSize = 0;
            this.thoat.Location = new System.Drawing.Point(-30, -30);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(29, 30);
            this.thoat.TabIndex = 46;
            this.thoat.TabStop = false;
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(334, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tra cứu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = global::QLpizza.Properties.Resources.danger_icon;
            // 
            // cBang
            // 
            this.cBang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBang.DisplayMember = "Item2";
            this.cBang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cBang.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.cBang, 8);
            this.cBang.IntegralHeight = false;
            this.cBang.Location = new System.Drawing.Point(49, 15);
            this.cBang.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.cBang.Name = "cBang";
            this.cBang.Size = new System.Drawing.Size(181, 30);
            this.cBang.TabIndex = 0;
            this.cBang.ValueMember = "Item1";
            this.cBang.Enter += new System.EventHandler(this.InputControl_Enter);
            this.cBang.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // tMa
            // 
            this.tMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tMa.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tMa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tMa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMa.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tMa, 8);
            this.tMa.Location = new System.Drawing.Point(49, 19);
            this.tMa.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tMa.Name = "tMa";
            this.tMa.Size = new System.Drawing.Size(181, 21);
            this.tMa.TabIndex = 0;
            this.tMa.Tag = "";
            this.tMa.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tMa.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // tDuLieu
            // 
            this.tDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tDuLieu.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tDuLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tDuLieu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.errorProvider1.SetIconPadding(this.tDuLieu, 8);
            this.tDuLieu.Location = new System.Drawing.Point(49, 19);
            this.tDuLieu.Margin = new System.Windows.Forms.Padding(16, 0, 32, 0);
            this.tDuLieu.Name = "tDuLieu";
            this.tDuLieu.Size = new System.Drawing.Size(319, 21);
            this.tDuLieu.TabIndex = 0;
            this.tDuLieu.Tag = "";
            this.tDuLieu.Enter += new System.EventHandler(this.InputControl_Enter);
            this.tDuLieu.Leave += new System.EventHandler(this.InputControl_Leave);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.AutoSize = true;
            this.btnTraCuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTraCuu.BackColor = global::QLpizza.Properties.Settings.Default.PrimaryBackColor;
            this.btnTraCuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTraCuu.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(32, 230);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnTraCuu.MinimumSize = new System.Drawing.Size(64, 0);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Padding = new System.Windows.Forms.Padding(4);
            this.btnTraCuu.Size = new System.Drawing.Size(92, 36);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "TRA CỨU";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
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
            this.statusStrip1.TabIndex = 1;
            // 
            // lStatus
            // 
            this.lStatus.AutoToolTip = true;
            this.lStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 0);
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTraCuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(32, 16, 32, 16);
            this.panel1.Size = new System.Drawing.Size(784, 540);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = global::QLpizza.Properties.Settings.Default.CardBackColor;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 154);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.tDuLieu);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox4.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox4.Location = new System.Drawing.Point(295, 77);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 0, 0, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(9, 4, 9, 11);
            this.groupBox4.Size = new System.Drawing.Size(409, 53);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm dữ liệu có chứa";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.Image = global::QLpizza.Properties.Resources.ic_search_24px;
            this.pictureBox5.Location = new System.Drawing.Point(9, 18);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tMa);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox3.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox3.Location = new System.Drawing.Point(16, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(9, 4, 9, 11);
            this.groupBox3.Size = new System.Drawing.Size(271, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm theo mã";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = global::QLpizza.Properties.Resources.ic_search_24px;
            this.pictureBox4.Location = new System.Drawing.Point(9, 18);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cBang);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = global::QLpizza.Properties.Settings.Default.OutlineColor;
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 4, 9, 11);
            this.groupBox2.Size = new System.Drawing.Size(271, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::QLpizza.Properties.Resources.ic_table_24px;
            this.pictureBox3.Location = new System.Drawing.Point(9, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // TraCuu
            // 
            this.AcceptButton = this.btnTraCuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = global::QLpizza.Properties.Settings.Default.SurfaceColor;
            this.Icon = global::QLpizza.Properties.Resources.pizza_hit_icon;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "TraCuu";
            this.Text = "Pizza HIT [Tra cứu]";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tDuLieu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tMa;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}