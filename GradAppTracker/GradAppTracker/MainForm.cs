﻿using System;
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


            //TODO: IF user is admin, load users DGV, need to get user.PositionID of currently logged in user, and check to see that it is corresponding value  (1 = admin?)
            dt = DB.GetUsers();
            dgvUsers.DataSource = dt;

        }

        private void tbSearchByName_TextChanged(object sender, EventArgs e)
        {
            //Search student first and last name fields then filter

            if (tbSearchByName.Text == "")
            {
                SqlConnection conn = DB.GetConnection();
                dt = DB.GetCurrentApplications();
                dgvCurrent.DataSource = dt;
            }
            else
            {
                (dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("APP_ID = '{0}'", tbSearchByName.Text);
                //(dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name = '{0}'", tbSearchByName.Text);
            }
        }

        private void clbFilterBySemester_SelectedIndexChanged(object sender, EventArgs e)
        {

            //(dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("Semester LIKE '%{0}%'", clbFilterBySemester.SelectedValue);

        }

        private void tbSearchByStudentIdNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchByStudentIdNumber.Text == "")
            {
                return;
            }
            else
            {
                //(dgvCurrent.DataSource as DataTable).DefaultView.RowFilter = string.Format("Student ID = '{0}'", tbSearchByStudentIdNumber.Text);
            }
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
            //show update form, 
            //pass a selected datarow to update method
            //try to update DB on accept button
            //return updated data row and update dgv source from DB
        }

        private void btnCreateGradApp_Click(object sender, EventArgs e)
        {
            //ShowDialog() create app form
            //create new grad app class
            //fill with data from user input
            //check for errors
            //try to insert into DB
            //if successful update DGV
            // if not, tell user to try again (and why if possible)
        }
    }
}
