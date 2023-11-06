using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sharplist
{
    public class DatabaseOperations : IDatabaseOperations
    {
        private readonly IDatabaseConnection _server;
        private string _query;

        public DatabaseOperations(IDatabaseConnection server)
        {
            _server = server;
        }
        public bool Login(string email, string password)
        {
            _query = "SELECT user_password FROM users WHERE user_email= @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(_query, connection);
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
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, reader["user_password"].ToString()))
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;
        }
        public Dictionary<string, dynamic> GetUserInfoByEmail(string email)
        {
            _query = "SELECT * FROM users WHERE user_email= @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(_query, connection);
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

            Dictionary<string, dynamic> user = new Dictionary<string, dynamic>();
            user.Add("user_email", email);
            user.Add("user_balance", reader["user_balance"]);
            user.Add("hasPlan", reader.GetSqlBoolean(4));
            user.Add("current_plan", reader["current_plan"]);
            if ((bool)reader["hasPlan"])
            {
                user.Add("plan_start_date", reader.GetDateTime(7));
            }
            user.Add("plan_end_date", reader.GetDateTime(8));
            reader.Close();
            connection.Close();
            return user;
        }
        public bool CheckIfUserExist(string email)
        {
            _query = "SELECT user_email FROM users WHERE user_email = @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;
        }
        public void Register(string email, string hashedPassword, decimal balance)
        {
            DateTime invalidEndDate = DateTime.Now.AddDays(-1);
            _query = "INSERT INTO users (user_email, user_password, user_balance, plan_end_date) VALUES (@user_email, @user_password, @user_balance, @plan_end_date)";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(_query, connection);
            cmd.Parameters.AddWithValue("@user_email", email);
            cmd.Parameters.AddWithValue("@user_password", hashedPassword);
            cmd.Parameters.AddWithValue("@user_balance", balance);
            cmd.Parameters.AddWithValue("@plan_end_date", invalidEndDate);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ResetOutdatedPlan(string email)
        {
            _query = "UPDATE users SET hasPlan = @hasPlan, current_plan = @current_plan, plan_start_date = @plan_start_date, plan_end_date = @plan_end_date  WHERE user_email = @user_email";
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@hasPlan",
                SqlDbType = SqlDbType.Bit,
                Value = 0,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@current_plan",
                SqlDbType = SqlDbType.VarChar,
                Value = DBNull.Value,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@plan_start_date",
                SqlDbType = SqlDbType.Date,
                Value = DBNull.Value,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@plan_end_date",
                SqlDbType = SqlDbType.Date,
                Value = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdatePlan(string plan, DateTime startDate, DateTime endDate, string email)
        {
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            _query = "UPDATE users SET hasPlan = @hasPlan, isFreeTrialUsed = @isFreeTrialUsed, current_plan = @current_plan, plan_start_date = @plan_start_date, plan_end_date = @plan_end_date  WHERE user_email= @user_email";
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@hasPlan",
                SqlDbType = SqlDbType.Bit,
                Value = 1,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@isFreeTrialUsed",
                SqlDbType = SqlDbType.Bit,
                Value = 1,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@current_plan",
                SqlDbType = SqlDbType.VarChar,
                Value = plan,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@plan_start_date",
                SqlDbType = SqlDbType.Date,
                Value = startDate.Date.ToString("yyyy-MM-dd"),
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@plan_end_date",
                SqlDbType = SqlDbType.Date,
                Value = endDate.Date.ToString("yyyy-MM-dd"),
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateBalance(decimal balance, string email)
        {
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            _query = "UPDATE users SET user_balance= @user_balance WHERE user_email= @user_email";
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_balance",
                SqlDbType = SqlDbType.Decimal,
                Value = balance,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public bool CheckIfFreeTrialUsed(string email)
        {
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            _query = "SELECT isFreeTrialUsed FROM users WHERE user_email = @user_email";
            SqlCommand cmd = new SqlCommand(_query, connection);
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
            if ((bool)reader["isFreeTrialUsed"])
            {
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
            return false;
        }
        public void DeleteWatchlist(string email)
        {
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            _query = "UPDATE users SET watchlist = @watchlist WHERE user_email = @user_email";
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@watchlist",
                SqlDbType = SqlDbType.VarChar,
                Value = DBNull.Value,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Watchlist has been deleted.");
            connection.Close();
        }
        public void ChangePassword(string email, string newPassword)
        {
            SqlConnection connection = (SqlConnection)_server.Connect();
            connection.Open();
            _query = "UPDATE users SET user_password = @user_password WHERE user_email = @user_email";
            SqlCommand cmd = new SqlCommand(_query, connection);
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_email",
                SqlDbType = SqlDbType.NVarChar,
                Value = email,
            });
            paramList.Add(new SqlParameter
            {
                ParameterName = "@user_password",
                SqlDbType = SqlDbType.Char,
                Value = newPassword,
            });
            cmd.Parameters.AddRange(paramList.ToArray());
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}