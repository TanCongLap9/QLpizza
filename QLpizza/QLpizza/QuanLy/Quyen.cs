using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLpizza.QuanLy
{
    public partial class Quyen : FormQuanLyDoi
    {
        public Quyen()
        {
            InitializeComponent();
            base.TabControl = tabControl1;
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.MasterIdField = tMaQuyen;
            base.DetailIdField = tMaQuyen2;
            base.MasterPage = tabPage1;
            base.DetailPage = tabPage2;
            base.ToDetail = btnXemChiTiet;
            base.MasterShuffleButton = btnShuffle;
            base.Search = Tuple.Create<Control, Control>(tTimKiemQuyenHan, tTimKiemChiTiet);
            base.Fields = new Control[] { tMaQuyen, tTenQuyen, tMaQuyen2, tTenForm, cDuocDoc, cDuocGhi };
            base.CloseButton = (Button)this.CancelButton;
            base.OkButton = (Button)this.AcceptButton;
        }

        private async void Quyen_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            await fieldsBox1.Load();
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cDuocDoc.DataSource = cDuocGhi.DataSource = new Tuple<int, string>[] {
                Tuple.Create(0, "Không cho phép"),
                Tuple.Create(1, "Cho phép")
            };
            cDuocGhi.BindingContext = new BindingContext();
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaQuyen, tTenQuyen })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^QH\d{3}$").IsMatch(tMaQuyen.Text.Trim()))
            {
                SetError(tMaQuyen, "Vui lòng nhập mã đúng dạng: QHxxx, với mỗi x là mỗi chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaQuyen FROM QUYENHAN"), "MaQuyen", tMaQuyen.Text.Trim())) != null)
                {
                    SetError(tMaQuyen, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void DetailFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.DetailFieldsBox_Updating(sender, e);
            bool valid = true;
            foreach (Control txt in new Control[] { tTenForm })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cDuocDoc, cDuocGhi })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox2.SelectedIndex == -1)
            {
                if (Validator.Id(fieldsBox2.Table, "TenForm", tTenForm.Text.Trim()) != null)
                {
                    SetError(tTenForm, "Tên form bị trùng.");
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        private void danhSach1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            e.Value = string.Format("{0} - {1}",
                row.Field<string>("MaQuyen"),
                row.Field<string>("TenQuyen"));
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            e.Value = string.Format("{0} - {1}",
                row.Field<string>("TenForm"),
                row.Field<int>("DuocDoc") == 1 && row.Field<int>("DuocGhi") == 1 ? "Đọc ghi" :
                    row.Field<int>("DuocDoc") == 1 && row.Field<int>("DuocGhi") == 0 ? "Đọc" :
                    row.Field<int>("DuocDoc") == 0 && row.Field<int>("DuocGhi") == 1 ? "Ghi" :
                    "Không");
        }
    }
}
