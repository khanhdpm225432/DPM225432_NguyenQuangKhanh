using System;
using System.Collections.Generic;

namespace FlyweightDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string vanBan = "AAZZBBZB";
            char[] kyTuArray = vanBan.ToCharArray();

            NhaMayKyTu nhaMay = new NhaMayKyTu();
            int coChu = 10;

            foreach (char c in kyTuArray)
            {
                coChu++;
                KyTu kyTu = nhaMay.LayKyTu(c);
                kyTu.HienThi(coChu);
            }

            Console.ReadKey();
        }
    }

    public class NhaMayKyTu
    {
        private Dictionary<char, KyTu> danhSach = new Dictionary<char, KyTu>();

        public KyTu LayKyTu(char k)
        {
            KyTu kyTu = null;
            if (danhSach.ContainsKey(k))
            {
                kyTu = danhSach[k];
            }
            else
            {
                switch (k)
                {
                    case 'A': kyTu = new KyTuA(); break;
                    case 'B': kyTu = new KyTuB(); break;
                    case 'Z': kyTu = new KyTuZ(); break;
                }
                danhSach.Add(k, kyTu);
            }
            return kyTu;
        }
    }

    public abstract class KyTu
    {
        protected char bieuTuong;
        protected int rong;
        protected int cao;
        protected int len;
        protected int xuong;
        protected int coChu;

        public abstract void HienThi(int coChu);
    }

    public class KyTuA : KyTu
    {
        public KyTuA()
        {
            bieuTuong = 'A';
            cao = 100;
            rong = 120;
            len = 70;
            xuong = 0;
        }

        public override void HienThi(int coChu)
        {
            this.coChu = coChu;
            Console.WriteLine(bieuTuong + " (cỡ chữ " + this.coChu + ")");
        }
    }

    public class KyTuB : KyTu
    {
        public KyTuB()
        {
            bieuTuong = 'B';
            cao = 100;
            rong = 140;
            len = 72;
            xuong = 0;
        }

        public override void HienThi(int coChu)
        {
            this.coChu = coChu;
            Console.WriteLine(bieuTuong + " (cỡ chữ " + this.coChu + ")");
        }
    }

    public class KyTuZ : KyTu
    {
        public KyTuZ()
        {
            bieuTuong = 'Z';
            cao = 100;
            rong = 100;
            len = 68;
            xuong = 0;
        }

        public override void HienThi(int coChu)
        {
            this.coChu = coChu;
            Console.WriteLine(bieuTuong + " (cỡ chữ " + this.coChu + ")");
        }
    }
}
