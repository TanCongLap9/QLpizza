using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLpizza.QuanLy
{
    public partial class CongViec : FormQuanLyDon
    {
        public CongViec()
        {
            InitializeComponent();
            base.FieldsBox = fieldsBox1;
            base.ErrorProvider = errorProvider1;
            base.Fields = new Control[] { tMaCV, tTenCV, tMoTa, nMucLuong };
            base.IdField = tMaCV;
            base.ShuffleButton = btnShuffle;
            base.Search = tTimKiemCongViec;
            base.CloseButton = (Button)this.CancelButton;
        }

        private async void CongViec_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            await fieldsBox1.Load();
        }

        protected override void FieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.FieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaCV, tTenCV, nMucLuong, tMoTa })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaCongViec FROM CONGVIEC"), "MaCongViec", tMaCV.Text.Trim())) != null)
                {
                    SetError(tMaCV, error);
                    valid = false;
                }    
            }
            if (!new Regex(@"^[A-Z]{2}\d{2}V$").IsMatch(tMaCV.Text.Trim())) {
                SetError(tMaCV, "Vui lòng nhập mã đúng dạng: xxyyV, với mỗi x là mỗi chữ cái viết hoa và mỗi y là mỗi chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
        }

        private void danhSach_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = string.Format("{0} - {1}",
                ((DataRowView)e.ListItem).Row.Field<string>("MaCongViec"),
                ((DataRowView)e.ListItem).Row.Field<string>("TenCongViec"));
        }
    }
}
