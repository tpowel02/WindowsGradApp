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
            //infoDiplomaName.Text = gradApp.StudentNameDiploma; -- manual entry required
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
                infoRequiredMinorGPA.Text = "2.0"; // -- not in db
                infoEarnedMinorGPA.Text = gradApp.EarnedMinorGPA.ToString(); 
                if (gradApp.EarnedMinorGPA < 2.0)
                    xMinor.Visible = true;
                else
                    yMinor.Visible = true;
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
            if (gradApp.UpperLevelHours < 45)
                xUpper.Visible = true;
            else
                yUpper.Visible = true;
            //xUpper.Hide();
            infoLowerLevelHours.Text = gradApp.LowerLevelHours.ToString();
            if (gradApp.UpperLevelHours < 68)
                xLower.Visible = true;
            else
                yLower.Visible = true;
            infoTotalGPA.Text = gradApp.TotalGPA.ToString(); 
            if (gradApp.TotalGPA < 2.0)
                xTotal.Visible = true;
            else
                yTotal.Visible = true;
            infoRequiredMajorGPA.Text = "2.0"; // -- not in db
            infoEarnedMajorGPA.Text = gradApp.EarnedMajorGPA.ToString();
            if (gradApp.EarnedMajorGPA < 2.0)
                xMajor.Visible = true;
            else
                yMajor.Visible = true;
            //infoTotalResidencyHours.Text = gradApp.TotalResidencyHours.ToString(); -- manual entry required
            //infoLast36ResidencyHours.Text = gradApp.Last36ResidencyHours.ToString(); -- manual entry required
            //infoApprovedElectives.Text = gradApp.ApprovedElectives.ToString(); -- manual entry required
            infoHoursOfD.Text = gradApp.HoursOfD.ToString();
            if (gradApp.HoursOfD >15)
                xDHours.Visible = true;
            else
                yDHours.Visible = true;
            //infoSubstitutionCheck.Text = gradApp.SubstitutionCheck.ToString(); -- manual entry required
            //infoCourseSubstitution.Text = gradApp.CourseSubstitution.ToString(); -- manual entry required
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
