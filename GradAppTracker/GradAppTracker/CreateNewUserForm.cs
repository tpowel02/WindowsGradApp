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
    public partial class CreateNewUserForm : Form
    {
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {

        }
        private void CreateNewUserForm_Close(object sender, EventArgs e)
        {

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserID = 20; //need to figure out autogenerate in DB?
            user.Email = tbEmail.Text;
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Password = tbPassword.Text;

            string userTypeString = cbUserType.Text;
            string confirmPasswordString = tbConfirmPassword.Text;

            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                switch (userTypeString)
                {
                    /*  Key: 
                     *      Admin   = 1
                     *    Faculty = 2
                     */
                    case "Faculty":
                        user.PositionID = 2;
                        break;
                    case "Faculty Admin":
                        user.PositionID = 1;
                        break;
                }

                if (IsUserValid(user))
                {
                    //TODO: Create Specific Error Message from DB (Email taken, etc.)

                    bool result = DB.CreateNewUser(user);

                    if (result)
                    {
                        MessageBox.Show("User Created", "Success", MessageBoxButtons.OK);                                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Creating User, please try again.", "Database Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match", "Enter Valid Password", MessageBoxButtons.OK);
                }
            }
            
        }

        private Boolean IsUserValid(User user)
        {
            string errorMessage = "";

            if (user.FirstName.Length > 0 && user.LastName.Length > 0 && user.Password.Length > 0 && user.PositionID > 0)
            {
                return true;
            }
            else
            {
                errorMessage = "Complete All Fields Correctly and Try Again";
                MessageBox.Show(errorMessage, "Incomplete Fields", MessageBoxButtons.OK);
                return false;
            }

        }
    }
}
