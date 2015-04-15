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
        bool duelDegree = false;
        bool doubleMajor = false;
        
       

        public CreateNewGradAppForm()
        {
            InitializeComponent();
            
        }

        private void CreateNewGradAppForm_Load(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            if (duelDegree)
            {
                panelPage1.Hide();
                panelDuelDegree.Show();
                panelPage1.Enabled = false;
                panelDuelDegree.Enabled = true;
            }
            else if (doubleMajor)
            {
                panelPage1.Hide();
                panelDoubleMajor.Show();
                panelPage1.Enabled = false;
                panelDoubleMajor.Enabled = true;
            }
            else
            {
                panelPage1.Hide();
                panelPage2.Show();
                panelPage1.Enabled = false;
                panelPage2.Enabled = true;
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
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
            else
            {
                panelPage2.Hide();
                panelPage3.Show();
                panelPage2.Enabled = false;
                panelPage3.Enabled = true;
            }
        }

        private void Page3NextButton_Click(object sender, EventArgs e)
        {
            panelPage3.Hide();
            panelPage4.Show();
            panelPage3.Enabled = false;
            panelPage4.Enabled = true;
        }

        private void Page4NextButton_Click(object sender, EventArgs e)
        {
            ConfirmNewGradAppForm confirm = new ConfirmNewGradAppForm();
            confirm.FormClosed += new FormClosedEventHandler(confirm_FormClosed);
            confirm.Show();
            //this.Hide();
            
            
        }
        private void confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ResidenceNextButton_Click(object sender, EventArgs e)
        {
            panelResidence.Hide();
            panelPage3.Show();
            panelResidence.Enabled = false;
            panelPage3.Enabled = true;
        }

        private void Page2PreviousButton_Click(object sender, EventArgs e)
        {
            if (duelDegree)
            {
                panelPage2.Hide();
                panelDuelDegree.Show();
                panelPage2.Enabled = false;
                panelDuelDegree.Enabled = true;
            }
            else if (doubleMajor)
            {
                panelPage2.Hide();
                panelDoubleMajor.Show();
                panelPage2.Enabled = false;
                panelDoubleMajor.Enabled = true;
            }
            else
            {
                panelPage2.Hide();
                panelPage1.Show();
                panelPage2.Enabled = false;
                panelPage1.Enabled = true;
            }
        }

        private void DuelDegreePreviousButton_Click(object sender, EventArgs e)
        {
            panelDuelDegree.Hide();
            panelPage1.Show();
            panelDuelDegree.Enabled = false;
            panelPage1.Enabled = true;
        }

        private void DoubleMajorPreviousButton_Click(object sender, EventArgs e)
        {
            panelDoubleMajor.Hide();
            panelPage1.Show();
            panelDoubleMajor.Enabled = false;
            panelPage1.Enabled = true;
        }

        private void Page4PreviousButton_Click(object sender, EventArgs e)
        {
            panelPage4.Hide();
            panelPage3.Show();
            panelPage4.Enabled = false;
            panelPage3.Enabled = true;
        }

        private void Page3PreviousButton_Click(object sender, EventArgs e)
        {
            if (rbTransferYes.Checked)
            {
                panelPage3.Hide();
                panelResidence.Show();
                panelPage3.Enabled = false;
                panelResidence.Enabled = true;
            }
            else
            {
                panelPage3.Hide();
                panelPage2.Show();
                panelPage3.Enabled = false;
                panelPage2.Enabled = true;
            }
        }

        private void ResidencePreviousButton_Click(object sender, EventArgs e)
        {
            panelResidence.Hide();
            panelPage2.Show();
            panelResidence.Enabled = false;
            panelPage2.Enabled = true;
        }

        private void DuelDegreeNextButton_Click(object sender, EventArgs e)
        {
            panelDuelDegree.Hide();
            panelPage2.Show();
            panelDuelDegree.Enabled = false;
            panelPage2.Enabled = true;
        }

        private void DoubleMajorNextButton_Click(object sender, EventArgs e)
        {
            panelDoubleMajor.Hide();
            panelPage2.Show();
            panelDoubleMajor.Enabled = false;
            panelPage2.Enabled = true;
        }

        private void rbCeremonyYes_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void tbStudentID_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            GradApp gradApp = new GradApp();

            int txtStudentID = Convert.ToInt32(tbStudentID.Text);
            dt = DB.GetStudentInfo(txtStudentID);

            foreach (DataRow row in dt.Rows)
            {
                gradApp.StudentName         = row[0].ToString();
                gradApp.StudentEmail        = row[1].ToString();
                gradApp.TotalGPA            = Convert.ToDouble(row[2].ToString());
                gradApp.EarnedMajorGPA      = Convert.ToDouble(row[3].ToString());
                gradApp.EarnedMinorGPA      = Convert.ToDouble(row[4].ToString());
                gradApp.MajorName           = row[1].ToString();
                gradApp.MajorID             = Convert.ToInt32(row[1].ToString());
                gradApp.MajorCatalog        = row[1].ToString();
                gradApp.Concentration       = row[1].ToString();
                gradApp.ConcentrationCode   = row[1].ToString();
                gradApp.MinorID             = Convert.ToInt32(row[1].ToString());
                gradApp.MinorName           = row[1].ToString();
                gradApp.MinorCatalog        = row[1].ToString();
                gradApp.GradYear            = Convert.ToInt32(row[1].ToString());

                //etc.....
            }

            lblStudentName.Text = gradApp.StudentName;
        }

      

        

        

       

       

    }
}
