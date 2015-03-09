using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradAppTracker
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string stuIdNum;



        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StuIdNum
        {
            get { return stuIdNum; }
            set { stuIdNum = value; }
        }
    }
}
