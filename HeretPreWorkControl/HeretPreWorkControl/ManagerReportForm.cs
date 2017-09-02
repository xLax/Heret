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

    struct StationData
    {
        public string OrderID;
        public double dDaysInTime;
        public double dDaysLate;
    }

    public partial class ManagerReportForm : Form
    {
        private List<tbl_employees> allEmployees;
        private Dictionary<int, string> dcEmployees;
        private Dictionary<DateTime, WorkerData> dcWorkerData = new Dictionary<DateTime, WorkerData>();
        private Dictionary<int, string> dcStationData = new Dictionary<int, string>();
        private tbl_sla_actions actionToSearch = new tbl_sla_actions();

        private DateTime dtToDate = new DateTime();
        private DateTime OriginalValue = new DateTime();

        public List<tbl_orders> AllMyJobs;

        public ManagerReportForm()
        {
            Utilities.GetAllSlaData();
            Utilities.GetAllActionsList();

            InitializeComponent();

            Utilities.AllEmployeesForResponsible();
            Utilities.GetAllActionsList();
            Utilities.GetAllUserGroupList();

            dcEmployees = new Dictionary<int, string>();
            allEmployees = Globals.AllEmployeesResp
                .Where( a => a.Department_id != 0).ToList<tbl_employees>();

            foreach (tbl_employees emp in allEmployees)
            {
                dcEmployees.Add(emp.ID, emp.name);
                lbEmployees.Items.Add(emp.name);
            }

            foreach (tbl_user_groups userGroup in Globals.AllUserGroups)
            {
                // User group 0 is null
                if(userGroup.ID != 0 &&
                   userGroup.ID != Globals.AdminID)
                {
                    lbDepartment.Items.Add(userGroup.name);
                }
            }

            if(lbDepartment.Items.Count > 0)
            {
                lbDepartment.SelectedIndex = 0;
            }

            PopulateStationList();

            if (allEmployees.Count > 0)
            {
                lbEmployees.SelectedIndex = 0;
            }

            dtFromDate.Format = DateTimePickerFormat.Custom;
            dtFromDate.CustomFormat = "dd/MM/yyyy";
            dtFromDate.MaxDate = DateTime.Today;
            dtFromDate.MinDate = DateTime.Today.Date.AddYears(-1);
            DateTime tempLastWeekDate = DateTime.Today.Date.AddDays(-7);
            dtFromDate.Value = tempLastWeekDate.StartOfWeek(DayOfWeek.Sunday);

            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.MaxDate = DateTime.Today;
            dtFrom.MinDate = DateTime.Today.Date.AddYears(-1);
            dtFrom.Value = tempLastWeekDate.StartOfWeek(DayOfWeek.Sunday);

            //dtToDate.Format = DateTimePickerFormat.Custom;
            //dtToDate.CustomFormat = "dd/MM/yyyy";
            //dtToDate.MaxDate = DateTime.Today;
            //dtToDate.MinDate = DateTime.Today.Date.AddYears(-1);
            //dtToDate.Value = dtFromDate.Value.AddDays(6);

            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.MaxDate = DateTime.Today;
            dtTo.MinDate = DateTime.Today.Date.AddYears(-1);
            dtTo.Value = dtFromDate.Value.AddDays(6);

            tbTrackBar.Value = 0;
            lblPeriod.Text = "עבודות סגורות";

            // this.PerformWorkersSearch();
        }

        private void PopulateStationList()
        {
            lbStation.Items.Clear();
            dcStationData.Clear();

            tbl_user_groups currGroup = Globals.AllUserGroups
                .Where(a => a.name.Equals(lbDepartment.SelectedItem.ToString())).Single<tbl_user_groups>();

            foreach (tbl_sla_actions action in Globals.AllActions)
            {
                if (action.department_id == currGroup.ID)
                {
                    if(action.ID != 0)
                    {
                        lbStation.Items.Add(action.desc);
                        dcStationData.Add(action.ID, action.desc);
                    }
                }
            }
            
            if(lbStation.Items.Count > 0)
            {
                lbStation.SelectedIndex = 0;
            }
        }

        private void tbTrackBar_Scroll(object sender, EventArgs e)
        {
            if(tbTrackBar.Value == 0)
            {
                lblPeriod.Text = "עבודות סגורות";
            }
            else if (tbTrackBar.Value == 1)
            {
                lblPeriod.Text = "עבודות בתהליך";
            }

            this.PerformWorkersSearch();
        }

        private void PerformWorkersSearch()
        {
            this.OriginalValue = dtFromDate.Value;

            List<WorkerData> lstToChart = new List<WorkerData>();

            chartWorkers.Series["בזמן"].Points.Clear();
            chartWorkers.Series["מאחר"].Points.Clear();

            if (Globals.AllSlaData == null)
            {
                Utilities.GetAllSlaData();
            }

            List<tbl_sla_data> lstSlaData = Globals.AllSlaData
                .Where(a => a.employee_name != null &&
                            a.employee_name.Equals(lbEmployees.SelectedItem.ToString()) &&
                                                   a.end_date >= this.dtFromDate.Value)
                            .ToList<tbl_sla_data>();

            // לחפש עבודות סגורות
            if(tbTrackBar.Value == 0)
            {
                lstToChart = this.Search(lstSlaData, Globals.StatusClosed);
            }
            // דוח לגבי עבודות בתהליך
            else if(tbTrackBar.Value == 1)
            {
                lstToChart = this.Search(lstSlaData, Globals.StatusInWork);
            }

            foreach (var row in lstToChart)
            {
                chartWorkers.Series["בזמן"].Points.AddXY(row.DayName, row.workInProcess);
                chartWorkers.Series["מאחר"].Points.AddXY(row.DayName, row.lateWorks);
            }
        }

        private List<WorkerData> Search(List<tbl_sla_data> lstSlaData ,int nJobStatus)
        {
            List<WorkerData> lstToReturn = new List<WorkerData>();

            // Search Calender Week
            if (rbWeek.Checked)
            {
                tbPanel.Text = "";
                this.AllMyJobs = new List<tbl_orders>();
                lstToReturn = this.SearchWeek(lstSlaData, nJobStatus);
            }
            
            // Search Calender Month
            else if (rbMonth.Checked &&
                     this.OriginalValue.Day == 1)
            {
                tbPanel.Text = "";
                this.AllMyJobs = new List<tbl_orders>();

                // Gets the last date of the month
                dtToDate = new DateTime(dtFromDate.Value.Year,
                                        this.dtFromDate.Value.Month,
                                        DateTime.DaysInMonth(dtFromDate.Value.Year, this.dtFromDate.Value.Month));

                for (int i = 0; i < 4; i++)
                {
                    List<WorkerData> lstTempCalc = this.SearchWeek(lstSlaData, nJobStatus);

                    WorkerData currWorkerData = new WorkerData();

                    currWorkerData.DayName = lstTempCalc[0].DayName.Substring(lstTempCalc[0].DayName.IndexOf('/') - 2);

                    foreach (var TempWorkerData in lstTempCalc)
                    {
                        currWorkerData.lateWorks += TempWorkerData.lateWorks;
                        currWorkerData.workInProcess += TempWorkerData.workInProcess;
                    }

                    lstToReturn.Add(currWorkerData);

                    this.OriginalValue = this.OriginalValue.AddDays(7);
                }

                if (this.dtFromDate.Value < this.dtToDate)
                {
                    int nDaysDifference = int.Parse((this.dtToDate - this.dtFromDate.Value).TotalDays.ToString());
                    List<WorkerData> lstCalculatedList = new List<WorkerData>();

                    int nLateWorks = 0, nWorksInTime = 0;
                    string strDayName = String.Empty;

                    for (int i = 0; i < nDaysDifference; i++)
                    {
                        if (i == 0)
                        {
                            strDayName += " " + Utilities.GetDateInNormalFormat(this.OriginalValue);
                        }

                        foreach (tbl_sla_data slaData in lstSlaData)
                        {
                            tbl_sla_actions ActionData = Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                        .Single<tbl_sla_actions>();

                            if (slaData.begin_date <= this.dtFromDate.Value.AddDays(i) &&
                                slaData.end_date >= this.dtFromDate.Value.AddDays(i))
                            {
                                if (slaData.status_id == Globals.SlaLate)
                                {
                                    if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, this.dtFromDate.Value.AddDays(i)))
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

                    lstToReturn.Add(new WorkerData()
                    {
                        DayName = strDayName,
                        lateWorks = nLateWorks,
                        workInProcess = nWorksInTime,
                    });
                }
            }
            else
            {
                tbPanel.Text = "עליך לבחור את היום הראשון בחודש על מנת לחפש חודש קלנדרי";
            }


            return lstToReturn;
        }


        private List<WorkerData> SearchWeek(List<tbl_sla_data> lstSlaData, int nJobStatus)
        {
            List<WorkerData> lstCalculatedList = new List<WorkerData>();

            if (this.AllMyJobs.Count == 0)
            {
                this.GetAllMyJobs(nJobStatus);
            }

            for (int i = 0; i < 7; i++)
            {
                WorkerData currWorkerData = new WorkerData();

                currWorkerData.Date = OriginalValue.AddDays(i);
                currWorkerData.DayName = this.GetDayNameFormDate(currWorkerData.Date);
                currWorkerData.DayName += " " + Utilities.GetDateInNormalFormat(currWorkerData.Date);

                foreach (tbl_sla_data slaData in lstSlaData)
                {
                    tbl_orders isOrderFound = this.AllMyJobs.Where(a => a.ID == slaData.order_id).SingleOrDefault<tbl_orders>();

                    if(isOrderFound != null)
                    {
                        tbl_sla_actions ActionData = Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                        .Single<tbl_sla_actions>();

                        if (slaData.begin_date <= currWorkerData.Date &&
                            slaData.end_date >= currWorkerData.Date)
                        {
                            if (slaData.status_id == Globals.SlaLate)
                            {
                                if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
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
                }

                lstCalculatedList.Add(currWorkerData);
            }

            return lstCalculatedList;
        }

        private void GetAllMyJobs(int nJobStatus)
        {
            using (var context = new DB_Entities())
            {
                try
                {
                    this.AllMyJobs = context.tbl_orders
                        .Where( a => (( a.kadas_agent_name != null &&
                                        a.kadas_agent_name.Equals(lbEmployees.SelectedItem.ToString())) ||
                                      ( a.studio_agent_name != null &&
                                        a.studio_agent_name.Equals(lbEmployees.SelectedItem.ToString()))) &&
                                        a.current_status_id == nJobStatus).ToList<tbl_orders>();
                }
                catch(Exception ex){ }
            }
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
                lblPeriod.Text = "עבודות סגורות";
            }
            else if (tbTrackBar.Value == 1)
            {
                lblPeriod.Text = "עבודות בתהליך";
            }

            this.PerformWorkersSearch();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            int nResult = Utilities.GetAllSlaData();

            if(nResult == 0)
            {
                tbPanel.Text = "רענון בוצע בהצלחה";
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            this.PerformWorkersSearch();
        }

        private void ManagerReportForm_Load(object sender, EventArgs e)
        {

        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            this.PerformStationsSearch();
        }

        private void PerformStationsSearch()
        {
            if(this.actionToSearch == null)
            {
                tbPanel.Text = "אנא בחר תחנה לחיפוש";
            }
            else
            {
                chartStations.Series["בזמן"].Points.Clear();
                chartStations.Series["מאחר"].Points.Clear();

                List<tbl_sla_data> lstSlaData = Globals.AllSlaData
                    .Where(a => a.sla_id == this.actionToSearch.ID &&
                                a.end_date >= this.dtFrom.Value).ToList<tbl_sla_data>();

                IEnumerable<tbl_sla_data> SortedSlaData = lstSlaData.OrderBy(a => a.order_id);

                if(lstSlaData.Count > 0)
                {
                    int nPrevOrderID = SortedSlaData.First<tbl_sla_data>().order_id, nCurrOrderID = 0;
                    double dOrderSumLate = 0, dOrderSumInTime = 0;

                    List<StationData> lstToChart = new List<StationData>();
                    StationData currStationData = new StationData();

                    foreach (var slaData in SortedSlaData)
                    {
                        nCurrOrderID = slaData.order_id;

                        if (nCurrOrderID == nPrevOrderID)
                        {
                            if (slaData.status_id == Globals.SlaLate)
                            {
                                dOrderSumLate += (slaData.end_date - slaData.begin_date).TotalDays + 1;
                            }
                            else if (slaData.status_id == Globals.SlaInTime)
                            {
                                dOrderSumInTime += (slaData.end_date - slaData.begin_date).TotalDays + 1;
                            }
                        }
                        else
                        {
                            currStationData.OrderID = "מס\"ד" + nPrevOrderID.ToString();
                            currStationData.dDaysInTime = dOrderSumInTime;
                            currStationData.dDaysLate = dOrderSumLate;

                            if (slaData.status_id == Globals.SlaLate)
                            {
                                dOrderSumLate = (slaData.end_date - slaData.begin_date).TotalDays + 1;
                            }
                            else if (slaData.status_id == Globals.SlaInTime)
                            {
                                dOrderSumInTime = (slaData.end_date - slaData.begin_date).TotalDays + 1;
                            }

                            lstToChart.Add(currStationData);

                            currStationData = new StationData();
                        }
                    }

                    currStationData = new StationData();

                    currStationData.OrderID = "מס\"ד" + nCurrOrderID.ToString();
                    currStationData.dDaysInTime = dOrderSumInTime;
                    currStationData.dDaysLate = dOrderSumLate;

                    lstToChart.Add(currStationData);

                    foreach (var row in lstToChart)
                    {
                        chartStations.Series["בזמן"].Points.AddXY(row.OrderID, row.dDaysInTime);
                        chartStations.Series["מאחר"].Points.AddXY(row.OrderID, row.dDaysLate);
                    }
                }
            }
        }

        private void lbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateStationList();
        }

        private void lbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nSelectedActionTypeID = 0;

            foreach (var dcItem in dcStationData)
            {
                if(dcItem.Value.Equals(lbStation.SelectedItem.ToString()))
                {
                    nSelectedActionTypeID = dcItem.Key;

                    continue;
                }
            }

            if(nSelectedActionTypeID == 0)
            {
                tbPanel.Text = "שגיאה לא ידועה, אנא התייעץ עם מפתחי המערכת.";
            }
            else
            {
                this.actionToSearch = Globals.AllActions
                    .Where(a => a.ID == nSelectedActionTypeID).Single<tbl_sla_actions>();

                this.PerformStationsSearch();
            }
        }

        private void rbWeek_CheckedChanged(object sender, EventArgs e)
        {
            if(rbWeek.Checked)
            {
                rbMonth.Checked = false;
            }

            this.PerformWorkersSearch();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                rbWeek.Checked = false;
            }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            this.PerformWorkersSearch();
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = dt.DayOfWeek - startOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
