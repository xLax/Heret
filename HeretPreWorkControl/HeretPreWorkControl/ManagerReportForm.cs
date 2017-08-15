using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class ManagerReportForm : Form
    {
        private List<tbl_employees> allEmployees;
        private Dictionary<int, string> dcEmployees;

        private DateTime dateToSearch;

        public ManagerReportForm()
        {
            InitializeComponent();

            Utilities.AllEmployeesForResponsible();

            dcEmployees = new Dictionary<int, string>();
            allEmployees = Globals.AllEmployeesResp
                .Where( a => a.Department_id != 0).ToList<tbl_employees>();

            foreach (tbl_employees emp in allEmployees)
            {
                dcEmployees.Add(emp.ID, emp.name);
                lbEmployees.Items.Add(emp.name);
            }

            if(allEmployees.Count > 0)
            {
                lbEmployees.SelectedIndex = 0;
            }

            tbTrackBar.Value = 0;
            lblPeriod.Text = "שבוע";
            this.dateToSearch = DateTime.Today.AddDays(-7);
        }

        private void TabStation_Enter(object sender, EventArgs e)
        {
            
        }

        private void TabEmployees_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbTrackBar_Scroll(object sender, EventArgs e)
        {
            if(tbTrackBar.Value == 0)
            {
                lblPeriod.Text = "שבוע";
                this.dateToSearch = DateTime.Today.AddDays(-7);
            }
            else if (tbTrackBar.Value == 1)
            {
                lblPeriod.Text = "חודש";
                this.dateToSearch = DateTime.Today.AddMonths(-1);
            }
            else if (tbTrackBar.Value == 2)
            {
                this.dateToSearch = DateTime.Today.AddMonths(-6);
            }

            this.PerformWorkersSearch();
        }

        private void PerformWorkersSearch()
        {
            throw new NotImplementedException();
        }
    }
}
