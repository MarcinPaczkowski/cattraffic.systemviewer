using System.Configuration;

namespace CatTraffic.SystemViewer.Common.Helpers
{
    public class ConnectionStringHelper
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