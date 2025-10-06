using System;

namespace ProxyDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MayTinhProxy mayTinh = new MayTinhProxy();

            Console.WriteLine("4 + 2 = " + mayTinh.Cong(4, 4));
            Console.WriteLine("4 - 2 = " + mayTinh.Tru(4, 4));
            Console.WriteLine("4 * 2 = " + mayTinh.Nhan(4, 4));
            Console.WriteLine("4 / 2 = " + mayTinh.Chia(4, 4));

            Console.ReadKey();
        }
    }

    public interface IMayTinh
    {
        double Cong(double a, double b);
        double Tru(double a, double b);
        double Nhan(double a, double b);
        double Chia(double a, double b);
    }

    public class MayTinh : IMayTinh
    {
        public double Cong(double a, double b) { return a + b; }
        public double Tru(double a, double b) { return a - b; }
        public double Nhan(double a, double b) { return a * b; }
        public double Chia(double a, double b) { return a / b; }
    }

    public class MayTinhProxy : IMayTinh
    {
        private MayTinh mayTinh = new MayTinh();

        public double Cong(double a, double b) { return mayTinh.Cong(a, b); }
        public double Tru(double a, double b) { return mayTinh.Tru(a, b); }
        public double Nhan(double a, double b) { return mayTinh.Nhan(a, b); }
        public double Chia(double a, double b) { return mayTinh.Chia(a, b); }
    }
}
