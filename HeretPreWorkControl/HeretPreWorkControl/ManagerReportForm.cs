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
    struct WorkerData
    {
        public DateTime Date;
        public string DayName;
        public int workInProcess;
        public int lateWorks;
    }

    public partial class ManagerReportForm : Form
    {
        private List<tbl_employees> allEmployees;
        private Dictionary<int, string> dcEmployees;
        private Dictionary<DateTime, WorkerData> dcWorkerData = new Dictionary<DateTime, WorkerData>();

        private DateTime dateToSearch;

        public ManagerReportForm()
        {
            Utilities.GetAllSlaData();

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

            this.PerformWorkersSearch();
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
            List<WorkerData> lstToChart = new List<WorkerData>();

            chartWorkers.Series["InWork"].Points.Clear();
            chartWorkers.Series["Late"].Points.Clear();

            if (Globals.AllSlaData == null)
            {
                Utilities.GetAllSlaData();
            }

            List<tbl_sla_data> lstSlaData = Globals.AllSlaData
                .Where(a => a.employee_name != null &&
                            a.employee_name.Equals(lbEmployees.SelectedItem.ToString()) &&
                                                   a.begin_date >= this.dateToSearch)
                            .ToList<tbl_sla_data>();

            // לחפש שבוע אחרון
            if(tbTrackBar.Value == 0 &&
               this.dateToSearch.Year != 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    lstToChart.Add(new WorkerData()
                    {
                        lateWorks = 0, 
                        Date = this.dateToSearch.AddDays(i),
                        DayName = this.GetDayNameFormDate(this.dateToSearch.AddDays(i)),
                        workInProcess = 0
                    });
                }

                




                foreach (var row in lstToChart)
                {
                    chartWorkers.Series["InWork"].Points.AddXY(row.DayName, row.workInProcess);
                    chartWorkers.Series["Late"].Points.AddXY(row.DayName, row.lateWorks);
                }
            }
        }

        private string GetDayNameFormDate(DateTime dateTime)
        {
            return dateTime.DayOfWeek.ToString();
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PerformWorkersSearch();
        }
    }
}
