using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLpizza.QuanLy
{
    public partial class KhachHang : FormQuanLyDon
    {
        public KhachHang()
        {
            InitializeComponent();
            base.FieldsBox = fieldsBox1;
            base.ErrorProvider = errorProvider1;
            base.Fields = new Control[] {
                tMaND, tHoTen, cGioiTinh, tTaiKhoan,
                tMatKhau, tEmail, dNgaySinh, tSdt,
                cMaQuyen
            };
            base.IdField = tMaND;
            base.ShuffleButton = btnShuffle;
            base.CloseButton = (Button)this.CancelButton;
            base.PasswordField = tMatKhau;
            base.ShowPasswordButton = btnHienMatKhau;
            base.Search = tTimKiemKhachHang;
            base.CheckBoxes = new CheckBox[] { bTrangThaiDangNhap };
        }

        private async void KhachHang_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            await fieldsBox1.Load();
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaQuyen.DataSource = SqlUtils.Query("SELECT MaQuyen, TenQuyen FROM QUYENHAN");
            cCongViec.DataSource = SqlUtils.Query("SELECT MaCongViec, TenCongViec FROM CONGVIEC");
        }

        protected override void FieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.FieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaND, tHoTen, tEmail, tSdt, tTaiKhoan })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cGioiTinh })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (fieldsBox1.SelectedIndex == -1 && string.IsNullOrWhiteSpace(tMatKhau.Text))
            {
                SetError(tMatKhau, "Đây là thông tin bắt buộc.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^[A-Z0-9]{4}K$").IsMatch(tMaND.Text.Trim()))
            {
                SetError(tMaND, "Vui lòng nhập mã đúng dạng: xxxxK, với mỗi x là mỗi chữ cái viết hoa hoặc chữ số.");
                valid = false;
            }
            if ((error = Validator.Email(tEmail.Text.Trim())) != null)
            {
                SetError(tEmail, error);
                valid = false;
            }
            if ((error = Validator.Sdt(tSdt.Text.Trim())) != null)
            {
                SetError(tSdt, error);
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaND FROM NGUOIDUNG"), "MaND", tMaND.Text.Trim())) != null)
                {
                    SetError(tMaND, error);
                    valid = false;
                }
                if (Validator.Id(SqlUtils.Query("SELECT TenDangNhap FROM NGUOIDUNG"), "TenDangNhap", tTaiKhoan.Text.Trim()) != null)
                {
                    SetError(tTaiKhoan, "Tài khoản này đã được sử dụng. Vui lòng nhập tài khoản khác.");
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
            ShowPassword();
        }

        protected override void FieldsBox_Cleared(object sender, EventArgs e)
        {
            base.FieldsBox_Cleared(sender, e);
            cMaQuyen.SelectedValue = "QH005";
            cCongViec.SelectedValue = "KH00V";
        }

        private void danhSach_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = string.Format("{0} - {1}",
                ((DataRowView)e.ListItem).Row.Field<string>("MaND"),
                ((DataRowView)e.ListItem).Row.Field<string>("HoTen"));
        }
    }
}
