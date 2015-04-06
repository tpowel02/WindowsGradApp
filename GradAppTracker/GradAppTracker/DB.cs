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
            query.Append("([FIRST_NAME],[LAST_NAME],[EMAIL],[PASSWORD],[POSITION_ID]) ");
            query.Append(String.Format("VALUES ('{0}', '{1}', '{2}', '{3}', {4})", user.FirstName, user.LastName, user.Email, user.Password, user.PositionID));

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

            query.Append("SELECT grad_app.date_submitted AS [Date Submitted], student.student_id AS [Student ID], "
                        + "(student.first_name+' '+ student.last_name) AS [Student Name], "
                        + "(users.first_name+' '+ users.last_name) AS [Advisor Name], "
                //+ "(faculty.first_name +' ' + faculty.last_name) AS [Dean Name], "
                        + "(major.major_name) AS [Major Name], student.grad_year AS [Graduation Year], student.grad_semester AS [Graduation Semester], "
                        + "grad_app.status AS [Status], "
                        + "grad_app.advisor_approval AS [Advisor Approval], grad_app.dept_chair_approval AS [Dept. Chair Approval], grad_app.dean_approval AS [Dean Approval], grad_app.records_approval AS [Records Approval] ");
            query.Append("FROM [TGA_Project].[dbo].[GRAD_APP] ");
            query.Append("JOIN [TGA_Project].[dbo].[student] ON [student].[db_student_id] = [GRAD_APP].[STUDENT_ID] ");
            query.Append("JOIN [TGA_Project].[dbo].[users] on [users].[user_id] = [grad_app].[advisor_id] ");
            query.Append("JOIN [TGA_Project].[dbo].[major] on [major].[major_id] = [grad_app].[major_id] ");
            query.Append(String.Format("WHERE GRAD_APP.ACTIVE = {0} ", 1));

            // join student, advisor, dept_chair, major ID's to display names

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


            query.Append("SELECT grad_app.date_submitted AS [Date Submitted], student.student_id AS [Student ID], "
                        + "(student.first_name+' '+ student.last_name) AS [Student Name], "
                        + "(users.first_name+' '+ users.last_name) AS [Advisor Name], "
                //+ "(faculty.first_name +' ' + faculty.last_name) AS [Dean Name], "
                        + "(major.major_name) AS [Major Name], student.grad_year AS [Graduation Year], student.grad_semester AS [Graduation Semester], "
                        + "grad_app.status AS [Status], "
                        + "grad_app.advisor_approval AS [Advisor Approval], grad_app.dept_chair_approval AS [Dept. Chair Approval], grad_app.dean_approval AS [Dean Approval], grad_app.records_approval AS [Records Approval] ");
            query.Append("FROM [TGA_Project].[dbo].[GRAD_APP] ");
            query.Append("JOIN [TGA_Project].[dbo].[student] ON [student].[db_student_id] = [GRAD_APP].[STUDENT_ID] ");
            query.Append("JOIN [TGA_Project].[dbo].[users] on [users].[user_id] = [grad_app].[advisor_id] ");
            query.Append("JOIN [TGA_Project].[dbo].[major] on [major].[major_id] = [grad_app].[major_id] ");
            query.Append(String.Format("WHERE GRAD_APP.ACTIVE = {0} ", 0));


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
