using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLpizza.Properties;

namespace QLpizza
{
    public partial class ThongKe : Form
    {
        private DataTable table = new DataTable();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cBang.DataSource = new Tuple<string, string>[] {
                Tuple.Create("HOADON", "Hoá đơn"),
                Tuple.Create("NGUYENLIEU", "Nguyên liệu"),
                Tuple.Create("PIZZA", "Pizza")
            };
            dgvKetQua.DataSource = table;
            dgvKetQua.ForeColor = Settings.Default.SurfaceColor;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            groupBox1.Show();
            tableLayoutPanel2.Show();
            pnlTongDoanhThu.Visible = pnlTongLoiNhuan.Visible =
                cBang.SelectedValue.ToString() == "PIZZA" ||
                cBang.SelectedValue.ToString() == "HOADON";
            pnlTongGiaTri.Visible = cBang.SelectedValue.ToString() == "NGUYENLIEU";
            SetInputsEnabled(false);

            try
            {
                decimal doanhThu = 0,
                    loiNhuan = 0,
                    tongGiaTri = 0;
                switch (cBang.SelectedValue.ToString())
                {
                    case "PIZZA":
                        SqlUtils.Query("PROC_THONGKE_PIZZA",
                            new Dictionary<string, object>
                            {
                                ["MinDate"] = dTuNgay.Value,
                                ["MaxDate"] = dDenNgay.Value,
                            }, table, CommandType.StoredProcedure);
                        foreach (DataRow row in table.Rows)
                        {
                            doanhThu += Convert.ToDecimal(row.Field<object>("DoanhThu"));
                            loiNhuan += Convert.ToDecimal(row.Field<object>("LoiNhuan"));
                        }
                        nTongDoanhThu.Value = doanhThu;
                        nTongLoiNhuan.Value = loiNhuan;
                        break;
                    case "NGUYENLIEU":
                        SqlUtils.Query("PROC_THONGKE_NGUYENLIEU",
                            new Dictionary<string, object>
                            {
                                ["MaxDate"] = dDenNgay.Value
                            }, table, CommandType.StoredProcedure);
                        foreach (DataRow row in table.Rows)
                        {
                            tongGiaTri += Convert.ToDecimal(row.Field<object>("TongTien"));
                        }
                        nTongGiaTri.Value = tongGiaTri;
                        break;
                    case "HOADON":
                        SqlUtils.Query("PROC_THONGKE_HOADON",
                            new Dictionary<string, object>
                            {
                                ["MinDate"] = dTuNgay.Value,
                                ["MaxDate"] = dDenNgay.Value
                            }, table, CommandType.StoredProcedure);
                        foreach (DataRow row in table.Rows)
                        {
                            doanhThu += Convert.ToDecimal(row.Field<object>("DoanhThu"));
                            loiNhuan += Convert.ToDecimal(row.Field<object>("LoiNhuan"));
                        }
                        nTongDoanhThu.Value = doanhThu;
                        nTongLoiNhuan.Value = loiNhuan;
                        break;
                }
                lStatus.Text = table.Rows.Count == 0 ?
                    "Không có kết quả nào phù hợp với dữ liệu cần tìm." :
                    $"Có {table.Rows.Count} kết quả phù hợp.";
            }
            catch (Exception exc)
            {
                lStatus.Text = "Có lỗi xảy ra trong quá trình thống kê: " + exc.Message;
            }
            finally
            {
                SetInputsEnabled(true);
                SqlUtils.Conn.Close();
            }
        }

        private void cBang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel4.Visible = new string[] { "PIZZA", "HOADON" }.Contains(cBang.SelectedValue.ToString());
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
            if (!valid) return valid;
            if (cBang.SelectedValue.ToString() != "NGUYENLIEU" &&
                dDenNgay.Value.Date < dTuNgay.Value.Date)
            {
                SetError(dDenNgay, "Ngày kết thúc không thể trước ngày bắt đầu.");
                valid = false;
            }
            if (!valid) return valid;
            if (cBang.SelectedValue.ToString() != "NGUYENLIEU" &&
                dDenNgay.Value.Date.Subtract(dTuNgay.Value.Date) > TimeSpan.FromDays(30))
            {
                SetError(dDenNgay, "Số ngày tìm kiếm tối đa là 30 ngày kể từ ngày bắt đầu.");
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
                dTuNgay, dDenNgay, cBang
            }) SetError(control, string.Empty);
        }

        private void SetInputsEnabled(bool enabled)
        {
            foreach (Control ctl in new Control[]
            {
                tableLayoutPanel1,
                btnThongKe
            }) ctl.Enabled = enabled;
        }

        #endregion

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
