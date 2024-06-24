namespace QLpizza.CustomComponents
{
    partial class PizzaItem
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
                Hinh.Image.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hinh = new System.Windows.Forms.PictureBox();
            this.TenPizza = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.NumericUpDown();
            this.Xoa = new System.Windows.Forms.Button();
            this.giaBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // Hinh
            // 
            this.Hinh.ErrorImage = global::QLpizza.Properties.Resources.ic_broken_image_24px;
            this.Hinh.Image = global::QLpizza.Properties.Resources.pizza_1;
            this.Hinh.Location = new System.Drawing.Point(0, 0);
            this.Hinh.Margin = new System.Windows.Forms.Padding(0);
            this.Hinh.Name = "Hinh";
            this.Hinh.Size = new System.Drawing.Size(40, 88);
            this.Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hinh.TabIndex = 0;
            this.Hinh.TabStop = false;
            // 
            // TenPizza
            // 
            this.TenPizza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TenPizza.AutoEllipsis = true;
            this.TenPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TenPizza.Location = new System.Drawing.Point(40, 0);
            this.TenPizza.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.TenPizza.Name = "TenPizza";
            this.TenPizza.Size = new System.Drawing.Size(260, 23);
            this.TenPizza.TabIndex = 0;
            this.TenPizza.Text = "Tên pizza";
            // 
            // SoLuong
            // 
            this.SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoLuong.Location = new System.Drawing.Point(57, 53);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.SoLuong.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SoLuong.Size = new System.Drawing.Size(59, 22);
            this.SoLuong.TabIndex = 3;
            this.SoLuong.TabStop = false;
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SoLuong.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Xoa.BackColor = System.Drawing.Color.Tomato;
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.ForeColor = System.Drawing.Color.White;
            this.Xoa.Image = global::QLpizza.Properties.Resources.ic_delete_24px;
            this.Xoa.Location = new System.Drawing.Point(264, 52);
            this.Xoa.Margin = new System.Windows.Forms.Padding(0);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(36, 36);
            this.Xoa.TabIndex = 6;
            this.Xoa.TabStop = false;
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.OnDelete);
            // 
            // giaBan
            // 
            this.giaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giaBan.Location = new System.Drawing.Point(41, 27);
            this.giaBan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.giaBan.Name = "giaBan";
            this.giaBan.Size = new System.Drawing.Size(259, 20);
            this.giaBan.TabIndex = 1;
            this.giaBan.Text = "Giá";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // tong
            // 
            this.tong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tong.Location = new System.Drawing.Point(134, 52);
            this.tong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(130, 20);
            this.tong.TabIndex = 5;
            this.tong.Text = "Tổng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // PizzaItem
            // 
            this.Controls.Add(this.Hinh);
            this.Controls.Add(this.TenPizza);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.giaBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PizzaItem";
            this.Size = new System.Drawing.Size(300, 88);
            ((System.ComponentModel.ISupportInitialize)(this.Hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label giaBan;
        public System.Windows.Forms.Button Xoa;
        public System.Windows.Forms.Label TenPizza;
        public System.Windows.Forms.NumericUpDown SoLuong;
        public System.Windows.Forms.PictureBox Hinh;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label tong;
        private System.Windows.Forms.Label label3;
    }
}
