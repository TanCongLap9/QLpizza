using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace QLpizza.QuanLy
{
    public partial class CongThuc : FormQuanLyDoi
    {
        private DataTable pizzaTable, nlTable;

        public CongThuc()
        {
            InitializeComponent();
            base.TabControl = tabControl1;
            base.MasterFieldsBox = fieldsBox1;
            base.DetailFieldsBox = fieldsBox2;
            base.ErrorProvider = errorProvider1;
            base.MasterIdField = tMaCT;
            base.DetailIdField = tMaCT2;
            base.MasterPage = tabPage1;
            base.DetailPage = tabPage2;
            base.ToDetail = btnXemChiTiet;
            base.MasterShuffleButton = btnShuffle;
            base.Search = Tuple.Create<Control, Control>(tTimKiemCongThuc, tTimKiemChiTiet);
            base.Fields = new Control[] { tMaCT, tTacGia, cMaPizza, nKhauHao, tMaCT2, cMaNL, nSoLuong, tDVT, nThoiGianCheBien };
            base.CloseButton = (Button)this.CancelButton;
            base.OkButton = (Button)this.AcceptButton;
        }

        private async void CongThuc_Load(object sender, EventArgs e)
        {
            fieldsBox1.ReadOnly = fieldsBox2.ReadOnly = DangNhap.thongTinHienTai.Quyen[this.Name][1] == 0;
            fieldsBox2.AutoFields.Add(tDVT, () => {
                foreach (DataRow nlRow in nlTable.Rows)
                    if (nlRow.Field<string>("MaNL") == fieldsBox2.SelectedRow.Field<string>("MaNL"))
                        return Task.FromResult<object>(nlRow.Field<string>("DonViTinh"));
                return null;
            });
            fieldsBox1.AutoFields.Add(nChiPhi, async () =>
            {
                object table = await SqlUtils.ExecuteScalarAsync("PROC_CONGTHUC_CHIPHI",
                    new Dictionary<string, object>()
                    {
                        ["MaCongThuc"] = fieldsBox1.SelectedRow.Field<string>("MaCongThuc")
                    }, CommandType.StoredProcedure);
                return Convert.ToInt64(table);
            });
            await fieldsBox1.Load();
        }

        protected override async Task LoadData()
        {
            await base.LoadData();
            cMaPizza.DataSource = pizzaTable = SqlUtils.Query("SELECT MaPizza, TenPizza FROM PIZZA;");
            cMaNL.DataSource = nlTable = SqlUtils.Query("SELECT MaNL, TenNL, DonViTinh FROM NGUYENLIEU;");
        }

        protected override void MasterFieldsBox_Updating(object sender, CancelEventArgs e)
        {
            base.MasterFieldsBox_Updating(sender, e);
            bool valid = true;
            string error;
            foreach (Control txt in new Control[] { tMaCT, tTacGia })
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    SetError(txt, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            foreach (ComboBox cbo in new ComboBox[] { cMaPizza })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (!new Regex(@"^CT\d{3}$").IsMatch(tMaCT.Text.Trim()))
            {
                SetError(tMaCT, "Vui lòng nhập mã đúng dạng: CTxxx, với mỗi x là mỗi chữ số.");
                valid = false;
            }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox1.SelectedIndex == -1)
            {
                if ((error = Validator.Id(SqlUtils.Query("SELECT MaCongThuc FROM CONGTHUC"), "MaCongThuc", tMaCT.Text.Trim())) != null)
                {
                    SetError(tMaCT, error);
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
            foreach (ComboBox cbo in new ComboBox[] { cMaNL })
                if (cbo.SelectedIndex == -1)
                {
                    SetError(cbo, "Đây là thông tin bắt buộc.");
                    valid = false;
                }
            if (!valid) { e.Cancel = true; return; }
            if (fieldsBox2.SelectedIndex == -1)
            {
                if (Validator.Id(fieldsBox2.Table, "MaNL", cMaNL.SelectedValue.ToString()) != null)
                {
                    SetError(cMaNL, "Nguyên liệu bị trùng. Vui lòng nhập nguyên liệu khác.");
                    valid = false;
                }
                if (!valid) { e.Cancel = true; return; }
            }
        }

        private void danhSach1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            foreach (DataRow pizzaRow in pizzaTable.Rows)
                if (row.Field<string>("MaPizza") == pizzaRow.Field<string>("MaPizza"))
                {
                    e.Value = string.Format("{0} ({1})",
                        row.Field<string>("MaCongThuc"),
                        pizzaRow.Field<string>("TenPizza"));
                    break;
                }
        }

        private void danhSach2_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow row = ((DataRowView)e.ListItem).Row;
            foreach (DataRow nlRow in nlTable.Rows)
                if (row.Field<string>("MaNL") == nlRow.Field<string>("MaNL"))
                {
                    e.Value = string.Format("{0} ({1:g3} {2})",
                        nlRow.Field<string>("TenNL"),
                        row.Field<double>("SoLuong"),
                        nlRow.Field<string>("DonViTinh"));
                    break;
                }
        }
    }
}
