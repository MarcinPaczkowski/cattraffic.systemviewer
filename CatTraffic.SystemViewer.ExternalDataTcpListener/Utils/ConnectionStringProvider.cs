using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Utils
{
    public class ConnectionStringProvider
    {
        private static string _connectionString;

        public static void SetConnectionString(string connectionStringName = "CatTrafficConnection")
        {
            _connectionString = ConfigurationManager.ConnectionStrings["CatTrafficConnection"].ConnectionString;
        }

        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(_connectionString))
                SetConnectionString();
            return _connectionString;
        }
    }
}
