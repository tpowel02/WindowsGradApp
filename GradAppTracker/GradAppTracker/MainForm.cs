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
            dt = DB.GetCurrentApplications();
            dgvCurrent.DataSource = dt;
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
    }
}
