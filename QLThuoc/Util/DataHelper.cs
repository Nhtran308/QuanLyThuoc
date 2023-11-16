using System.Data.SqlClient;

namespace QLThuoc.Util
{
    internal class DataHelper
    {
        public static String server;
        public static String data;
        public static String uid;
        public static String password;

        public static SqlConnection getConnection()
        {
            String connect = "Server = " + server + "; Initial Catalog = " + data + "; UID = " + uid + "; Password = " + password;
            return new SqlConnection(connect);
        }
    }
}
