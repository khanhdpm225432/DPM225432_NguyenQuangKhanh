using System;
using System.Collections.Generic;

namespace DPM225458_PhamHuuPhuoc_Myworld11_Flyweight
{ 
class Program
{
    static void Main()
    {
        var factory = new ConnectionFactory();

        // Các phiên sử dụng kết nối
        string[] sessions = { "Session-1", "Session-2", "Session-3" };

        // Phiên 1 và 2 dùng SQL, phiên 3 dùng MySQL
        var conn1 = factory.GetConnection("SQL");
        conn1.Connect(sessions[0]);

        var conn2 = factory.GetConnection("SQL");
        conn2.Connect(sessions[1]);

        var conn3 = factory.GetConnection("MySQL");
        conn3.Connect(sessions[2]);

        // Kiểm tra: conn1 và conn2 có cùng tham chiếu không?
        Console.WriteLine($"\nconn1 và conn2 có cùng đối tượng? {(object.ReferenceEquals(conn1, conn2) ? "Có" : "Không")}");

        Console.ReadKey();
    }
}
}