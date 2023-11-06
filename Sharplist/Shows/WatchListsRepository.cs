
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Sharplist.Shows
{
    public class WatchListsRepository : IWatchListsRepository
    {
        private readonly IDatabaseConnection _server;
        private readonly IShowsRegister _showsRegister;
        public WatchListsRepository(IShowsRegister showsRegister, IDatabaseConnection server)
        {
            _showsRegister = showsRegister;
            _server = server;
        }

        public IEnumerable<Show> Read(string email, List<Show> watchlist)
        {
            string query = "SELECT watchlist FROM users WHERE user_email = @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>
            {
                new SqlParameter
                {
                    ParameterName = "@user_email",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = email,
                }
            };
            cmd.Parameters.AddRange(paramList.ToArray());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            var watchlistAsString = reader["watchlist"].ToString().Split(',');

                foreach (var showId in watchlistAsString)
                {
                if (showId == "")
                {
                    reader.Close();
                    connection.Close();
                    return null;
                }
                int parsedShowId = int.Parse(showId);
                    var show = _showsRegister.GetById(parsedShowId);
                    watchlist.Add(show);
                }
            reader.Close();
            connection.Close();
            return watchlist.ToList();
        }

        public void Write(string email, List<string> watchlist)
        {
            string query = "UPDATE users SET watchlist = @watchlist WHERE user_email = @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });

            paramList.Add(new SqlParameter
            {
                ParameterName = "@watchlist",
                SqlDbType = SqlDbType.VarChar,
                Value = string.Join(",", watchlist),
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
