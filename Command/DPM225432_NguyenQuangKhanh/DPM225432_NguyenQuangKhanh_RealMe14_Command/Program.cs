using System;
using System.Collections.Generic;

namespace CommandDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NguoiDung user = new NguoiDung();

            user.TinhToan('+', 100);
            user.TinhToan('-', 50);
            user.TinhToan('*', 10);
            user.TinhToan('/', 2);

            user.Huy(4);
            user.LamLai(3);

            Console.ReadKey();
        }
    }

    public abstract class Lenh
    {
        public abstract void ThucThi();
        public abstract void HuyThucThi();
    }

    public class LenhMayTinh : Lenh
    {
        char phepToan;
        int soHang;
        MayTinh mayTinh;

        public LenhMayTinh(MayTinh mayTinh, char phepToan, int soHang)
        {
            this.mayTinh = mayTinh;
            this.phepToan = phepToan;
            this.soHang = soHang;
        }

        public override void ThucThi()
        {
            mayTinh.ThucHien(phepToan, soHang);
        }

        public override void HuyThucThi()
        {
            mayTinh.ThucHien(DaoNguoc(phepToan), soHang);
        }

        private char DaoNguoc(char pt)
        {
            switch (pt)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Phép toán không hợp lệ");
            }
        }
    }

    public class MayTinh
    {
        int giaTri = 0;

        public void ThucHien(char phepToan, int soHang)
        {
            switch (phepToan)
            {
                case '+': giaTri += soHang; break;
                case '-': giaTri -= soHang; break;
                case '*': giaTri *= soHang; break;
                case '/': giaTri /= soHang; break;
            }
            Console.WriteLine("Kết quả = {0,3} (sau khi {1} {2})", giaTri, phepToan, soHang);
        }
    }

    public class NguoiDung
    {
        MayTinh mayTinh = new MayTinh();
        List<Lenh> lichSu = new List<Lenh>();
        int hienTai = 0;

        public void TinhToan(char phepToan, int soHang)
        {
            Lenh lenh = new LenhMayTinh(mayTinh, phepToan, soHang);
            lenh.ThucThi();
            lichSu.Add(lenh);
            hienTai++;
        }

        public void Huy(int buoc)
        {
            Console.WriteLine("\n-- Hủy {0} bước --", buoc);
            for (int i = 0; i < buoc; i++)
            {
                if (hienTai > 0)
                {
                    Lenh lenh = lichSu[--hienTai];
                    lenh.HuyThucThi();
                }
            }
        }

        public void LamLai(int buoc)
        {
            Console.WriteLine("\n-- Làm lại {0} bước --", buoc);
            for (int i = 0; i < buoc; i++)
            {
                if (hienTai < lichSu.Count)
                {
                    Lenh lenh = lichSu[hienTai++];
                    lenh.ThucThi();
                }
            }
        }
    }
}

