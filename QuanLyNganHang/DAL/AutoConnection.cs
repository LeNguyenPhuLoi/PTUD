using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AutoConnection
    {
        private readonly string connectionString;

        public AutoConnection()
        {
            string host = Dns.GetHostName();

            // 🔹 Lấy tất cả instance SQL có sẵn trên máy
            var table = SqlDataSourceEnumerator.Instance.GetDataSources();
            var instanceOptions = table.Rows
                .Cast<System.Data.DataRow>()
                .Where(row => row["ServerName"].ToString().Equals(host, StringComparison.OrdinalIgnoreCase))
                .Select(row =>
                {
                    string instanceName = row["InstanceName"].ToString();
                    return string.IsNullOrEmpty(instanceName) ? host : $"{host}\\{instanceName}";
                })
                .ToList();

            // 🔹 Nếu không quét được instance nào, thêm các tên phổ biến
            if (instanceOptions.Count == 0)
            {
                instanceOptions.AddRange(new[]
                {
                host,
                host + "\\SQLEXPRESS",
                host + "\\SQLEXPRESS01",
                host + "\\MSSQLSERVER"
            });
            }

            connectionString = instanceOptions
                .Select(instance => $"Data Source={instance};Initial Catalog=QLNH;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2;")
                .FirstOrDefault(TestConnection);

            if (connectionString == null)
            {
                throw new Exception("Không thể kết nối đến SQL Server!");
            }
        }

        public string GetConnection()
        {
            return connectionString;
        }

        private bool TestConnection(string connStr)
        {
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
