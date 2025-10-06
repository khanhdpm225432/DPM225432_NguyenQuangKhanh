using System;
using System.Collections.Generic;

namespace Interpreter.VietNam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string soLaMa = "MCMXXVIII";
            NgữCảnh ngữCảnh = new NgữCảnh(soLaMa);

            List<BiểuThức> cây = new List<BiểuThức>();
            cây.Add(new Ngàn());
            cây.Add(new Trăm());
            cây.Add(new Chục());
            cây.Add(new ĐơnVị());

            foreach (BiểuThức bt in cây)
            {
                bt.DiễnGiải(ngữCảnh);
            }

            Console.WriteLine("{0} = {1}", soLaMa, ngữCảnh.KếtQuả);
            Console.ReadKey();
        }
    }

    public class NgữCảnh
    {
        public string ĐầuVào { get; set; }
        public int KếtQuả { get; set; }

        public NgữCảnh(string đầuVào)
        {
            ĐầuVào = đầuVào;
            KếtQuả = 0;
        }
    }

    public abstract class BiểuThức
    {
        public void DiễnGiải(NgữCảnh ngữCảnh)
        {
            if (ngữCảnh.ĐầuVào.Length == 0) return;

            if (ngữCảnh.ĐầuVào.StartsWith(Chín()))
            {
                ngữCảnh.KếtQuả += 9 * HệSố();
                ngữCảnh.ĐầuVào = ngữCảnh.ĐầuVào.Substring(2);
            }
            else if (ngữCảnh.ĐầuVào.StartsWith(Bốn()))
            {
                ngữCảnh.KếtQuả += 4 * HệSố();
                ngữCảnh.ĐầuVào = ngữCảnh.ĐầuVào.Substring(2);
            }
            else if (ngữCảnh.ĐầuVào.StartsWith(Năm()))
            {
                ngữCảnh.KếtQuả += 5 * HệSố();
                ngữCảnh.ĐầuVào = ngữCảnh.ĐầuVào.Substring(1);
            }

            while (ngữCảnh.ĐầuVào.StartsWith(Một()))
            {
                ngữCảnh.KếtQuả += 1 * HệSố();
                ngữCảnh.ĐầuVào = ngữCảnh.ĐầuVào.Substring(1);
            }
        }

        public abstract string Một();
        public abstract string Bốn();
        public abstract string Năm();
        public abstract string Chín();
        public abstract int HệSố();
    }

    public class Ngàn : BiểuThức
    {
        public override string Một() { return "M"; }
        public override string Bốn() { return ""; }
        public override string Năm() { return ""; }
        public override string Chín() { return ""; }
        public override int HệSố() { return 1000; }
    }

    public class Trăm : BiểuThức
    {
        public override string Một() { return "C"; }
        public override string Bốn() { return "CD"; }
        public override string Năm() { return "D"; }
        public override string Chín() { return "CM"; }
        public override int HệSố() { return 100; }
    }

    public class Chục : BiểuThức
    {
        public override string Một() { return "X"; }
        public override string Bốn() { return "XL"; }
        public override string Năm() { return "L"; }
        public override string Chín() { return "XC"; }
        public override int HệSố() { return 10; }
    }

    public class ĐơnVị : BiểuThức
    {
        public override string Một() { return "I"; }
        public override string Bốn() { return "IV"; }
        public override string Năm() { return "V"; }
        public override string Chín() { return "IX"; }
        public override int HệSố() { return 1; }
    }
}
