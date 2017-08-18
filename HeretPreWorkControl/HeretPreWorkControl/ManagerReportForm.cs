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
            Utilities.GetAllActionsList();

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
                lblPeriod.Text = "חצי שנה";
                this.dateToSearch = DateTime.Today.AddMonths(-6);
            }

            this.PerformWorkersSearch();
        }

        private void PerformWorkersSearch()
        {
            List<WorkerData> lstToChart = new List<WorkerData>();

            chartWorkers.Series["בתהליך"].Points.Clear();
            chartWorkers.Series["מאחר"].Points.Clear();

            if (Globals.AllSlaData == null)
            {
                Utilities.GetAllSlaData();
            }

            List<tbl_sla_data> lstSlaData = Globals.AllSlaData
                .Where(a => a.employee_name != null &&
                            a.employee_name.Equals(lbEmployees.SelectedItem.ToString()) &&
                                                   a.end_date >= this.dateToSearch)
                            .ToList<tbl_sla_data>();

            // לחפש שבוע אחרון
            if(tbTrackBar.Value == 0 &&
               this.dateToSearch.Year != 1)
            {
                lstToChart = this.SearchWeek(lstSlaData);
            }
            // דוח לגבי חיפוש של חודש אחרון
            else if(tbTrackBar.Value == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    List<WorkerData> lstTempCalc = this.SearchWeek(lstSlaData);

                    WorkerData currWorkerData = new WorkerData();
                    
                    currWorkerData.DayName = lstTempCalc[0].DayName.Substring(lstTempCalc[0].DayName.IndexOf('/') - 2);

                    foreach (var TempWorkerData in lstTempCalc)
                    {
                        currWorkerData.lateWorks += TempWorkerData.lateWorks;
                        currWorkerData.workInProcess += TempWorkerData.workInProcess;
                    }

                    lstToChart.Add(currWorkerData);

                    this.dateToSearch = this.dateToSearch.AddDays(7);
                }

                if (this.dateToSearch < DateTime.Today)
                {
                    int nDaysDifference = int.Parse((DateTime.Today - this.dateToSearch).TotalDays.ToString());
                    List<WorkerData> lstCalculatedList = new List<WorkerData>();

                    int nLateWorks = 0, nWorksInTime = 0;
                    string strDayName = String.Empty;

                    for (int i = 0; i < nDaysDifference; i++)
                    {
                        if (i == 0)
                        {
                            strDayName += " " + Utilities.GetDateInNormalFormat(this.dateToSearch);
                        }

                        foreach (tbl_sla_data slaData in lstSlaData)
                        {
                            tbl_sla_actions ActionData = Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                        .Single<tbl_sla_actions>();

                            if (slaData.begin_date <= this.dateToSearch.AddDays(i) &&
                                slaData.end_date >= this.dateToSearch.AddDays(i))
                            {
                                if (slaData.status_id == Globals.SlaLate)
                                {
                                    if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, this.dateToSearch.AddDays(i)))
                                    {
                                        nWorksInTime++;
                                    }
                                    else
                                    {
                                        nLateWorks++;
                                    }
                                }
                                else if (slaData.status_id == Globals.SlaInTime)
                                {
                                    nWorksInTime++;
                                }
                            }
                        }
                    }

                    lstToChart.Add(new WorkerData()
                    {
                        DayName = strDayName,
                        lateWorks = nLateWorks,
                        workInProcess = nWorksInTime,
                    });
                }
                // TODO: half year calc
                else if (tbTrackBar.Value == 2)
                {

                }
            }

            foreach (var row in lstToChart)
            {
                chartWorkers.Series["בתהליך"].Points.AddXY(row.DayName, row.workInProcess);
                chartWorkers.Series["מאחר"].Points.AddXY(row.DayName, row.lateWorks);
            }
        }

        private List<WorkerData> SearchWeek(List<tbl_sla_data> lstSlaData)
        {
            List<WorkerData> lstCalculatedList = new List<WorkerData>();

            for (int i = 0; i < 7; i++)
            {
                WorkerData currWorkerData = new WorkerData();

                currWorkerData.Date = this.dateToSearch.AddDays(i);
                currWorkerData.DayName = this.GetDayNameFormDate(currWorkerData.Date);
                currWorkerData.DayName += " " + Utilities.GetDateInNormalFormat(currWorkerData.Date);

                foreach (tbl_sla_data slaData in lstSlaData)
                {
                    tbl_sla_actions ActionData = Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                        .Single<tbl_sla_actions>();

                    if (slaData.begin_date <= currWorkerData.Date &&
                        slaData.end_date >= currWorkerData.Date)
                    {
                        if (slaData.status_id == Globals.SlaLate)
                        {
                            if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, this.dateToSearch.AddDays(i)))
                            {
                                currWorkerData.workInProcess++; 
                            }
                            else
                            {
                                currWorkerData.lateWorks++;
                            }
                        }
                        else if (slaData.status_id == Globals.SlaInTime)
                        {
                            currWorkerData.workInProcess++;
                        }
                    }
                }

                lstCalculatedList.Add(currWorkerData);
            }

            return lstCalculatedList;
        }

        private string GetDayNameFormDate(DateTime dateTime)
        {
            return this.GetHebrewName(dateTime.DayOfWeek.ToString());
        }

        private string GetHebrewName(string strEnglishName)
        {
            string strToReturn = String.Empty;

            switch (strEnglishName)
            {
                case ("Monday"):
                    strToReturn = "שני";
                    break;
                case ("Tuesday"):
                    strToReturn = "שלישי";
                    break;
                case ("Wednesday"):
                    strToReturn = "רביעי";
                    break;
                case ("Thursday"):
                    strToReturn = "חמישי";
                    break;
                case ("Friday"):
                    strToReturn = "שישי";
                    break;
                case ("Saturday"):
                    strToReturn = "שבת";
                    break;
                case ("Sunday"):
                    strToReturn = "ראשון";
                    break;
                default:
                    break;
            }

            return strToReturn;
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTrackBar.Value == 0)
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
                lblPeriod.Text = "חצי שנה";
                this.dateToSearch = DateTime.Today.AddMonths(-6);
            }

            this.PerformWorkersSearch();
        }
    }
}
