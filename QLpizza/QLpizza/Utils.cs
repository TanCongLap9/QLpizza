using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QLpizza
{
    public static class Validator
    {

        public static string Email(string email)
        {
            return new Regex(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*(?:\.[a-z]{2,3})$").IsMatch(email) ?
                null :
                "Email không đúng dạng.";
        }

        public static string Sdt(string sdt)
        {
            return new Regex(@"^0\d{8,10}$").IsMatch(sdt) ?
                null :
                "Vui lòng nhập đúng dạng với từ 9 tới 11 chữ số.";
        }

        public static string MatKhau(string matKhau)
        {
            return matKhau.Length > 5 &&
                new Regex("[a-z]").IsMatch(matKhau) &&
                new Regex("[A-Z]").IsMatch(matKhau) &&
                new Regex("[0-9]").IsMatch(matKhau) ?
                null :
                "Mật khẩu phải hơn 5 ký tự với chữ thường, chữ hoa và cả chữ số.";
        }

        public static string TaiKhoan(DataTable bang, string taiKhoan)
        {
            foreach (DataRow row in bang.Rows)
                if (row.Field<string>("TenDangNhap") == taiKhoan)
                    return "Tài khoản này đã được sử dụng. Vui lòng nhập tài khoản khác.";
            return null;
        }

        public static string Id(DataTable bang, string idFieldName, string id)
        {
            foreach (DataRow row in bang.Rows)
                if (row.Field<string>(idFieldName) == id)
                    return "Mã bị trùng. Vui lòng nhập mã khác.";
            return null;
        }
    }

    public static class SqlUtils
    {
        public static readonly SqlConnection Conn = new SqlConnection("Data Source=localhost; Initial Catalog=PIZZA; Integrated Security=True");

        public static void BuildConnection(string dataSource, int mode, string userId, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.MultipleActiveResultSets = true;
            builder.InitialCatalog = "PIZZA";
            if (mode != 0)
            {
                builder.UserID = userId;
                builder.Password = password;
            }
            else
                builder.IntegratedSecurity = true;
            Conn.ConnectionString = builder.ConnectionString;
        }

        #region Sync functions

        public static SqlConnection Open()
        {
            if (Conn.State != ConnectionState.Open) Conn.Open();
            return Conn;
        }

        public static object ExecuteScalar(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text)
        {
            Open();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
                    return comm.ExecuteScalar();
            }
            finally
            {
                //Conn.Close();
            }
        }

        public static int ExecuteNonQuery(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text,
            SqlTransaction transaction = null)
        {
            Open();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType, transaction))
                    return comm.ExecuteNonQuery();
            }
            finally
            {
                /*if (transaction == null)
                    Conn.Close();*/
            }
        }

        public static DataTable Query(
            string commStr,
            Dictionary<string, object> parameters = null,
            DataTable table = null,
            CommandType commandType = CommandType.Text)
        {
            Open();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
                {
                    if (table == null)
                        table = new DataTable();
                    else
                    {
                        table.Clear();
                        table.Columns.Clear();
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comm))
                        adapter.Fill(table);
                    return table;
                }
            }
            finally
            {
                //Conn.Close();
            }
        }

        public static SqlDataReader ExecuteReader(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text)
        {
            Open();
            using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
                return comm.ExecuteReader();
        }

        public static SqlDataAdapter GetDataAdpater(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text,
            bool inferCommands = true)
        {
            SqlCommand comm = GetCommand(commStr, parameters, commandType);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            if (inferCommands)
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                /*adapter.UpdateCommand = */builder.GetUpdateCommand();
                /*adapter.InsertCommand = */builder.GetInsertCommand();
                /*adapter.DeleteCommand = */builder.GetDeleteCommand();
            }
            return adapter;
        }

        public static SqlCommand GetCommand(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text,
            SqlTransaction transaction = null)
        {
            SqlCommand comm = new SqlCommand(commStr, Conn, transaction)
            {
                CommandType = commandType
            };
            if (parameters != null)
                foreach (KeyValuePair<string, object> param in parameters)
                    comm.Parameters.AddWithValue(param.Key, param.Value);
            return comm;
        }

        #endregion
        #region Async functions

        public static async Task<SqlConnection> OpenAsync()
        {
            if (Conn.State != ConnectionState.Open) await Conn.OpenAsync();
            return Conn;
        }

        public static async Task<int> ExecuteNonQueryAsync(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text,
            SqlTransaction transaction = null)
        {
            await OpenAsync();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType, transaction))
                    return await comm.ExecuteNonQueryAsync();
            }
            finally
            {
                /*if (transaction == null)
                    Conn.Close();*/
            }
        }

        public static async Task<SqlDataReader> ExecuteReaderAsync(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text)
        {
            await OpenAsync();
            using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
            {
                SqlDataReader reader = await comm.ExecuteReaderAsync();
                return reader;
            }
        }

        public static async Task<object> ExecuteScalarAsync(
            string commStr,
            Dictionary<string, object> parameters = null,
            CommandType commandType = CommandType.Text)
        {
            await OpenAsync();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
                    return await comm.ExecuteScalarAsync();
            }
            finally
            {
                //Conn.Close();
            }
        }

        public static async Task<DataTable> QueryAsync(
            string commStr,
            Dictionary<string, object> parameters = null,
            DataTable table = null,
            CommandType commandType = CommandType.Text)
        {
            await OpenAsync();
            try
            {
                using (SqlCommand comm = GetCommand(commStr, parameters, commandType))
                {
                    if (table == null) table = new DataTable();
                    else
                    {
                        table.Clear();
                        table.Columns.Clear();
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comm))
                    {
                        await Task.Run(() => adapter.Fill(table));
                        return table;
                    }
                }
            }
            finally
            {
                //Conn.Close();
            }
        }

        #endregion
    }

    public static class PasswordEncoder
    {
        public const string SALT = "g(<}M(`O'#1q_X?lPMZ%06$NLf?Mf7eSf?vOc{Mk}?8H-/$Z%@2YZ[(aZ.O;`*iT";
        public static string Encode(string id, string password)
        {
            SHA256 sh2 = SHA256.Create();
            return string.Join("", sh2.ComputeHash(Encoding.UTF8.GetBytes(id + SALT + password))
                .Select(b => b.ToString("x2")));
        }
    }

    public static class SearchUtils
    {
        public static string ToSearchString(string value)
        {
            return new Regex(@"[\u0300-\u036F]").Replace(value.ToLower().Normalize(NormalizationForm.FormD).Replace("đ", "d"), "");
        }

        public static bool Contains(string searchValue, string currentValue)
        {
            return ToSearchString(currentValue).Contains(ToSearchString(searchValue));
        }
    }

    public static class MaGenerator
    {
        public static char[]
            chuCaiVaChuSo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray(),
            chuSo = "0123456789".ToCharArray(),
            chuCai = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static Random random = new Random();

        public static string ChuoiNgauNhien(char[] cacKyTu, int doDai)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < doDai; i++)
                sb.Append(cacKyTu[random.Next(cacKyTu.Length)]);
            return sb.ToString();
        }

        public static async Task<string> Ma(string tenMa)
        {
            switch (tenMa)
            {
                case "MaND":
                    return await MaND();
                case "MaHoaDon":
                    return await MaHoaDon();
                case "MaCongViec":
                    return await MaCongViec();
                case "MaCongThuc":
                    return await MaCongThuc();
                case "MaNhap":
                    return await MaNhap();
                case "MaNL":
                    return await MaNL();
                case "MaLoai":
                    return await MaLoai();
                case "MaPizza":
                    return await MaPizza();
                case "MaQuyen":
                    return await MaQuyen();
                case "MaCheBien":
                    return await MaCheBien();
                case "Pin":
                    return Pin();
                default:
                    return string.Empty;
            }
        }

        public static async Task<string> MaCongViec()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaCongViec FROM CONGVIEC");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCai, 2) + ChuoiNgauNhien(chuSo, 2) + "V",
                bang.Select()
                    .Select(hang => hang.Field<string>("MaCongViec"))
                    .ToArray()
            );
        }

        public static async Task<string> MaND()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaND FROM NGUOIDUNG");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCaiVaChuSo, 4) + "K",
                bang.Select()
                    .Select(hang => hang.Field<string>("MaND"))
                    .ToArray()
            );
        }

        public static async Task<string> MaCongThuc()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaCongThuc FROM CONGTHUC");
            return await TaoMaKhongXungDot(
                () => "CT" + ChuoiNgauNhien(chuSo, 3),
                bang.Select()
                    .Select(hang => hang.Field<string>("MaCongThuc"))
                    .ToArray()
            );
        }

        public static async Task<string> MaHoaDon()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaHoaDon FROM HOADON");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCaiVaChuSo, 8) + "H",
                bang.Select()
                    .Select(hang => hang.Field<string>("MaHoaDon"))
                    .ToArray()
            );
        }

        public static async Task<string> MaNhap()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaNhap FROM NHAP");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCaiVaChuSo, 4) + "O",
                bang.Select()
                    .Select(hang => hang.Field<string>("MaNhap"))
                    .ToArray()
            );
        }

        public static async Task<string> MaNL()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaNL FROM NGUYENLIEU");
            return await TaoMaKhongXungDot(
                () => "NL" + ChuoiNgauNhien(chuSo, 3),
                bang.Select()
                    .Select(hang => hang.Field<string>("MaNL"))
                    .ToArray()
            );
        }

        public static async Task<string> MaLoai()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaLoai FROM LOAIPIZZA");
            return await TaoMaKhongXungDot(
                () => "LP" + ChuoiNgauNhien(chuSo, 3),
                bang.Select()
                    .Select(hang => hang.Field<string>("MaLoai"))
                    .ToArray()
            );
        }

        public static async Task<string> MaPizza()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaPizza FROM PIZZA");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCaiVaChuSo, 4) + "P",
                bang.Select()
                    .Select(hang => hang.Field<string>("MaPizza"))
                    .ToArray()
            );
        }

        public static async Task<string> MaQuyen()
        {
            DataTable bang = await SqlUtils.QueryAsync("SELECT MaQuyen FROM QUYENHAN");
            return await TaoMaKhongXungDot(
                () => "QH" + ChuoiNgauNhien(chuSo, 3),
                bang.Select()
                    .Select(hang => hang.Field<string>("MaQuyen"))
                    .ToArray()
            );
        }

        public static async Task<string> MaCheBien()
        {
            DataTable table = await SqlUtils.QueryAsync("SELECT MaCheBien FROM CHEBIEN");
            return await TaoMaKhongXungDot(
                () => ChuoiNgauNhien(chuCaiVaChuSo, 8) + "B",
                table.Select()
                    .Select(row => row.Field<string>("MaCheBien"))
                    .ToArray()
            );
        }

        public static string Pin()
        {
            return TaoMa(() => ChuoiNgauNhien(chuSo, 6));
        }
        
        public static string TaoMa(Func<string> hamTao)
        {
            return hamTao.Invoke();
        }

        public static async Task<string> TaoMaKhongXungDot(Func<string> hamTao, ICollection<string> ngoaiTru = null)
        {
            string result = "";
            await Task.Run(() =>
            {
                do { result = hamTao.Invoke(); }
                while (ngoaiTru != null && ngoaiTru.Contains(result));
            });
            return result;
        }
    }
}
