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
        public ConfirmNewGradAppForm()
        {
            InitializeComponent();
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
