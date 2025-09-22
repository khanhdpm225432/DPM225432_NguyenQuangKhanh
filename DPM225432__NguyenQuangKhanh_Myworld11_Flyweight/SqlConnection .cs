using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225458_PhamHuuPhuoc_Myworld11_Flyweight
{
    public class SqlConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public SqlConnection()
        {
            // Giả lập việc tạo chuỗi kết nối
            _connectionString = "Server=sql.example.com;Database=MainDB;";
            Console.WriteLine("[Tạo mới kết nối SQL Server]");
        }

        public void Connect(string session)
        {
            Console.WriteLine($"[SQL Server] Kết nối từ phiên: {session} với chuỗi: {_connectionString}");
        }
    }
}