using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using QLpizza.Properties;

namespace QLpizza.QuanLy
{
    public partial class Pizza : FormQuanLyDoi
    {
        public Pizza()
        {
            InitializeComponent();
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.Fields = new Control[] {
                tMaLoai, tTenLoai, tMaPizza, tTenPizza,
                nGiaBan, fFileHinh, cMaLoai, nGiaVon
            };
            base.MasterIdField = tMaLoai;
            base.DetailIdField = cMaLoai;
            base.DetailTargetIdField = tMaPizza;
            base.MasterPage = tabPage1;
            base.DetailPage = tabPage2;
            base.Search = Tuple.Create<Control, Control>(tTimKiemLoai, timKiem2);
            base.MasterShuffleButton = btnShuffle1;
            base.DetailShuffleButton = btnShuffle2;
            base.CloseButton = (Button)this.CancelButton;
            base.OkButton = (Button)this.AcceptButton;
            base.TabControl = tabControl1;
            base.CheckBoxes = new CheckBox[] { bNgungBan };
            pizzaItem1.Selectable = false;
            pizzaItem1.InCart = false;
            base.ToDetail = btnXemPizza;
        }

        private async void Pizza_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            fieldsBox2.AutoFields.Add(nGiaVon, async () =>
            {
                object table = await SqlUtils.ExecuteScalarAsync(
                    "PROC_PIZZA_GIAVONBINHQUAN",
                    new Dictionary<string, object>()
                    {
                        ["MaPizza"] = fieldsBox2.SelectedRow.Field<string>("MaPizza")
                    }, CommandType.StoredProcedure);
                return Convert.ToInt64(table);
            });
            await fieldsBox1.Load();
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaLoai.DataSource = SqlUtils.Query("SELECT MaLoai, TenLoai FROM LOAIPIZZA");
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaLoai, tTenLoai })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^LP\d{3}$").IsMatch(tMaLoai.Text.Trim()))
            {
                SetError(tMaLoai, "Vui lòng nhập mã đúng dạng: LPxxx, với mỗi x là mỗi chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaLoai FROM LOAIPIZZA"), "MaLoai", tMaLoai.Text.Trim())) != null)
                {
                    SetError(tMaLoai, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void DetailFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.DetailFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaPizza, tTenPizza, fFileHinh })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cMaLoai })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^[A-Z0-9]{4}P$").IsMatch(tMaPizza.Text.Trim()))
            {
                SetError(tMaPizza, "Vui lòng nhập mã đúng dạng: xxxxP, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox2.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaPizza FROM PIZZA"), "MaPizza", tMaPizza.Text.Trim())) != null)
                {
                    SetError(tMaPizza, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        private void danhSach1_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = string.Format("{0} - {1}",
                ((DataRowView)e.ListItem).Row.Field<string>("MaLoai"),
                ((DataRowView)e.ListItem).Row.Field<string>("TenLoai"));
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = string.Format("{0} - {1}",
                ((DataRowView)e.ListItem).Row.Field<string>("MaPizza"),
                ((DataRowView)e.ListItem).Row.Field<string>("TenPizza"));
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string fileName = Path.GetFileName(openFileDialog1.FileName);
            fFileHinh.Text = fileName;
            try
            {
                // Tập tin trên static\pizza đã tồn tại
                if (File.Exists(Path.Combine(Settings.Default.PizzaPath, fileName)))
                {
                    if (MessageBox.Show(
                        "Tập tin này đã tồn tại. Bạn có muốn ghi đè lên không?",
                        "Tập tin tồn tại",
                        MessageBoxButtons.YesNo
                    ) == DialogResult.Yes)
                        File.Copy(openFileDialog1.FileName, Path.Combine(Settings.Default.PizzaPath, fileName), true);
                }
                // Tải hình từ cùng thư mục
                else if (Path.GetDirectoryName(openFileDialog1.FileName) == Settings.Default.PizzaPath)
                    return;
                else
                    File.Copy(openFileDialog1.FileName, Path.Combine(Settings.Default.PizzaPath, fileName));
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    "Có lỗi xảy ra trong lúc tải hình ảnh lên. Vui lòng thử lại lần sau.\n" + exc.Message,
                    "Lỗi tải tập tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        protected override async void MasterFieldsBox_Updated(object sender, EventArgs e)
        {
            base.MasterFieldsBox_Updated(sender, e);
            if (fieldsBox1.RowsAffected != 0)
                await LoadData();
        }

        protected override void DetailFieldsBox_Updated(object sender, EventArgs e)
        {
            base.DetailFieldsBox_Updated(sender, e);
            if (fieldsBox2.RowsAffected == 0) return;
            UpdatePizzaItem();
        }

        protected override void DetailFieldsBox_FieldsFilled(object sender, EventArgs e)
        {
            base.DetailFieldsBox_FieldsFilled(sender, e);
            UpdatePizzaItem();
        }

        private void UpdatePizzaItem()
        {
            pizzaItem1.Text = fieldsBox2.SelectedRow.Field<string>("TenPizza");
            pizzaItem1.GiaBan = fieldsBox2.SelectedRow.Field<int>("GiaBan");
            pizzaItem1.Hinh.ImageLocation = "..\\..\\static\\pizza\\" + fieldsBox2.SelectedRow.Field<string>("FileHinh");
            pizzaItem1.Hinh.Load();
        }

        private void button8_Enter(object sender, EventArgs e)
        {
            InputControl_Enter(fFileHinh, e);
        }

        private void button8_Leave(object sender, EventArgs e)
        {
            InputControl_Leave(fFileHinh, e);
        }
    }
}
