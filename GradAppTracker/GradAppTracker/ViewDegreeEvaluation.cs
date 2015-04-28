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
    public partial class ViewDegreeEvaluation : Form
    {
        public ViewDegreeEvaluation()
        {
            InitializeComponent();
        }

        private void btnEvalSubmit_Click(object sender, EventArgs e)
        {
            ConfirmNewGradAppForm evaluationByID = new ConfirmNewGradAppForm();
            evaluationByID.ShowDialog();
            this.Close();
        }

        private void btnEvalCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
