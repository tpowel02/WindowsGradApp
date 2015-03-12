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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main(String[]args)
        {
            Application.Run(new LoginForm());
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int result = 1;

            //result = DB.Login(tbEmail.Text, tbPassword.Text);

            if (result == 0)
            {
                MessageBox.Show("Login Failed. One or More Specified Fields is Incorrect.", "Login Failed, Please Try Again", MessageBoxButtons.OK);
            }
            else if(result == 1)
            {
                //MessageBox.Show("Login Success.", "Test", MessageBoxButtons.OK);
                this.Hide();
                MainForm mf = new MainForm();

                mf.Show();
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
