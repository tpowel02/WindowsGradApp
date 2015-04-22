using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradAppTracker
{
    class Refresh
    {
        DataTable dt;
        public void RefreshMain(DataGridView dgvCurrent)
        {
            dt = DB.GetCurrentApplications();
            dgvCurrent.DataSource = dt;
        }
        public void RefreshSecondary(DataGridView dgvPast)
        {
            dt = DB.GetPastApplications();
            dgvPast.DataSource = dt;
        }
        public void RefreshAdvisorTools(DataGridView dgvUsers)
        {
            dt = DB.GetUsers();
            dgvUsers.DataSource = dt;
        }
    }
}
