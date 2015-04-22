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
    public partial class DGVUpdateForm : Form
    {
        public DGVUpdateForm()
        {
            InitializeComponent();
        }


        private void DGVUpdateForm_Load(object sender, EventArgs e)
        {
            string[] split;
            DataGridViewRow dgvr = new DataGridViewRow();

            split = this.Tag.ToString().Split();

            dgvr.CreateCells(updateUserDgv);

            dgvr.Cells[0].Value = split[0].ToString();
            dgvr.Cells[1].Value = split[1].ToString();
            dgvr.Cells[2].Value = split[2].ToString();
            updateUserDgv.Rows.Add(dgvr); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName;
            string lastName;
            string email;

            Boolean result = false;
            DataGridViewRow dgvRow;
            DataGridView dgv;
            DataGridViewSelectedRowCollection dgvRows;

            try
            {
                updateUserDgv.Rows[0].Selected = true;
                dgvRows = updateUserDgv.SelectedRows;
                dgvRow = dgvRows[0];

                DGVUpdateForm dgvu = new DGVUpdateForm();

                firstName = (string)dgvRow.Cells["FIRST_NAME"].Value;
                lastName = (string)dgvRow.Cells["LAST_NAME"].Value;
                email = (string)dgvRow.Cells["EMAIL"].Value;

                result = DB.UpdateUser(firstName,lastName,email);

                if (result == true)
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
