using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradAppTracker
{
    public class GradApp
    {
        private int advisorID;
        private int deptChairID;
        private int active;
        private int studentID;
        private int majorID;
        private int gradYear;
        private int hoursOfD;
        private int last36ResidencyHours;
        private int totalResidencyHours;
        private int lowerLevelHours;
        private int upperLevelHours;
        private int dualDegreeHours;
        private int dualDegreeID;
        private int doubleMajorID;
        private int minorID;
        private int doubleMajorHours;
        private bool substitutionCheck;
        private bool approvedElectives;
        private char advisorApproval;
        private char deptChairApproval;
        private char recordsDeptApproval;
        private char deanApproval;
        private double earnedMinorGPA;
        private double requiredMinorGPA;
        private double earnedMajorGPA;
        private double requiredMajorGPA;
        private double totalGPA;
        private string status;
        private string degreeEval;
        private string studentName;
        private string studentEmail;
        private string studentNameDiploma;
        private string ceremony;
        private string gradSemester;
        private string majorName;
        private string dualDegreeCatalog;
        private string dualDegreeName;
        private string doubleMajorCatalog;
        private string doubleMajorName;
        private string minorCatalog;
        private string minorName;
        private string concentrationCode;
        private string concentration;
        private string majorCatalog;
        private string[][] courseSubstitution;
        private DateTime dateTime;
        private int degreeID;

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
        // ----------------------------------------------------------------------------------------
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string StudentEmail
        {
            get { return studentEmail; }
            set { studentEmail = value; }
        }
        public string StudentNameDiploma
        {
            get { return studentNameDiploma; }
            set { studentNameDiploma = value; }
        }
        public string Ceremony
        {
            get { return ceremony; }
            set { ceremony = value; }
        }
        public int GradYear
        {
            get { return gradYear; }
            set { gradYear = value; }
        }
        public string GradSemester
        {
            get { return gradSemester; }
            set { gradSemester = value; }
        }
        public int DegreeID
        {
            get { return degreeID; }
            set { degreeID = value; }
        }
        public int MajorID
        {
            get { return majorID; }
            set { majorID = value; }
        }
        public string MajorName
        {
            get { return majorName; }
            set { majorName = value; }
        }
        public string MajorCatalog
        {
            get { return majorCatalog; }
            set { majorCatalog = value; }
        }
        public string Concentration
        {
            get { return concentration; }
            set { concentration = value; }
        }
        public string ConcentrationCode
        {
            get { return concentrationCode; }
            set { concentrationCode = value; }
        }
        public int MinorID
        {
            get { return minorID; }
            set { minorID = value; }
        }
        public string MinorName
        {
            get { return minorName; }
            set { minorName = value; }
        }
        public string MinorCatalog
        {
            get { return minorCatalog; }
            set { minorCatalog = value; }
        }
        public int DoubleMajorID
        {
            get { return doubleMajorID; }
            set { doubleMajorID = value; }
        }
        public string DoubleMajorName
        {
            get { return doubleMajorName; }
            set { doubleMajorName = value; }
        }
        public string DoubleMajorCatalog
        {
            get { return doubleMajorCatalog; }
            set { doubleMajorCatalog = value; }
        }
        public int DoubleMajorHours
        {
            get { return doubleMajorHours; }
            set { doubleMajorHours = value; }
        }
        public int DualDegreeID
        {
            get { return dualDegreeID; }
            set { dualDegreeID = value; }
        }
        public string DualDegreeName
        {
            get { return dualDegreeName; }
            set { dualDegreeName = value; }
        }
        public string DualDegreeCatalog
        {
            get { return dualDegreeCatalog; }
            set { dualDegreeCatalog = value; }
        }
        public int DualDegreeHours
        {
            get { return dualDegreeHours; }
            set { dualDegreeHours = value; }
        }
        public int UpperLevelHours
        {
            get { return upperLevelHours; }
            set { upperLevelHours = value; }
        }
        public int LowerLevelHours
        {
            get { return lowerLevelHours; }
            set { lowerLevelHours = value; }
        }
        public double TotalGPA
        {
            get { return totalGPA; }
            set { totalGPA = value; }
        }
        public double RequiredMajorGPA
        {
            get { return requiredMajorGPA; }
            set { requiredMajorGPA = value; }
        }
        public double EarnedMajorGPA
        {
            get { return earnedMajorGPA; }
            set { earnedMajorGPA = value; }
        }
        public double RequiredMinorGPA
        {
            get { return requiredMinorGPA; }
            set { requiredMinorGPA = value; }
        }
        public double EarnedMinorGPA
        {
            get { return earnedMinorGPA; }
            set { earnedMinorGPA = value; }
        }
        public int TotalResidencyHours
        {
            get { return totalResidencyHours; }
            set { totalResidencyHours = value; }
        }
        public int Last36ResidencyHours
        {
            get { return last36ResidencyHours; }
            set { last36ResidencyHours = value; }
        }
        public bool ApprovedElectives
        {
            get { return approvedElectives; }
            set { approvedElectives = value; }
        }
        public int HoursOfD
        {
            get { return hoursOfD; }
            set { hoursOfD = value; }
        }
        public bool SubstitutionCheck
        {
            get { return substitutionCheck; }
            set { substitutionCheck = value; }
        }
        public string [][] CourseSubstitution
        {
            get { return courseSubstitution; }
            set { courseSubstitution = value; }
        }
    }
}
