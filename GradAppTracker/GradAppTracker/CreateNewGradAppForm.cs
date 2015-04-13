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
    public partial class CreateNewGradAppForm : Form
    {
        public CreateNewGradAppForm()
        {
            InitializeComponent();
        }

        private void CreateNewGradAppForm_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            panelPage1.Hide();
            panelPage2.Show();
            panelPage1.Enabled = false;
            panelPage2.Enabled = true;
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Page2NextButton_Click(object sender, EventArgs e)
        {
            if (rbTransferYes.Checked)
            {
                panelPage2.Hide();
                panelResidence.Show();
                panelPage2.Enabled = false;
                panelResidence.Enabled = true;
            }
        }

       

       

    }
}
