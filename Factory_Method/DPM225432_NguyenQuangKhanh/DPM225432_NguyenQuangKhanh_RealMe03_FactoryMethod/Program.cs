using System;
using System.Collections.Generic;

namespace MauThietKe.FactoryMethod.VietHoa
{

    class ChuongTrinhChinh
    {
        static void Main()
        {
            // Tạo mảng tài liệu
            TaiLieu[] danhSachTaiLieu = new TaiLieu[2];

            danhSachTaiLieu[0] = new SoYeuLyLich();
            danhSachTaiLieu[1] = new BaoCao();

            // Hiển thị danh sách trang của từng tài liệu
            foreach (TaiLieu tl in danhSachTaiLieu)
            {
                Console.WriteLine("\n" + tl.GetType().Name + " --");
                foreach (Trang t in tl.CacTrang)
                {
                    Console.WriteLine(" " + t.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Product trừu tượng - Trang
    /// </summary>
    abstract class Trang
    {
    }

    // Các Product cụ thể
    class TrangKyNang : Trang { }
    class TrangHocVan : Trang { }
    class TrangKinhNghiem : Trang { }
    class TrangMoDau : Trang { }
    class TrangKetQua : Trang { }
    class TrangKetLuan : Trang { }
    class TrangTomTat : Trang { }
    class TrangTaiLieuThamKhao : Trang { }

    /// <summary>
    /// Creator trừu tượng - Tài liệu
    /// </summary>
    abstract class TaiLieu
    {
        private List<Trang> _cacTrang = new List<Trang>();

        public TaiLieu()
        {
            this.TaoTrang();
        }

        public List<Trang> CacTrang
        {
            get { return _cacTrang; }
        }

        // Factory Method
        public abstract void TaoTrang();
    }

    /// <summary>
    /// ConcreteCreator - Sơ yếu lý lịch
    /// </summary>
    class SoYeuLyLich : TaiLieu
    {
        public override void TaoTrang()
        {
            CacTrang.Add(new TrangKyNang());
            CacTrang.Add(new TrangHocVan());
            CacTrang.Add(new TrangKinhNghiem());
        }
    }

    /// <summary>
    /// ConcreteCreator - Báo cáo
    /// </summary>
    class BaoCao : TaiLieu
    {
        public override void TaoTrang()
        {
            CacTrang.Add(new TrangMoDau());
            CacTrang.Add(new TrangKetQua());
            CacTrang.Add(new TrangKetLuan());
            CacTrang.Add(new TrangTomTat());
            CacTrang.Add(new TrangTaiLieuThamKhao());
        }
    }
}
