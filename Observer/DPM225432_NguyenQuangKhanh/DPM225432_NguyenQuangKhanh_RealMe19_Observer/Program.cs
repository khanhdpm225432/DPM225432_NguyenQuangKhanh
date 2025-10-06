using System;
using System.Collections.Generic;

namespace Observer.VietNam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChuDe cd = new ChuDe();

            cd.Gan(new NguoiXem(cd, "A"));
            cd.Gan(new NguoiXem(cd, "B"));
            cd.Gan(new NguoiXem(cd, "C"));

            cd.TrangThai = "ABC";
            cd.ThongBao();

            Console.ReadKey();
        }
    }

    public abstract class ChuDeCha
    {
        private List<NguoiTheoDoi> ds = new List<NguoiTheoDoi>();

        public void Gan(NguoiTheoDoi n)
        {
            ds.Add(n);
        }

        public void Bo(NguoiTheoDoi n)
        {
            ds.Remove(n);
        }

        public void ThongBao()
        {
            foreach (NguoiTheoDoi n in ds)
            {
                n.CapNhat();
            }
        }
    }

    public class ChuDe : ChuDeCha
    {
        public string TrangThai { get; set; }
    }

    public abstract class NguoiTheoDoi
    {
        public abstract void CapNhat();
    }

    public class NguoiXem : NguoiTheoDoi
    {
        string ten;
        string tt;
        ChuDe cd;

        public NguoiXem(ChuDe cd, string ten)
        {
            this.cd = cd;
            this.ten = ten;
        }

        public override void CapNhat()
        {
            tt = cd.TrangThai;
            Console.WriteLine("Người theo dõi {0} có trạng thái mới: {1}", ten, tt);
        }
    }
}
