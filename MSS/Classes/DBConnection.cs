using System.Configuration;
using System.Data.SqlClient;

namespace MSS
{
    class DBConnection
    {
        public static SqlConnection cn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlCommand cmd1 = new SqlCommand();

        public static SqlDataReader dr;
    }
}
