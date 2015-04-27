using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradAppTracker
{
    public partial class MainForm : Form
    {
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DB.GetConnection();

            //Instantiate both Current and History 
            //Grad App DataGridView DataSources

            dt = DB.GetCurrentApplications();                                                                     
            dgvCurrent.DataSource = dt;                   

            dt = DB.GetPastApplications();
            dgvPast.DataSource = dt;

            dt = DB.GetUsers();
            dgvUsers.DataSource = dt;

            cbFilterBySemester.SelectedIndex = 0;
        }

        private void btnCreateNewLogin_Click(object sender, EventArgs e)
        {
            CreateNewUserForm create = new CreateNewUserForm();
            create.ShowDialog();

            dt = DB.GetUsers();
            dgvUsers.DataSource = dt;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateExistingLogin_Click(object sender, EventArgs e)
        {
            // TODO:
            //show update form, 
            //pass a selected datarow from dgvUsers to update method (need to create this still)
            //try to update DB on accept button
            //return updated data row and update dgv source from DB

            string firstName;
            string lastName;
            string email;
            string positionName;

            DataGridViewRow dgvRow;
            DataGridView dgv;
            DataGridViewSelectedRowCollection dgvRows;
            User user = new User();
            try
            {
                dgvRows = dgvUsers.SelectedRows;
                dgvRow = dgvRows[0];

                firstName = (string) dgvRow.Cells["First Name"].Value;
                lastName = (string)dgvRow.Cells["Last Name"].Value;
                email = (string)dgvRow.Cells["Email"].Value;
                positionName = (string)dgvRow.Cells["User Type"].Value;

                DGVUpdateForm uf = new DGVUpdateForm();
                uf.Tag = firstName + " " +  lastName + " " + email;
                uf.ShowDialog();

                Refresh refresh = new Refresh();
                refresh.RefreshAdvisorTools(dgvUsers);
            }
            catch(Exception e1)
            {

            }

        }

        private void btnCreateGradApp_Click(object sender, EventArgs e)
        {
            CreateNewGradAppForm create = new CreateNewGradAppForm();
            create.ShowDialog();
            // TODO:
            //ShowDialog() create app form
            //create new grad app class
            //fill with data from user input
            //check for errors
            //try to insert into DB
            //if successful update DGV
            // if not, tell user to try again (and why if possible)
        }

        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
            //Search student first and last name fields then filter

            if (tbSearchByName.Text == "")
            {
                SqlConnection conn = DB.GetConnection();

                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;

                dt = DB.GetPastApplications();
                dgvPast.DataSource = dt;
            }
            else
            {
               try
               {
                   (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Student Name] LIKE '%{0}%'", tbSearchByName.Text);
                   (dgvPast.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Student Name] LIKE '%{0}%'", tbSearchByName.Text);
               }
               catch (Exception e1)
               {
                  //don't care
               }
            }
        }

        private void tbSearchByStudentIdNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchByStudentIdNumber.Text == "")
            {
                SqlConnection conn = DB.GetConnection();
                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;

                dt = DB.GetPastApplications();
                dgvPast.DataSource = dt;
                return;
            }
            else
            {
                try
                {
                    (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Student ID] LIKE '{0}%'", tbSearchByStudentIdNumber.Text);
                    (dgvPast.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Student ID] LIKE '{0}%'", tbSearchByStudentIdNumber.Text);
                }
                catch (Exception e1)
                {
                        //don't care
                }
            }
        }
        private void tbSearchByAdvisorName_TextChanged(object sender, EventArgs e)
        {
            //Search advisor first and last name fields then filter

            if (tbSearchByAdvisorName.Text == "")
            {
                SqlConnection conn = DB.GetConnection();

                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;

                dt = DB.GetPastApplications();
                dgvPast.DataSource = dt;
            }
            else
            {
                try
                {
                    (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Advisor Name] LIKE '%{0}%'", tbSearchByAdvisorName.Text);
                    (dgvPast.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Advisor Name] LIKE '%{0}%'", tbSearchByAdvisorName.Text);
                }
                catch (Exception e1)
                {
                    //don't care
                }
            }
        }

        private void tbYearFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbYearFilter.Text == "")
            {
                SqlConnection conn = DB.GetConnection();
                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;

                dt = DB.GetPastApplications();
                dgvPast.DataSource = dt;
                return;
            }
            else
            {
                try
                {
                    (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Graduation Year] = '{0}'", tbYearFilter.Text);
                    (dgvPast.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Graduation Year] = '{0}'", tbYearFilter.Text);
                }
                catch(Exception e1)
                {
                    //dont' care
                }

            }
        }

        private void cbFilterBySemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBySemester.Text == "All")
            {
                SqlConnection conn = DB.GetConnection();
                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;

                dt = DB.GetPastApplications();
                dgvPast.DataSource = dt;
            }
            else
            {
            
                try
                {
                    (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Graduation Semester] LIKE '{0}%'", cbFilterBySemester.SelectedItem);
                    (dgvPast.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Graduation Semester] LIKE '{0}%'", cbFilterBySemester.SelectedItem);
                }
                catch (Exception e1)
                {
                    //don't care
                }
            }
        }

       /* private void cbFilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterByStatus.Text == "")
            {
                SqlConnection conn = DB.GetConnection();
                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;
            }
            else
            {
                try
                {
                    (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Status] LIKE '{0}%'", cbFilterByStatus.SelectedItem);
                }
                catch (Exception e1)
                {
                    //don't care
                }
            }
        }
        */

        private void button3_Click(object sender, EventArgs e) //Update Approval Status
        {

            string advisor;
            string dept;
            string dean;
            string records;
            string name;

            DataGridViewRow dgvRow;
            DataGridView dgv;
            DataGridViewSelectedRowCollection dgvRows;

            try
            {
                dgvRows = dgvCurrent.SelectedRows;
                dgvRow = dgvRows[0];

                DGVUpdateStatusForm dgvu = new DGVUpdateStatusForm();

                advisor = (string)dgvRow.Cells["Advisor Approval"].Value;
                dept = (string)dgvRow.Cells["Dept. Chair Approval"].Value;
                dean = (string)dgvRow.Cells["Dean Approval"].Value;
                records = (string)dgvRow.Cells["Records Approval"].Value;
                name = (string)dgvRow.Cells["Student Name"].Value;

                dgvu.Tag = advisor + " " + dept + " " + dean + " " + records + " " + name;

                dgvu.ShowDialog();

                Refresh refresh = new Refresh();
                refresh.RefreshMain(dgvCurrent);
            }
            catch (Exception e1)
            {

            }
        }

        private void addTrackingRecordbtn_Click(object sender, EventArgs e)
        {

        }


    }
}
