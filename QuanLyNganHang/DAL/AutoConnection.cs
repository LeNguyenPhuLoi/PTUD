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
    public class AutoConnect
    {
        private readonly string connectionString;

        public AutoConnect()
        {
            //lấy tên máy
            string host = Dns.GetHostName();
            //danh sách các DataSource Name
            var instanceOptions = new List<string> { ".", host };

            //xử lý lấy instanceName trong sql server
            Microsoft.Win32.RegistryView registryView = Environment.Is64BitOperatingSystem ? Microsoft.Win32.RegistryView.Registry64 : Microsoft.Win32.RegistryView.Registry32;
            using (Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, registryView))
            {
                Microsoft.Win32.RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        //thêm DataSource Name vào danh sách
                        instanceOptions.Add(host + "\\" + instanceName);
                    }
                }
                //kiểm tra chuỗi kết nối cơ sở dữ liệu
                connectionString = instanceOptions
                    .Select(instance => $"Data Source={instance};Initial Catalog=QLNH;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2;")
                    .FirstOrDefault(TestConnection);
            }
        }

        //hàm trả về chuỗi kết nối
        public string GetConnection()
        {
            return connectionString;
        }

        //hàm kiểm tra kết nối
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
