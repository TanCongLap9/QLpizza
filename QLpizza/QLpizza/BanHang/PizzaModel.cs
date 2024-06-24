using System.Drawing;

namespace QLpizza.BanHang
{
    public class PizzaModel
    {
        public string MaPizza, TenPizza, MaLoai, MaCongThuc, FileHinh;
        public int GiaVon, GiaBan, SoLuong;

        public PizzaModel Clone()
        {
            return new PizzaModel()
            {
                MaPizza = MaPizza,
                TenPizza = TenPizza,
                MaLoai = MaLoai,
                MaCongThuc = MaCongThuc,
                FileHinh = FileHinh,
                GiaVon = GiaVon,
                GiaBan = GiaBan,
                SoLuong = SoLuong
            };
        }
    }
}
