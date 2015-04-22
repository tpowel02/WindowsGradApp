using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradAppTracker
{
    public partial class DGVUpdateStatusForm : Form
    {
        public DGVUpdateStatusForm()
        {
            InitializeComponent();
        }

        private void DGVUpdateStatusForm_Load(object sender, EventArgs e)
        {
            string[] split;
            DataGridViewRow dgvr = new DataGridViewRow();

            split = this.Tag.ToString().Split();

            dgvr.CreateCells(dgvUpdateStatus);

            dgvr.Cells[0].Value = split[0].ToString();
            dgvr.Cells[1].Value = split[1].ToString();
            dgvr.Cells[2].Value = split[2].ToString();
            dgvr.Cells[3].Value = split[3].ToString();

            studentLabel.Text = split[4] + " " + split[5];

            dgvUpdateStatus.Rows.Add(dgvr); 
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string advisor;
            string dept;
            string dean;
            string records;
            string name;
            Boolean result = false;
            DataGridViewRow dgvRow;
            DataGridView dgv;
            DataGridViewSelectedRowCollection dgvRows;

            try
            {
                dgvUpdateStatus.Rows[0].Selected = true;
                dgvRows = dgvUpdateStatus.SelectedRows;
                dgvRow = dgvRows[0];

                DGVUpdateStatusForm dgvu = new DGVUpdateStatusForm();

                advisor = (string)dgvRow.Cells["AdvisorApproval"].Value;
                dept = (string)dgvRow.Cells["DeptChairApproval"].Value;
                dean = (string)dgvRow.Cells["DeanApproval"].Value;
                records = (string)dgvRow.Cells["RecordsApproval"].Value;
                
                name = studentLabel.Text;

                result = DB.UpdateApprovalStatus(advisor, dept, dean, records, name);

                if(result == true)
                {
                    MessageBox.Show("Update Successful!");
                }
                else
                {
                    MessageBox.Show("Update Unsuccessful!");
                }

            }
            catch (Exception e1)
            {
                //MessageBox.Show("Update Unsuccessful! (CATCH)");
            }

            this.Close();
        }
    }
}
