using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradAppTracker
{

    class User
    {
        //EX. VALUES (1,'Kenneth','Hickman','KHickm00@g.uafs.edu','Pi6G72G3',3);

        private int userID;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private int positionID;


        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int PositionID
        {
            get { return positionID; }
            set { positionID = value; }
        }
    }
}
