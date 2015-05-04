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

            user.PositionID = 1;
            user.Email = tbEmail.Text;
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Password = tbPassword.Text;

            string confirmPasswordString = tbConfirmPassword.Text;

            if (IsUserValid(user) && (tbPassword.Text == tbConfirmPassword.Text))
            {
                bool result = DB.CreateNewUser(user);

                if (result)
                {
                    MessageBox.Show("User Created", "Success", MessageBoxButtons.OK);                                        
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Error Creating User, please try again.", "Database Error", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords Do Not Match", "Enter Valid Password", MessageBoxButtons.OK);
            }
        }
           
        private Boolean IsUserValid(User user)
        {
            string errorMessage = "";

            if (user.FirstName.Length > 0 
                && user.LastName.Length > 0 
                && user.Password.Length > 0 
                && user.PositionID > 0)
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
