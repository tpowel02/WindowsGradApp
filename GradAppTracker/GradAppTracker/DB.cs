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

            connString["Data Source"] = "74.117.171.101,1433";
            connString["Initial Catalog"]= "TGA_Project";
            connString["User ID"] = "TGACAPSTONE";
            connString["Password"] = "TGA123";


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
        public static bool CreateNewUser(User user)
        {
            //For Admin Use - Create a New Faculty User (for application login)
            StringBuilder query = new StringBuilder();

            string resultString = "!";

            query.Append("INSERT INTO [TGA_Project].[dbo].[USERS] ");
            query.Append("([USER_ID],[FIRST_NAME],[LAST_NAME],[EMAIL],[PASSWORD],[POSITION_ID]) ");
            query.Append(String.Format("VALUES ({0}, '{1}', '{2}', '{3}', '{4}', {5})", user.UserID, user.FirstName, user.LastName, user.Email, user.Password, user.PositionID));

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if(result == 1)
                        {return true;}
                        else
                        {return false;}
                    }
                    catch(Exception e)
                    {
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public static DataTable GetCurrentApplications()
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT * ");
            query.Append("FROM [TGA_Project].[dbo].[GRAD_APP] ");
            query.Append(String.Format("WHERE ACTIVE = {0}", 1));

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
