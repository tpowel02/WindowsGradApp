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
    public partial class ConfirmNewGradAppForm : Form
    {
        public ConfirmNewGradAppForm(GradApp gradApp)
        {
            InitializeComponent();
            infoStudentID.Text = gradApp.StudentID.ToString();
            infoStudentName.Text = gradApp.StudentName;
            infoStudentEmail.Text = gradApp.StudentEmail;
            //infoDiplomaName.Text = gradApp.StudentNameDiploma;
            infoCeremony.Text = gradApp.Ceremony;
            infoGradYear.Text = gradApp.GradYear.ToString();
            infoGradSemester.Text = gradApp.GradSemester;
            infoMajorID.Text = gradApp.MajorID.ToString();
            infoMajorName.Text = gradApp.MajorName;
            infoMajorCatalog.Text = gradApp.MajorCatalog;
            infoConcentration.Text = gradApp.Concentration;
            infoConcentrationCode.Text = gradApp.ConcentrationCode;
            if (gradApp.MinorID == 0)
            {
                // I made it this way in case we wanted to display something
            }
            else
            {
                infoMinorID.Text = gradApp.MinorID.ToString();
                infoMinorName.Text = gradApp.MinorName;
                infoMinorCatalog.Text = gradApp.MinorCatalog;
                infoRequiredMinorGPA.Text = gradApp.RequiredMinorGPA.ToString();
                infoEarnedMinorGPA.Text = gradApp.EarnedMinorGPA.ToString();
            }
            if (gradApp.DoubleMajorID == 0)
            {
                // I made it this way in case we wanted to display something
            }
            else
            {
                infoDoubleMajorID.Text = gradApp.DoubleMajorID.ToString();
                infoDoubleMajorName.Text = gradApp.DoubleMajorName;
                infoDoubleMajorCatalog.Text = gradApp.DoubleMajorCatalog;
                infoDoubleMajorHours.Text = gradApp.DoubleMajorHours.ToString();
            }
            if (gradApp.DualDegreeID == 0)
            {
                // I made it this way in case we wanted to display something
            }
            else
            {
                infoDualDegreeID.Text = gradApp.DualDegreeID.ToString();
                infoDualDegreeName.Text = gradApp.DualDegreeName;
                infoDualDegreeCatalog.Text = gradApp.DualDegreeCatalog;
                infoDualDegreeHours.Text = gradApp.DualDegreeHours.ToString();
            }
            infoUpperLevelHours.Text = gradApp.UpperLevelHours.ToString();
            infoLowerLevelHours.Text = gradApp.LowerLevelHours.ToString();
            infoTotalGPA.Text = gradApp.TotalGPA.ToString();
            infoRequiredMajorGPA.Text = gradApp.RequiredMajorGPA.ToString();
            infoEarnedMajorGPA.Text = gradApp.EarnedMajorGPA.ToString();
            //infoTotalResidencyHours.Text = gradApp.TotalResidencyHours.ToString();
            //infoLast36ResidencyHours.Text = gradApp.Last36ResidencyHours.ToString();
            //infoApprovedElectives.Text = gradApp.ApprovedElectives.ToString();
            infoHoursOfD.Text = gradApp.HoursOfD.ToString();
            //infoSubstitutionCheck.Text = gradApp.SubstitutionCheck.ToString();
            //infoCourseSubstitution.Text = gradApp.CourseSubstitution.ToString();
        }

        private void ConfirmNewGradAppButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
