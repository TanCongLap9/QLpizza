using System;
using System.Collections.Generic;

namespace QLpizza
{
    public class NguoiDungModel
    {
        public string MaND, HoTen, TenDangNhap, MatKhau, Email, SDT, GioiTinh, MaCongViec, MaQuyen;
        public bool TrangThaiDangNhap;
        public DateTime NgaySinh;
        public QuyenTruyCap Quyen = new QuyenTruyCap();
    }

    public class QuyenTruyCap
    {
        private Dictionary<string, int[]> cacQuyen = new Dictionary<string, int[]>();

        public int[] this[string v]
        {
            get {
                return cacQuyen.ContainsKey(v) ?
                    cacQuyen[v] :
                    new int[] { 0, 0 };
            }
            set { cacQuyen[v] = value; }
        }
    }
}
