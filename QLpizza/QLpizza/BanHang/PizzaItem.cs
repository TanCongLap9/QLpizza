using QLpizza.BanHang;
using QLpizza.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QLpizza.CustomComponents
{
    public partial class PizzaItem : UserControl
    {
        private int price;
        private bool _checked, selectable;

        public PizzaItem()
        {
            InitializeComponent();
            GiaBan = 0;
        }

        public PizzaItem(int index, bool inCart, bool selectable)
        {
            InitializeComponent();
            GiaBan = 0;
            Index = index;
            InCart = inCart;
            Selectable = selectable;
        }

        public PizzaItem(PizzaModel model, int index, bool inCart, bool selectable)
        {
            InitializeComponent();
            Model = model;
            TenPizza.Text = model.TenPizza;
            SoLuong.Value = model.SoLuong;
            GiaBan = model.GiaBan;
            Hinh.ImageLocation = model.FileHinh;
            Index = index;
            InCart = inCart;
            Selectable = selectable;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PizzaModel Model { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Checked
        {
            get { return _checked; }
            set {
                _checked = value;
                this.BackColor = this.TenPizza.BackColor = this.giaBan.BackColor = value
                    ? Settings.Default.PrimaryDarkBackColor
                    : Color.Empty;
                
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Index { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool InCart
        {
            get { return SoLuong.Visible && Xoa.Visible && label1.Visible && tong.Visible && label3.Visible; }
            set { SoLuong.Visible = Xoa.Visible = label1.Visible = tong.Visible = label3.Visible = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get { return TenPizza.Text; }
            set {
                TenPizza.Text = value;
                toolTip1.SetToolTip(TenPizza, value);
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int GiaBan
        {
            get { return price; }
            set {
                price = value;
                giaBan.Text = value.ToString("n0", CultureInfo.InvariantCulture) + "\u20ab";
                tong.Text = (value * SoLuong.Value).ToString("n0", CultureInfo.InvariantCulture) + "\u20ab";
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selectable
        {
            get { return selectable; }
            set {
                selectable = value;
                if (!value) return;
                this.TenPizza.Click += OnClick;
                this.giaBan.Click += OnClick;
                this.Hinh.Click += OnClick;
                this.Click += OnClick;

                this.TenPizza.MouseHover += OnEnter;
                this.giaBan.MouseHover += OnEnter;
                this.Hinh.MouseHover += OnEnter;
                this.MouseHover += OnEnter;

                /*this.TenPizza.Enter += OnEnter;
                this.giaBan.Enter += OnEnter;
                this.Hinh.Enter += OnEnter;*/
                this.Enter += OnEnter;

                /*this.TenPizza.Leave += OnLeave;
                this.giaBan.Leave += OnLeave;
                this.Hinh.Leave += OnLeave;*/
                this.Leave += OnLeave;

                this.TenPizza.MouseLeave += OnLeave;
                this.giaBan.MouseLeave += OnLeave;
                this.Hinh.MouseLeave += OnLeave;
                this.MouseLeave += OnLeave;
            }
        }

        private void OnEnter(object sender, EventArgs e)
        {
            if (this.Checked) return;
            this.BackColor = this.TenPizza.BackColor = this.giaBan.BackColor =
                Settings.Default.PrimaryLightBackColor;
        }

        private void OnLeave(object sender, EventArgs e)
        {
            if (this.Checked) return;
            this.BackColor = this.TenPizza.BackColor = this.giaBan.BackColor =
                Color.Empty;
        }

        private void OnClick(object sender, EventArgs e)
        {
            Checked = true;
            if (ItemClick != null) ItemClick.Invoke(this, e);
            int tag = this.Parent.Tag == null ? -1 : (int)this.Parent.Tag;
            if (tag != this.Index)
            {
                if (tag != -1 && tag < this.Parent.Controls.Count - 1)
                    ((PizzaItem)this.Parent.Controls[tag]).Checked = false;
                this.Parent.Tag = this.Index;
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            Delete?.Invoke(this, e);
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            Model.SoLuong = Convert.ToInt32(SoLuong.Value);
            ValueChanged?.Invoke(this, e);
        }

        public event EventHandler ItemClick, Delete, ValueChanged;
    }
}
