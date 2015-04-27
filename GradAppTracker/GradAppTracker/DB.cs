using System;
using System.Collections;
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

            query.Append("SELECT [USERS].[FIRST_NAME] AS [First Name], [USERS].[LAST_NAME] AS [Last Name], [USERS].[EMAIL] AS [Email], [POSITION].[POSITION_NAME] AS [User Type]  ");
            query.Append("FROM [TGA_Project].[dbo].[USERS] ");
            query.Append("JOIN [TGA_Project].[dbo].[POSITION] ON [POSITION].[POSITION_ID] = [USERS].[POSITION_ID]");

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
        public static bool UpdateUser(String firstName, String lastName, String email)
        {
            //For Admin Use - Create a New Faculty User (for application login)
            StringBuilder query = new StringBuilder();

            string resultString = "!";

            query.Append("USE [TGA_Project] ");
            query.Append("UPDATE [USERS] ");
            query.Append(String.Format("SET [FIRST_NAME] = '{0}',[LAST_NAME] = '{1}',[EMAIL] = '{2}' ", firstName, lastName, email));
            query.Append(string.Format("WHERE [EMAIL] = '{0}'",email));
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if (result == 1)
                        { return true; }
                        else
                        { return false; }
                    }
                    catch (Exception e)
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
        public static DataTable GetStudentInfo(int tempID)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT (student.first_name+' '+ student.last_name) AS [Student Name], "
                        + "(student.email) AS [Email], "
                        + "(student.gpa_total) AS [Total GPA], "
                        + "(student.gpa_major_one) AS [Major GPA], "
                        + "(major.major_name) AS [Major Name], "
                        + "(major.major_id) AS [Major ID - not code], "
                        + "(major.catalog_term) AS [Major Catalog Year], "
                        + "(major.concentration) AS [Concentration], "
                        + "(major.concentration_code) AS [Concentration Code], "
                        + "(student.grad_year) AS [Graduation Year], "
                        + "(student.grad_semester) AS [Graduation Semester] ");
            query.Append("FROM [TGA_Project].[dbo].[student] ");
            query.Append("JOIN [TGA_Project].[dbo].[student_major] on [student_major].[db_student_id] = [student].[db_student_id] ");
            query.Append("JOIN [TGA_Project].[dbo].[major] on [major].[major_id] = [student_major].[major_id] ");
            query.Append(String.Format("WHERE student.student_id = {0} ", tempID)); // should be tempID - 29347 is trent's ID

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
        public static DataTable GetStudentInfoMinor(int tempID)
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT (student.first_name+' '+ student.last_name) AS [Student Name], "
                        + "(student.email) AS [Email], "
                        + "(student.gpa_total) AS [Total GPA], "
                        + "(student.gpa_major_one) AS [Major GPA], "
                        + "(student.gpa_minor) AS [Minor GPA], "
                        + "(major.major_name) AS [Major Name], "
                        + "(major.major_id) AS [Major ID - not code], "
                        + "(major.catalog_term) AS [Major Catalog Year], "
                        + "(major.concentration) AS [Concentration], "
                        + "(major.concentration_code) AS [Concentration Code], "
                        + "(minor.minor_id) AS [Minor ID - not code], "
                        + "(minor.minor_name) AS [Minor Name], "
                        + "(minor.catalog_term) AS [Minor Catalog Year], "
                        + "(student.grad_year) AS [Graduation Year], "
                        + "(student.grad_semester) AS [Graduation Semester] ");
            query.Append("FROM [TGA_Project].[dbo].[student] ");
            query.Append("JOIN [TGA_Project].[dbo].[minor] on [minor].[minor_id] = [student].[minor_id] ");
            query.Append("JOIN [TGA_Project].[dbo].[student_major] on [student_major].[db_student_id] = [student].[db_student_id] ");
            query.Append("JOIN [TGA_Project].[dbo].[major] on [major].[major_id] = [student_major].[major_id] ");
            query.Append(String.Format("WHERE student.student_id = {0} ", tempID)); // should be tempID - 29347 is trent's ID

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
        public static bool UpdateApprovalStatus(string advisor, string dept, string dean, string records, string name)
        {

            StringBuilder query = new StringBuilder();

            string resultString = "!";

            query.Append("UPDATE [TGA_Project].[dbo].[GRAD_APP] ");
            query.Append(String.Format("SET [ADVISOR_APPROVAL]='{0}',[DEPT_CHAIR_APPROVAL]='{1}',[DEAN_APPROVAL]='{2}',[RECORDS_APPROVAL]='{3}' ", advisor,dept,dean,records));
            query.Append(string.Format("WHERE [STUDENT_ID] = (SELECT [TGA_Project].[dbo].[grad_app].STUDENT_ID FROM [TGA_Project].[dbo].[GRAD_APP] JOIN  [TGA_Project].[dbo].[USERS] ON  [TGA_Project].[dbo].[grad_app].student_id= [TGA_Project].[dbo].[users].user_id WHERE CONCAT( [TGA_Project].[dbo].[users].first_name, ' ',  [TGA_Project].[dbo].[users].last_name) LIKE '{0}')", name));

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if (result == 1)
                        { return true; }
                        else
                        { return false; }
                    }
                    catch (Exception e)
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
        public static string GetStudentName(int id)
        {
            StringBuilder query = new StringBuilder();

            query.Append("USE [TGA_Project]");
            query.Append("SELECT [FIRST_NAME] + ' ' + [LAST_NAME] ");
            query.Append("FROM [USERS] ");
            query.Append("JOIN [STUDENT] ON [USERS].[USER_ID]=[STUDENT].[DB_STUDENT_ID]");
            query.Append(string.Format("WHERE [STUDENT_ID] = {0}", id));

            DataTable table = new DataTable();

            string name;

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    SqlDataReader rdr = command.ExecuteReader();
                    name = rdr.GetString(0) + " " + rdr.GetString(1);
                    conn.Close();
                }
            }
            return name;
        }

        public static ArrayList GetAdvisors()
        {
            StringBuilder query = new StringBuilder();
            ArrayList advisors = new ArrayList();


            query.Append("USE [TGA_Project]");
            query.Append("SELECT [FIRST_NAME] + ' ' + [LAST_NAME] ");
            query.Append("FROM [USERS] ");
            query.Append(string.Format("WHERE [POSITION_ID] = {0}", 3));

            DataTable table = new DataTable();

            string name;

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    SqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        //name = rdr.GetString(0) + " " + rdr.GetString(1);

                        name = rdr.GetString(0);
                        advisors.Add(name);
                    }
                    conn.Close();
                }
            }
            return advisors;
        }

        public static ArrayList GetDeptChairs()
        {
            StringBuilder query = new StringBuilder();
            ArrayList deptChairs = new ArrayList();


            query.Append("USE [TGA_Project]");
            query.Append("SELECT [FIRST_NAME] + ' ' + [LAST_NAME] ");
            query.Append("FROM [USERS] ");
            query.Append(string.Format("WHERE [POSITION_ID] = {0}", 4));

            DataTable table = new DataTable();

            string name;

            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query.ToString(), conn))
                {
                    SqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        //name = rdr.GetString(0) + " " + rdr.GetString(1);
                        name = rdr.GetString(0);
                        deptChairs.Add(name);
                    }
                    conn.Close();
                }
            }
            return deptChairs;
        }
    }
}
