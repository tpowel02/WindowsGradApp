using System;
using System.Collections;
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
    public partial class AddTrackingRecordForm : Form
    {
        public AddTrackingRecordForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string studentID;
            string gradYear;
            string gradSem;

            string advisorName;
            string deptChair;

            try
            {
                studentID = tbStudentID.Text;
                gradYear = tbGradYear.Text;
                gradSem = tbGradSem.Text;
                advisorName = tbAdvisorName.Text;
                deptChair = tbDeptChair.Text;



            }
            catch(Exception ex)
            {

            }



        }


        private void AddTrackingRecordForm_Load(object sender, EventArgs e)
        {

            ArrayList advisors = new ArrayList();
            ArrayList deptChairs = new ArrayList();
            advisors = DB.GetAdvisors();
            deptChairs = DB.GetDeptChairs();

            for(int i = 0; i < advisors.Count; i++)
            {
                tbAdvisorName.Items.Add(advisors[i]);
            }

            for(int i = 0; i < deptChairs.Count; i++)
            {
                tbDeptChair.Items.Add(deptChairs[i]);
            }

        }

    }
}
