using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradAppTracker
{
    class GradApp
    {
        private int studentID;
        private int advisorID;
        private int deptChairID;
        private int majorID;
        private DateTime dateTime;
        private string status;
        private char advisorApproval;
        private char deptChairApproval;
        private char recordsDeptApproval;
        private char deanApproval;
        private string degreeEval;
        private int active;

        public int Student_ID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int AdvisorID
        {
            get { return advisorID; }
            set { advisorID = value; }
        }
        public int DeptChairID
        {
            get { return deptChairID; }
            set { deptChairID = value; }
        }

        public int MajorID
        {
            get { return majorID; }
            set { majorID = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public char AdvisorApproval
        {
            get { return advisorApproval; }
            set { advisorApproval = value; }
        }

        public char DeptChairApproval
        {
            get { return deptChairApproval; }
            set { deptChairApproval = value; }
        }

        public char RecordsDeptApproval
        {
            get { return recordsDeptApproval; }
            set { recordsDeptApproval = value; }
        }

        public char DeanApproval
        {
            get { return deanApproval; }
            set { deanApproval = value; }
        }
        public string DegreeEval
        {
            get { return degreeEval; }
            set { degreeEval = value; }
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
