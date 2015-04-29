﻿using System;
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
    public partial class ViewDegreeEvaluation : Form
    {
        public ViewDegreeEvaluation()
        {
            InitializeComponent();
        }

        private void btnEvalSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt    = new DataTable();
            GradApp gradApp = new GradApp();

            int evalStudentID;
            int result;
            int count=0;

            try
            {
                evalStudentID = Convert.ToInt32(tbEvalStudentID.Text);
                gradApp.StudentID = evalStudentID;

                dt = DB.GetStudentInfo(evalStudentID);
                foreach (DataRow row in dt.Rows)
                {
                    if (count == 0)
                    {
                        // ------------------------------------------------------------------------ general student info

                        gradApp.StudentName         = row[0].ToString();
                        gradApp.StudentEmail        = row[1].ToString();
                        gradApp.TotalGPA            = Convert.ToDouble(row[2].ToString());
                        gradApp.EarnedMajorGPA      = Convert.ToDouble(row[3].ToString());
                        gradApp.MajorName           = row[4].ToString();
                        gradApp.MajorID             = Convert.ToInt32(row[5].ToString());
                        gradApp.MajorCatalog        = row[6].ToString();
                        gradApp.Concentration       = row[7].ToString();
                        gradApp.ConcentrationCode   = row[8].ToString();
                        gradApp.GradYear            = Convert.ToInt32(row[9].ToString());
                        gradApp.GradSemester        = row[10].ToString();
                        gradApp.Ceremony            = row[11].ToString();
                    }
                    else if (count == 1)
                    {
                        // ------------------------------------------------------------------------ info for student with double major

                        gradApp.DoubleMajorName     = row[4].ToString();
                        gradApp.DoubleMajorID       = Convert.ToInt32(row[5].ToString());
                        gradApp.DoubleMajorCatalog  = row[6].ToString();
                    }
                    count++;
                }

                result = DB.CheckForMinor(evalStudentID);
                if (result == 1)
                {
                    dt = DB.GetStudentInfoMinor(evalStudentID);
                    foreach (DataRow row in dt.Rows)
                    {
                        // ------------------------------------------------------------------------ info for student with minor

                        gradApp.EarnedMinorGPA  = Convert.ToDouble(row[0].ToString());
                        gradApp.MinorID         = Convert.ToInt32(row[1].ToString());
                        gradApp.MinorName       = row[2].ToString();
                        gradApp.MinorCatalog    = row[3].ToString();
                    }
                }

                /*result = DB.CheckForDual(evalStudentID);
                if (result == 1)
                {
                    dt = DB.GetStudentInfoDual(evalStudentID);
                    foreach (DataRow row in dt.Rows)
                    {
                        gradApp.EarnedMinorGPA  = Convert.ToDouble(row[0].ToString());
                        gradApp.MinorID         = Convert.ToInt32(row[1].ToString());
                        gradApp.MinorName       = row[2].ToString();
                        gradApp.MinorCatalog    = row[3].ToString();
                    }
                }*/


            } 
            catch(Exception e3)
            { }

            ConfirmNewGradAppForm evaluationByID = new ConfirmNewGradAppForm(gradApp);
            evaluationByID.ShowDialog();
            this.Close();
        }

        private void btnEvalCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
