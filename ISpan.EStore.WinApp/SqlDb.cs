using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.WinApp
{
    public class SqlDb
    {
        public static string ApplicationName { get; set; }
        public static int ConnectionTimeout { get; set; } //def = 0
        public static bool? Pooling { get; set; }
        public static string GetConnectionString(string keyOfConnString)
        {

            var node = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString];

            if (node == null) throw new Exception($"找不到節點{keyOfConnString}");

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ToString();

            var sb = new SqlConnectionStringBuilder(connStr);
            if (string.IsNullOrEmpty(ApplicationName) == false) sb.ApplicationName = ApplicationName;
            if (ConnectionTimeout < 0) sb.ConnectTimeout = ConnectionTimeout;//預設是15秒
            if (Pooling.HasValue) sb.Pooling = Pooling.Value;//預設是true表示要不要用連線池

            //sb.ApplicationName = "winDemo";
            //sb.ConnectTimeout = 30;
            //sb.Pooling = false;

            return sb.ToString();
        }

        public static SqlConnection GetConnection(string keyOfConnString = "default")
        {
            string connStr = GetConnectionString(keyOfConnString);
            return new SqlConnection(connStr); //建立一個SqlConnection物件並回傳
        }
    }
}
