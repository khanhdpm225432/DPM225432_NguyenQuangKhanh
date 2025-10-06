using System;
using System.Collections.Generic;

namespace MauThietKe.Builder.VietHoa
{
    /// <summary>
    /// Chương trình chính - Ví dụ Builder Pattern (Xây dựng phương tiện)
    /// </summary>
    public class ChuongTrinhChinh
    {
        public static void Main()
        {
            NguoiXayDungPhuongTien nguoiXayDung;

            // Tạo cửa hàng có các kiểu phương tiện khác nhau
            CuaHang cuaHang = new CuaHang();

            // Xây dựng và hiển thị các phương tiện

            nguoiXayDung = new XeMayBuilder();
            cuaHang.XayDung(nguoiXayDung);
            nguoiXayDung.PhuongTien.HienThi();

            nguoiXayDung = new OtoBuilder();
            cuaHang.XayDung(nguoiXayDung);
            nguoiXayDung.PhuongTien.HienThi();

            nguoiXayDung = new XeTayGaBuilder();
            cuaHang.XayDung(nguoiXayDung);
            nguoiXayDung.PhuongTien.HienThi();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Director - Cửa hàng
    /// </summary>
    class CuaHang
    {
        public void XayDung(NguoiXayDungPhuongTien builder)
        {
            builder.XayKhung();
            builder.XayDongCo();
            builder.XayBanhXe();
            builder.XayCua();
        }
    }

    /// <summary>
    /// Abstract Builder - Người xây dựng phương tiện
    /// </summary>
    abstract class NguoiXayDungPhuongTien
    {
        protected PhuongTien phuongTien;

        public PhuongTien PhuongTien
        {
            get { return phuongTien; }
        }

        public abstract void XayKhung();
        public abstract void XayDongCo();
        public abstract void XayBanhXe();
        public abstract void XayCua();
    }

    /// <summary>
    /// ConcreteBuilder1 - Xe Máy
    /// </summary>
    class XeMayBuilder : NguoiXayDungPhuongTien
    {
        public XeMayBuilder()
        {
            phuongTien = new PhuongTien("Xe Máy");
        }

        public override void XayKhung()
        {
            phuongTien["khung"] = "Khung xe máy";
        }

        public override void XayDongCo()
        {
            phuongTien["dongco"] = "500 cc";
        }

        public override void XayBanhXe()
        {
            phuongTien["banhxe"] = "2";
        }

        public override void XayCua()
        {
            phuongTien["cua"] = "0";
        }
    }

    /// <summary>
    /// ConcreteBuilder2 - Ô Tô
    /// </summary>
    class OtoBuilder : NguoiXayDungPhuongTien
    {
        public OtoBuilder()
        {
            phuongTien = new PhuongTien("Ô Tô");
        }

        public override void XayKhung()
        {
            phuongTien["khung"] = "Khung ô tô";
        }

        public override void XayDongCo()
        {
            phuongTien["dongco"] = "2500 cc";
        }

        public override void XayBanhXe()
        {
            phuongTien["banhxe"] = "4";
        }

        public override void XayCua()
        {
            phuongTien["cua"] = "4";
        }
    }

    /// <summary>
    /// ConcreteBuilder3 - Xe Tay Ga
    /// </summary>
    class XeTayGaBuilder : NguoiXayDungPhuongTien
    {
        public XeTayGaBuilder()
        {
            phuongTien = new PhuongTien("Xe Tay Ga");
        }

        public override void XayKhung()
        {
            phuongTien["khung"] = "Khung xe tay ga";
        }

        public override void XayDongCo()
        {
            phuongTien["dongco"] = "50 cc";
        }

        public override void XayBanhXe()
        {
            phuongTien["banhxe"] = "2";
        }

        public override void XayCua()
        {
            phuongTien["cua"] = "0";
        }
    }

    /// <summary>
    /// Product - Phương tiện
    /// </summary>
    class PhuongTien
    {
        private string _loaiPhuongTien;
        private Dictionary<string, string> _linhKien =
            new Dictionary<string, string>();

        public PhuongTien(string loai)
        {
            this._loaiPhuongTien = loai;
        }

        public string this[string key]
        {
            get { return _linhKien[key]; }
            set { _linhKien[key] = value; }
        }

        public void HienThi()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Loại phương tiện: {0}", _loaiPhuongTien);
            Console.WriteLine(" Khung   : {0}", _linhKien["khung"]);
            Console.WriteLine(" Động cơ : {0}", _linhKien["dongco"]);
            Console.WriteLine(" Bánh xe : {0}", _linhKien["banhxe"]);
            Console.WriteLine(" Cửa     : {0}", _linhKien["cua"]);
        }
    }
}
