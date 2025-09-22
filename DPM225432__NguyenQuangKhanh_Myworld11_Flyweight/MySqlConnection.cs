using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225458_PhamHuuPhuoc_Myworld11_Flyweight
{
    public class MySqlConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public MySqlConnection()
        {
            _connectionString = "Server=mysql.example.com;Database=MainDB;";
            Console.WriteLine("[Tạo mới kết nối MySQL]");
        }

        public void Connect(string session)
        {
            Console.WriteLine($"[MySQL] Kết nối từ phiên: {session} với chuỗi: {_connectionString}");
        }
    }
}
