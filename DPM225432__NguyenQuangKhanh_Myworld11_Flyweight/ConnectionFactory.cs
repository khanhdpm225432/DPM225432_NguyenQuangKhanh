using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225458_PhamHuuPhuoc_Myworld11_Flyweight
{
    public class ConnectionFactory
    {
        private readonly Dictionary<string, IDatabaseConnection> _connections = new();

        public IDatabaseConnection GetConnection(string dbType)
        {
            if (!_connections.ContainsKey(dbType))
            {
                IDatabaseConnection connection = dbType switch
                {
                    "SQL" => new SqlConnection(),
                    "MySQL" => new MySqlConnection(),
                    _ => throw new ArgumentException("Loại CSDL không hỗ trợ")
                };

                _connections[dbType] = connection;
            }

            return _connections[dbType];
        }
    }
}
