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

        }
    }
}
