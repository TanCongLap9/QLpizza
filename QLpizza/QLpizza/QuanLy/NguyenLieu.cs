using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLpizza.QuanLy
{
    public partial class NguyenLieu : FormQuanLyDon
    {
        public NguyenLieu()
        {
            InitializeComponent();
            base.FieldsBox = fieldsBox1;
            base.ErrorProvider = errorProvider1;
            base.Fields = new Control[] {
                tMaNL, tTenNL,
                nSoLuong, tDVT,
                nDonGia
            };
            base.IdField = tMaNL;
            base.ShuffleButton = btnShuffle;
            base.CloseButton = (Button)this.CancelButton;
            this.Search = tTimKiemNguyenLieu;
        }

        private async void NguyenLieu_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            await fieldsBox1.Load();
        }

        protected override void FieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.FieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaNL, tTenNL, tDVT })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^NL\d{3}$").IsMatch(tMaNL.Text.Trim()))
            {
                SetError(tMaNL, "Vui lòng nhập mã đúng dạng: NLxxx, với mỗi x là mỗi chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaNL FROM NGUYENLIEU"), "MaNL", tMaNL.Text.Trim())) != null)
                {
                    SetError(tMaNL, error);
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        protected override void FieldsBox_Cleared(object sender, EventArgs e)
        {
            base.FieldsBox_Cleared(sender, e);
            nSoLuong.Value = 0;
            nSoLuong.Enabled = false;
        }

        private void danhSach_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = string.Format("{0} - {1}",
                ((DataRowView)e.ListItem).Row.Field<string>("MaNL"),
                ((DataRowView)e.ListItem).Row.Field<string>("TenNL"));
        }
    }
}
