using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLpizza.BanHang;
using QLpizza.Properties;
using QLpizza.QuanLy;

namespace QLpizza
{
    public partial class FormChinh : Form, IMessageFilter
    {
        public static bool CloseSilently;
        public static FormChinh Instance;

        private Size GetDayMoonLocationRange()
        {
            return panel1.Size - sun.Size;
        }

        private Dictionary<double, Color[]> backColorPerHour = new Dictionary<double, Color[]>()
        {
            [0] = new[] { Color.Black, Color.DimGray },
            [5] = new[] { Color.SaddleBrown, Color.Gray },
            [5.5] = new[] { Color.Sienna, Color.LightGray },
            [6] = new[] { Color.LightSlateGray, Color.Silver },
            [7] = new[] { Color.LightSkyBlue, Color.Silver },
            [17] = new[] { Color.Tan, Color.Silver },
            [17.5] = new[] { Color.Orange, Color.Silver },
            [18] = new[] { Color.DarkGoldenrod, Color.LightGray },
            [18.5] = new[] { Color.SaddleBrown, Color.Gray },
            [19] = new[] { Color.Black, Color.DimGray },
        };

        private Dictionary<double, string> timeOfDay = new Dictionary<double, string>()
        {
            [0] = "buổi tối",
            [5] = "buổi sáng",
            [11] = "buổi trưa",
            [15] = "buổi chiều",
            [19] = "buổi tối",
        };

        public FormChinh()
        {
            Instance = this;
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            CloseSilently = false;
            foreach (Control ctl in this.Controls)
                if (ctl is MdiClient)
                    ctl.BackColor = Color.White;
            Application.Idle += OnIdle;
            Application.AddMessageFilter(this);
            if (DangNhap.thongTinHienTai == null)
            {
                MessageBox.Show(
                    "Vui lòng đăng nhập tài khoản để sử dụng phần mềm này.",
                    "Vui lòng đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                CloseSilently = true;
                Close();
                CloseSilently = false;
            }
            UpdateSunMoonLocation();
            HinhCongViec();
            DieuKhienChucNang();
            timer1_Tick(sender, e);
            toolStripLabel2.Text = DangNhap.thongTinHienTai.HoTen;
            toolStripLabel3.Text = DangNhap.thongTinHienTai.Email;
            AddHideMenuOnClickRec(panel1);
        }

        public static void DangXuat(bool force = false)
        {
            try
            {
                int rowsAffected = 0;
                if (DangNhap.thongTinHienTai?.MaND != null)
                    rowsAffected = SqlUtils.ExecuteNonQuery(
                        "UPDATE NGUOIDUNG SET TrangThaiDangNhap = 0 WHERE MaND = @MaND",
                        new Dictionary<string, object>()
                        {
                            ["MaND"] = DangNhap.thongTinHienTai.MaND
                        }
                    );
                if (!force && rowsAffected == 0) throw new Exception("User not found.");
                SqlUtils.Conn.Close();
                if (Instance != null)
                {
                    Application.Idle -= Instance.OnIdle;
                    Application.RemoveMessageFilter(Instance);
                    Instance.updateTimeTimer.Enabled = Instance.afkTimer.Enabled = false;
                }
            }
            finally
            {
                if (force && Instance != null)
                {
                    Application.Idle -= Instance.OnIdle;
                    Application.RemoveMessageFilter(Instance);
                    Instance.updateTimeTimer.Enabled = Instance.afkTimer.Enabled = false;
                }
            }
        }

        private void HinhCongViec()
        {
            Image hinhCongViec;
            Dictionary<string, Image> cacHinhChucVu = new Dictionary<string, Image>
            {
                ["GD00V"] = Resources.giam_doc,
                ["TK00V"] = Resources.thu_ky,
                ["KT00V"] = Resources.ke_toan,
                ["QL00V"] = Resources.quan_ly_cua_hang,
                ["BV00V"] = Resources.bao_ve,
                ["VS00V"] = Resources.ve_sinh,
                ["DB00V"] = Resources.bep,
                ["DB01V"] = Resources.bep,
                ["PV00V"] = Resources.phuc_vu,
                ["TN00V"] = Resources.thu_ngan,
                ["QK00V"] = Resources.quan_ly_kho,
                ["KH00V"] = Resources.khach_hang,
            };
            hinhCongViec = cacHinhChucVu.ContainsKey(DangNhap.thongTinHienTai.MaCongViec) ?
                cacHinhChucVu[DangNhap.thongTinHienTai.MaCongViec] :
                Resources.ic_question_mark_40px;
            toolStripLabel1.Image = hinhCongViec ?? Resources.ic_question_mark_40px;
        }

        private void DieuKhienChucNang()
        {
            bool quyenQuanLy = false, quyenBaoCao = false;
            if (tsbNhanVien.Visible = DangNhap.thongTinHienTai.Quyen["NhanVien"][0] != 0)
                quyenQuanLy = true;
            if (tsbKhachHang.Visible = DangNhap.thongTinHienTai.Quyen["KhachHang"][0] != 0)
                quyenQuanLy = true;
            if (tsbCongViec.Visible = DangNhap.thongTinHienTai.Quyen["CongViec"][0] != 0)
                quyenQuanLy = true;
            if (tsbCongThuc.Visible = DangNhap.thongTinHienTai.Quyen["CongThuc"][0] != 0)
                quyenQuanLy = true;
            if (tsbCheBien.Visible = DangNhap.thongTinHienTai.Quyen["CheBien"][0] != 0)
                quyenQuanLy = true;
            if (tsbHoaDon.Visible = DangNhap.thongTinHienTai.Quyen["HoaDon"][0] != 0)
                quyenQuanLy = true;
            if (tsbNguyenLieu.Visible = DangNhap.thongTinHienTai.Quyen["NguyenLieu"][0] != 0)
                quyenQuanLy = true;
            if (tsbPizza.Visible = DangNhap.thongTinHienTai.Quyen["Pizza"][0] != 0)
                quyenQuanLy = true;
            if (tsbQuyen.Visible = DangNhap.thongTinHienTai.Quyen["Quyen"][0] != 0)
                quyenQuanLy = true;
            if (tsbNhap.Visible = DangNhap.thongTinHienTai.Quyen["Nhap"][0] != 0)
                quyenQuanLy = true;
            if (tsbThongKe.Visible = DangNhap.thongTinHienTai.Quyen["ThongKe"][0] != 0)
                quyenBaoCao = true;
            if (tsbTraCuu.Visible = DangNhap.thongTinHienTai.Quyen["TraCuu"][0] != 0)
                quyenBaoCao = true;
            if (!quyenQuanLy)
                toolStripLabel5.Visible = toolStripSeparator4.Visible = false;
            if (!quyenBaoCao)
                toolStripLabel7.Visible = toolStripSeparator3.Visible = false;
        }

        private void UpdateSunMoonLocation()
        {
            DateTime now = DateTime.Now;
            long time = now.TimeOfDay.Ticks;
            long fullDay = TimeSpan.TicksPerDay;
            double ratioRad = (double)time / fullDay * 2 * Math.PI;
            moon.Location = GetDayLightCycleLocation(ratioRad);
            sun.Location = GetDayLightCycleLocation(ratioRad, true);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string buoi = "";

            KeyValuePair<double, Color[]> colorEntry = backColorPerHour.Last(entry => now.TimeOfDay.TotalHours >= entry.Key);
            panel1.BackColor = colorEntry.Value[0];
            label15.BackColor = colorEntry.Value[1];
            buoi = timeOfDay.Last(entry => now.Hour >= entry.Key).Value;

            label2.Text = $"Chào {buoi}, {DangNhap.thongTinHienTai.HoTen}.";
            label3.Text = "Hôm nay là " + now.ToString("dd/MM/yyyy, lúc HH:mm.");
            UpdateSunMoonLocation();
        }

        private Point GetDayLightCycleLocation(double rad, bool inverted = false)
        {
            double sub = inverted ? Math.PI : 0;
            return new Point(
                (int)((Math.Sin(rad - sub) + 1) / 2 * GetDayMoonLocationRange().Width),
                (int)((-Math.Cos(rad - sub) + 1) / 2 * GetDayMoonLocationRange().Height)
            );
        }

        public void OpenForm(Form form)
        {
            panel1.Hide();
            HideMenu(null, null);
            updateTimeTimer.Enabled = false;
            foreach (Form child in MdiChildren)
                foreach (string ten in new string[] { "MuaPizza", "MatKhau",
                    "CongThuc", "CongViec", "HoaDon", "KhachHang",
                    "NguyenLieu", "NhanVien", "Nhap", "Pizza",
                    "Quyen", "ThongBao"
                })
                    if (child.Name == ten && form.Name == ten)
                    {
                        child.Focus();
                        return;
                    }
            form.MdiParent = this;
            form.FormClosed += ChildForm_Closed;
            form.Show();
        }

        private void ChildForm_Closed(object sender, EventArgs e)
        {
            if (MdiChildren.Length >= 2) return; // Số lượng các MDI con trước khi tắt
            panel1.Show();
            updateTimeTimer.Enabled = true;
            timer1_Tick(null, null);
        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel) return; // Không bật thông báo khi người dùng không yêu cầu tắt form trong
            if (!CloseSilently && MessageBox.Show(
                "Bạn có muốn kết thúc phiên đăng nhập này không?",
                "Thoát phiên đăng nhập",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                if (DangNhap.thongTinHienTai != null)
                    DangXuat(CloseSilently);
            }
            catch (Exception exc)
            {
                if (CloseSilently) return;
                MessageBox.Show(
                    "Không thể đăng xuất tài khoản. Vui lòng thử lại sau.\n" + exc.Message,
                    "Không thể đăng xuất",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                e.Cancel = true;
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            int WM_KEYDOWN = 0x100, WM_KEYUP = 0x0101,
                WM_MOUSEMOVE = 0x0200,
                WM_LBUTTONDOWN = 0x0201, WM_LBUTTONUP = 0x0202,
                WM_RBUTTONDOWN = 0x0204, WM_RBUTTONUP = 0x0205,
                WM_MBUTTONDOWN = 0x0207, WM_MBUTTONUP = 0x0208,
                WM_XBUTTONDOWN = 0x020B, WM_XBUTTONUP = 0x020C;
            foreach (int wm in new int[] {
                    WM_KEYDOWN, WM_KEYUP,
                    WM_MOUSEMOVE,
                    WM_LBUTTONDOWN, WM_LBUTTONUP,
                    WM_RBUTTONDOWN, WM_RBUTTONUP,
                    WM_MBUTTONDOWN, WM_MBUTTONUP,
                    WM_XBUTTONDOWN, WM_XBUTTONUP
            })
                if (wm == m.Msg && afkTimer.Enabled) {
                    afkTimer.Stop();
                    break;
                }
            return false;
        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (!afkTimer.Enabled)
                afkTimer.Start();
        }

        private void afkTimer_Tick(object sender, EventArgs e)
        {
            CloseSilently = true;
            Close();
            CloseSilently = false;
            MessageBox.Show(
                "Đã hết phiên đăng nhập.\nVui lòng đăng nhập lại để tiếp tục sử dụng.",
                "Hết phiên đăng nhập"
            );
        }

        private void AddHideMenuOnClickRec(Control control)
        {
            control.Click += HideMenu;
            foreach (Control child in control.Controls)
                AddHideMenuOnClickRec(child);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            UpdateSunMoonLocation();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                HideMenu(null, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ToggleMenu(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;
        }

        private void HideMenu(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem node = e.ClickedItem;

            Form form = null;
            if (node == tsbMatKhau)
                form = new MatKhau();
            else if (node == tsbThoat)
                Close();
            else if (node == tsbCongViec)
                form = new CongViec();
            else if (node == tsbKhachHang)
                form = new KhachHang();
            else if (node == tsbNhanVien)
                form = new NhanVien();
            else if (node == tsbHoaDon)
                form = new HoaDon();
            else if (node == tsbNhap)
                form = new Nhap();
            else if (node == tsbQuyen)
                form = new Quyen();
            else if (node == tsbCongThuc)
                form = new CongThuc();
            else if (node == tsbCheBien)
                form = new CheBien();
            else if (node == tsbThongKe)
                form = new ThongKe();
            else if (node == tsbTraCuu)
                form = new TraCuu();
            else if (node == tsbMuaPizza)
                form = new MuaPizza();
            else if (node == tsbPizza)
                form = new Pizza();
            else if (node == tsbNguyenLieu)
                form = new NguyenLieu();

            if (form != null) OpenForm(form);
        }
    }
}
