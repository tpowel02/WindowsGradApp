using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradAppTracker
{
    class DB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();

            connString["Data Source"] = "TRENTDESKTOP\\CAPSTONE";
            connString["Initial Catalog"]= "TGA_Project";
            connString["User ID"] = "TGACAPSTONE";
            connString["Password"] = "Lockthedoors123";

            SqlConnection conn = new SqlConnection(connString.ToString());

            conn.Open();

            return conn;
        }

        public static DataTable GetUsers()
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[USERS] ");

            DataTable table = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), conn))
                    {
                        adapter.Fill(table);
                        conn.Close();
                    }
                }
            }
            return table;
        }
        public static DataTable GetUserByID(int userID)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[USERS] ");
            query.Append(String.Format("WHERE USER_ID = '{0}'", userID));


            DataTable table = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), conn))
                    {
                        adapter.Fill(table);
                        conn.Close();
                    }
                }
            }
            return table;
        }
        public static string CreateNewUser()
        {
            StringBuilder query = new StringBuilder();

            User user = new User();

            string resultString = "!";

            query.Append("FROM [TGA_Project].[dbo].[USERS] ");
            query.Append("[USER_ID],[FIRST_NAME],[LAST_NAME],[EMAIL],[PASSWORD],[POSITION_ID] ");
            query.Append(String.Format("VAUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}", user.UserID, user.FirstName, user.LastName, user.Email, user.Password, user.PositionID));

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    try
                    {
                        int result = command.ExecuteNonQuery();
                        if(result == 1)
                        {
                            resultString = "User" + user.FirstName + " " + user.LastName + " Created!";
                        }
                        else
                        {
                            resultString = "Error Creating User!";
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return resultString;
        }
        public static DataTable GetCurrentApplications()
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[GRAD_APP] ");
            //query.Append(String.Format("WHERE ACTIVE = {0}", 1));

            DataTable table = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), conn))
                    {
                        adapter.Fill(table);
                        conn.Close();
                    }
                }
            }
            return table;
        }
        public static DataTable GetPastApplications()
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[GRAD_APP] ");
            query.Append(String.Format("WHERE ACTIVE = {0}", 0));

            DataTable table = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), conn))
                    {
                        adapter.Fill(table);
                        conn.Close();
                    }
                }
            }
            return table;
        }

        public static int Login(string email, string password)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[USERS] ");
            query.Append(String.Format("WHERE email = '{0}' AND password = '{1}'", email, password));

            DataTable table = new DataTable();

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), conn))
                    {
                        adapter.Fill(table);
                        conn.Close();
                    }
                }
            }

            if (table.Rows.Count == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }


        public static int CreateGradApp()
        {
            return 1;
        }
    }
}
