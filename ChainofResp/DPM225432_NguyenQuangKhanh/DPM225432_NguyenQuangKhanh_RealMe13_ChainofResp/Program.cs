using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225512_VoKhoaNguyen_RealMe13_ChainofResp
{
    using System;

    namespace ChainDemo
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                NguoiDuyet truongPhong = new TruongPhong();
                NguoiDuyet phoGiamDoc = new PhoGiamDoc();
                NguoiDuyet giamDoc = new GiamDoc();

                truongPhong.ThietLapNguoiKeTiep(phoGiamDoc);
                phoGiamDoc.ThietLapNguoiKeTiep(giamDoc);

                YeuCauMuaHang yc1 = new YeuCauMuaHang(2034, 350.00, "Văn phòng phẩm");
                truongPhong.XuLyYeuCau(yc1);

                YeuCauMuaHang yc2 = new YeuCauMuaHang(2035, 32590.10, "Dự án X");
                truongPhong.XuLyYeuCau(yc2);

                YeuCauMuaHang yc3 = new YeuCauMuaHang(2036, 122100.00, "Dự án Y");
                truongPhong.XuLyYeuCau(yc3);

                Console.ReadKey();
            }
        }

        public abstract class NguoiDuyet
        {
            protected NguoiDuyet keTiep;

            public void ThietLapNguoiKeTiep(NguoiDuyet keTiep)
            {
                this.keTiep = keTiep;
            }

            public abstract void XuLyYeuCau(YeuCauMuaHang yeuCau);
        }

        public class TruongPhong : NguoiDuyet
        {
            public override void XuLyYeuCau(YeuCauMuaHang yeuCau)
            {
                if (yeuCau.SoTien < 10000.0)
                {
                    Console.WriteLine("Trưởng phòng duyệt yêu cầu #{0}", yeuCau.MaSo);
                }
                else if (keTiep != null)
                {
                    keTiep.XuLyYeuCau(yeuCau);
                }
            }
        }

        public class PhoGiamDoc : NguoiDuyet
        {
            public override void XuLyYeuCau(YeuCauMuaHang yeuCau)
            {
                if (yeuCau.SoTien < 25000.0)
                {
                    Console.WriteLine("Phó giám đốc duyệt yêu cầu #{0}", yeuCau.MaSo);
                }
                else if (keTiep != null)
                {
                    keTiep.XuLyYeuCau(yeuCau);
                }
            }
        }

        public class GiamDoc : NguoiDuyet
        {
            public override void XuLyYeuCau(YeuCauMuaHang yeuCau)
            {
                if (yeuCau.SoTien < 100000.0)
                {
                    Console.WriteLine("Giám đốc duyệt yêu cầu #{0}", yeuCau.MaSo);
                }
                else
                {
                    Console.WriteLine("Yêu cầu #{0} cần họp ban giám đốc!", yeuCau.MaSo);
                }
            }
        }

        public class YeuCauMuaHang
        {
            public int MaSo { get; set; }
            public double SoTien { get; set; }
            public string LyDo { get; set; }

            public YeuCauMuaHang(int maSo, double soTien, string lyDo)
            {
                MaSo = maSo;
                SoTien = soTien;
                LyDo = lyDo;
            }
        }
    }
}
