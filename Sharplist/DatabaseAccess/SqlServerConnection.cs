using System.Data;
using System.Data.SqlClient;

namespace Sharplist
{
    public class SqlServerConnection :IDatabaseConnection
    {
        const string connectionString = "your_connection_string";
        public SqlConnection Connection = new SqlConnection(connectionString);
        public string Query;
        public SqlCommand Cmd;
        public SqlDataReader Reader;
        public IDbConnection Connect()
        {
            return Connection;
        }
    }
}