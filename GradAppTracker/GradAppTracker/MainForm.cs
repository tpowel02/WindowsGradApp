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
           
            //Setting Current Column widths
            DataGridViewColumn column0 = dgvCurrent.Columns[0];
            column0.Width = 120;
            DataGridViewColumn column1 = dgvCurrent.Columns[1];
            column1.Width = 70;
            DataGridViewColumn column2 = dgvCurrent.Columns[2];
            column2.Width = 120;
            DataGridViewColumn column3 = dgvCurrent.Columns[3];
            column3.Width = 120;
            DataGridViewColumn column4 = dgvCurrent.Columns[4];
            column4.Width = 120;
            DataGridViewColumn column5 = dgvCurrent.Columns[5];
            column5.Width = 60;
            DataGridViewColumn column6 = dgvCurrent.Columns[6];
            column6.Width = 60;
            DataGridViewColumn column7 = dgvCurrent.Columns[7];
            column7.Width = 60;
            DataGridViewColumn column8 = dgvCurrent.Columns[8];
            column8.Width = 60;
            DataGridViewColumn column9 = dgvCurrent.Columns[9];
            column9.Width = 60;
            DataGridViewColumn column10 = dgvCurrent.Columns[10];
            column10.Width = 60;
            DataGridViewColumn column11 = dgvCurrent.Columns[11];
            column11.Width = 60;

            //Setting Past Column widths
            DataGridViewColumn pastColumn0 = dgvPast.Columns[0];
            pastColumn0.Width = 120;
            DataGridViewColumn pastColumn1 = dgvPast.Columns[1];
            pastColumn1.Width = 70;
            DataGridViewColumn pastColumn2 = dgvPast.Columns[2];
            pastColumn2.Width = 120;
            DataGridViewColumn pastColumn3 = dgvPast.Columns[3];
            pastColumn3.Width = 120;
            DataGridViewColumn pastColumn4 = dgvPast.Columns[4];
            pastColumn4.Width = 120;
            DataGridViewColumn pastColumn5 = dgvPast.Columns[5];
            pastColumn5.Width = 60;
            DataGridViewColumn pastColumn6 = dgvPast.Columns[6];
            pastColumn6.Width = 60;
            DataGridViewColumn pastColumn7 = dgvPast.Columns[7];
            pastColumn7.Width = 60;
            DataGridViewColumn pastColumn8 = dgvPast.Columns[8];
            pastColumn8.Width = 60;
            DataGridViewColumn pastColumn9 = dgvPast.Columns[9];
            pastColumn9.Width = 60;
            DataGridViewColumn pastColumn10 = dgvPast.Columns[10];
            pastColumn10.Width = 60;
            DataGridViewColumn pastColumn11 = dgvPast.Columns[11];
            pastColumn11.Width = 60;
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
            AddTrackingRecordForm form = new AddTrackingRecordForm();
            form.ShowDialog();
        }

        private void viewDegreeEvaluationBtn_Click(object sender, EventArgs e)
        {

            int studentId = 0;

            DataGridViewRow dgvRow;
            DataGridView dgv;
            DataGridViewSelectedRowCollection dgvRows;

            try
            {
                dgvRows = dgvCurrent.SelectedRows;
                dgvRow = dgvRows[0];

                studentId = Int32.Parse((string)dgvRow.Cells["Student ID"].Value);

                ConfirmNewGradAppForm  evaluation = new ConfirmNewGradAppForm(studentId);

                evaluation.Tag = studentId;

                evaluation.ShowDialog();

                Refresh refresh = new Refresh();
                refresh.RefreshMain(dgvCurrent);
            }
            catch (Exception e1)
            {

            }



        }


    }
}
