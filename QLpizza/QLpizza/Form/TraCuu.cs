using System;
using QLpizza.CustomComponents;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QLpizza.Properties;

namespace QLpizza
{
    public partial class TraCuu : Form
    {
        private Dictionary<string, string> idColumn = new Dictionary<string, string>()
        {
            ["NGUOIDUNG"] = "MaND",
            ["CONGVIEC"] = "MaCongViec",
            ["NGUYENLIEU"] = "MaNL",
            ["PIZZA"] = "MaPizza",
            ["NHACUNGCAP"] = "MaNCC"
        };

        private Dictionary<string, string[]> returnedColumns = new Dictionary<string, string[]>()
        {
            ["NGUOIDUNG"] = new string[] { "MaND", "HoTen", "GioiTinh" },
            ["CONGVIEC"] = new string[] {"MaCongViec", "TenCongViec"},
            ["NGUYENLIEU"] = new string[] { "MaNL", "TenNL", "SoLuong", "DonViTinh" },
            ["PIZZA"] = new string[] { "MaPizza", "TenPizza", "GiaBan" },
            ["NHACUNGCAP"] = new string[] { "MaNCC", "TenNCC", "DiaChi", "SDT" }
        };

        private DataTable filtered = new DataTable();

        public TraCuu()
        {
            InitializeComponent();
            dgvKetQua.ForeColor = Settings.Default.SurfaceColor;
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            cBang.DataSource = new Tuple<string, string>[] {
                Tuple.Create("NGUOIDUNG", "Người dùng"),
                Tuple.Create("CONGVIEC", "Công việc"),
                Tuple.Create("NGUYENLIEU", "Nguyên liệu"),
                Tuple.Create("PIZZA", "Pizza"),
                Tuple.Create("NHACUNGCAP", "Nhà cung cấp")
            };
        }

        private async void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            string tableName = FieldsBoxWindow.GetFieldValue(cBang).ToString();
            string searchValue = null;

            if (!string.IsNullOrWhiteSpace(tMa.Text))
                searchValue = SearchUtils.ToSearchString(tMa.Text.Trim());
            else if (!string.IsNullOrWhiteSpace(tDuLieu.Text))
                searchValue = SearchUtils.ToSearchString(tDuLieu.Text.Trim());

            groupBox1.Show();
            SetInputsEnabled(false);
            dgvKetQua.DataSource = null;

            try
            {
                if (!string.IsNullOrWhiteSpace(tMa.Text))
                {
                    await SqlUtils.QueryAsync(
                        $@"SELECT TOP 50 {
                            string.Join(", ", returnedColumns[tableName])
                        } FROM {tableName} WHERE {idColumn[tableName]} = @Ma",
                        new Dictionary<string, object>()
                        {
                            ["Ma"] = tMa.Text.Trim()
                        },
                        filtered
                    );
                    dgvKetQua.DataSource = filtered;
                }
                else
                {
                    DataTable table = await SqlUtils.QueryAsync(
                        $@"SELECT TOP 50 {
                            string.Join(", ", returnedColumns[tableName])
                        } FROM {tableName}"
                    );
                    filtered = table.Clone();
                    foreach (DataRow row in table.Rows)
                        foreach (string column in returnedColumns[tableName])
                        {
                            string currentValue = SearchUtils.ToSearchString(row.Field<object>(column).ToString());
                            if (currentValue.Contains(searchValue))
                            {
                                DataRow newRow = filtered.NewRow();
                                newRow.ItemArray = (object[])row.ItemArray.Clone();
                                filtered.Rows.Add(newRow);
                                break;
                            }
                        }
                    dgvKetQua.DataSource = filtered;
                }
                lStatus.Text = filtered.Rows.Count == 0 ?
                    "Không có kết quả nào phù hợp với dữ liệu cần tìm." :
                    $"Có {filtered.Rows.Count} kết quả phù hợp.";
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong quá trình tra cứu: " + exc.Message;
            }
            finally
            {
                SetInputsEnabled(true);
                SqlUtils.Conn.Close();
            }
        }

        private bool ValidateInput()
        {
            ClearAllErrors();
            bool valid = true;
            if (cBang.SelectedIndex == -1)
            {
                SetError(cBang, "Đây là thông tin bắt buộc.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(tMa.Text) &&
                string.IsNullOrWhiteSpace(tDuLieu.Text))
            {
                SetError(tMa,
                    "Vui lòng điền dữ liệu vào Tìm theo mã hoặc " +
                    "Tìm dữ liệu có chứa để tiến hành tìm kiếm.");
                valid = false;
            }
            if (!valid) return valid;
            if (!string.IsNullOrWhiteSpace(tMa.Text) &&
                !string.IsNullOrWhiteSpace(tDuLieu.Text))
            {
                SetError(tDuLieu,
                    "Vui lòng chỉ điền vào một trong 2 " +
                    "ô tìm kiếm, không điền vào cả 2.");
                valid = false;
            }
            if (!valid) return valid;
            return valid;
        }

        #region InputControls

        private void InputControl_Enter(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.AccentBackColor;
            SetError((Control)sender, string.Empty);
        }

        private void InputControl_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Parent.ForeColor = Settings.Default.OutlineColor;
            SetError((Control)sender, string.Empty);
        }

        private void SetError(Control control, string value)
        {
            control.Parent.ForeColor =
                string.IsNullOrEmpty(value) ?
                    Settings.Default.OutlineColor :
                    Settings.Default.InputErrorForeColor;
            errorProvider1.SetError(control, value);
        }

        private void ClearAllErrors()
        {
            foreach (Control control in new Control[]
            {
                cBang, tMa, tDuLieu
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tableLayoutPanel1,
                btnTraCuu
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
