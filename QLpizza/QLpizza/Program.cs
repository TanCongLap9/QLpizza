using System;
using System.Windows.Forms;

namespace QLpizza
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new DangNhap());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs exc)
        {
            try
            {
                FormChinh.DangXuat(true);
            }
            catch
            {

            }
            FormChinh.CloseSilently = true;
            Console.WriteLine(exc.Exception.StackTrace);
            MessageBox.Show(
                $@"Có lỗi nghiêm trọng xảy ra trong quá trình chạy.
Chương trình sẽ tắt. Vui lòng chạy và đăng nhập lại để tiếp tục.

Thông tin về lỗi:
{(exc.Exception.InnerException != null ? exc.Exception.InnerException.Message : exc.Exception.Message)}

Ngăn xếp:
{(exc.Exception.InnerException != null ? exc.Exception.InnerException.StackTrace : exc.Exception.StackTrace)}

Xin hãy báo cáo lỗi này cho nhóm phát triển bằng cách liên hệ với chúng tôi tại trang web https://baoloi.blablabla.com
Chúng tôi chân thành xin lỗi vì sự cố này!", "LỖI NGHIÊM TRỌNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}