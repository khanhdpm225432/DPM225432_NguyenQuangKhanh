using System;

namespace Memento.VietNam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            KhachHang k = new KhachHang();
            k.Ten = "Noel van Halen";
            k.SDT = "(412) 256-0990";
            k.NganSach = 25000.0;

            BoNho nho = new BoNho();
            nho.DuLieu = k.LuuTrangThai();

            k.Ten = "Leo Welch";
            k.SDT = "(310) 209-7111";
            k.NganSach = 1000000.0;

            k.KhoiPhuc(nho.DuLieu);

            Console.ReadKey();
        }
    }

    public class KhachHang
    {
        string ten;
        string sdt;
        double nganSach;

        public string Ten
        {
            get { return ten; }
            set
            {
                ten = value;
                Console.WriteLine("Tên: " + ten);
            }
        }

        public string SDT
        {
            get { return sdt; }
            set
            {
                sdt = value;
                Console.WriteLine("SĐT: " + sdt);
            }
        }

        public double NganSach
        {
            get { return nganSach; }
            set
            {
                nganSach = value;
                Console.WriteLine("Ngân sách: " + nganSach);
            }
        }

        public TrangThai LuuTrangThai()
        {
            Console.WriteLine("\nĐã lưu trạng thái\n");
            return new TrangThai(ten, sdt, nganSach);
        }

        public void KhoiPhuc(TrangThai t)
        {
            Console.WriteLine("\nKhôi phục trạng thái\n");
            Ten = t.Ten;
            SDT = t.SDT;
            NganSach = t.NganSach;
        }
    }

    public class TrangThai
    {
        public string Ten { get; set; }
        public string SDT { get; set; }
        public double NganSach { get; set; }

        public TrangThai(string ten, string sdt, double nganSach)
        {
            Ten = ten;
            SDT = sdt;
            NganSach = nganSach;
        }
    }

    public class BoNho
    {
        public TrangThai DuLieu { get; set; }
    }
}
