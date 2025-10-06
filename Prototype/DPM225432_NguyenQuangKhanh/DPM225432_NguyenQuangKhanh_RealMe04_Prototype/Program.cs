using System;
using System.Collections.Generic;

namespace MauThietKe.Prototype.RealMe
{

    public class ChuongTrinh
    {
        public static void Main(string[] args)
        {
            QuanLyMau quanLyMau = new QuanLyMau();

            // Khởi tạo với các màu chuẩn
            quanLyMau["do"] = new Mau(255, 0, 0);
            quanLyMau["xanh_la"] = new Mau(0, 255, 0);
            quanLyMau["xanh_duong"] = new Mau(0, 0, 255);

            // Người dùng thêm màu cá nhân hóa
            quanLyMau["tuc_gian"] = new Mau(255, 54, 0);
            quanLyMau["binh_yen"] = new Mau(128, 211, 128);
            quanLyMau["lua_chay"] = new Mau(211, 34, 20);

            // Người dùng clone các màu được chọn
            Mau mau1 = quanLyMau["do"].NhanBan() as Mau;
            Mau mau2 = quanLyMau["binh_yen"].NhanBan() as Mau;
            Mau mau3 = quanLyMau["lua_chay"].NhanBan() as Mau;

            Console.ReadKey();
        }
    }


    public abstract class MauPrototype
    {
        public abstract MauPrototype NhanBan();
    }

 
    public class Mau : MauPrototype
    {
        int doR;
        int xanhL;
        int xanhD;

        public Mau(int r, int g, int b)
        {
            this.doR = r;
            this.xanhL = g;
            this.xanhD = b;
        }

        // Tạo bản sao nông (shallow copy)
        public override MauPrototype NhanBan()
        {
            Console.WriteLine(
                "Đang nhân bản màu RGB: {0,3}, {1,3}, {2,3}",
                doR, xanhL, xanhD);

            return this.MemberwiseClone() as MauPrototype;
        }
    }

    public class QuanLyMau
    {
        private Dictionary<string, MauPrototype> dsMau =
            new Dictionary<string, MauPrototype>();

        // Indexer
        public MauPrototype this[string key]
        {
            get { return dsMau[key]; }
            set { dsMau.Add(key, value); }
        }
    }
}
