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
        public string WorkerName;
        public int nOrderID;
        public double dDaysInTime;
        public double dDaysLate;
    }

    public partial class ManagerReportForm : Form
    {
        private int nSelectedDepartmentID = 0;

        private List<tbl_employees> allEmployees;
        private Dictionary<int, string> dcEmployees;
        private Dictionary<DateTime, WorkerData> dcWorkerData = new Dictionary<DateTime, WorkerData>();
        private Dictionary<int, string> dcStationData = new Dictionary<int, string>();

        private List<StationData> lstCurrChartData = new List<StationData>();
        private List<StationData> lstMonthData = new List<StationData>();

        private DateTime dtToDate = new DateTime();
        private DateTime dtToDateStation = new DateTime();

        private DateTime OriginalValue = new DateTime();
        private DateTime OriginalValueStation = new DateTime();

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

            foreach (tbl_user_groups userGroup in Globals.AllUserGroups)
            {
                // User group 0 is null
                if(userGroup.ID != 0 &&
                   userGroup.ID != Globals.AdminID)
                {
                    if (nSelectedDepartmentID == 0)
                    {
                        nSelectedDepartmentID = userGroup.ID;
                    }

                    lbDepartment.Items.Add(userGroup.name);
                }
            }

            if (lbDepartment.Items.Count > 0)
            {
                lbDepartment.SelectedIndex = 0;
            }

            foreach (tbl_employees emp in allEmployees)
            {
                dcEmployees.Add(emp.ID, emp.name);
                lbEmployees.Items.Add(emp.name);

                if(emp.Department_id == this.nSelectedDepartmentID)
                {
                    lbWorkersInDept.Items.Add(emp.name);
                }
            }

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

            //dtTo.Format = DateTimePickerFormat.Custom;
            //dtTo.CustomFormat = "dd/MM/yyyy";
            //dtTo.MaxDate = DateTime.Today;
            //dtTo.MinDate = DateTime.Today.Date.AddYears(-1);
            //dtTo.Value = dtFromDate.Value.AddDays(6);

            tbTrackBar.Value = 0;
            lblPeriod.Text = "עבודות סגורות";

            // this.PerformWorkersSearch();
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

                if (this.OriginalValue < this.dtToDate)
                {
                    int nDaysDifference = int.Parse((this.dtToDate - this.OriginalValue).TotalDays.ToString());
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
                            tbl_orders isOrderFound = this.AllMyJobs.Where(a => a.ID == slaData.order_id).SingleOrDefault<tbl_orders>();

                            if (isOrderFound != null)
                            {
                                tbl_sla_actions ActionData = Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                        .Single<tbl_sla_actions>();

                                if (slaData.begin_date <= this.OriginalValue.AddDays(i) &&
                                    slaData.end_date >= this.OriginalValue.AddDays(i))
                                {
                                    if (slaData.status_id == Globals.SlaLate)
                                    {
                                        if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, this.OriginalValue.AddDays(i)))
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

            this.GetAllMyJobs(nJobStatus);

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

        private List<StationData> SearchStationWeek(List<tbl_sla_data> lstSlaData)
        {
            List<StationData> lstCalculatedList = new List<StationData>();

            if (lbWorkersInDept.SelectedItem.ToString().Equals("כולם"))
            {
                foreach (string strEmpName in lbWorkersInDept.Items)
                {
                    StationData currStationData = new StationData();
                    currStationData.WorkerName = strEmpName;

                    if (strEmpName.Equals("כולם"))
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            foreach (tbl_sla_data slaData in lstSlaData)
                            {
                                tbl_sla_actions ActionData =
                                    Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                            .Single<tbl_sla_actions>();

                                if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                                    slaData.end_date >= this.OriginalValueStation.AddDays(i))
                                {
                                    if (slaData.status_id == Globals.SlaLate)
                                    {
                                        if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                        {
                                            currStationData.dDaysInTime++;
                                        }
                                        else
                                        {
                                            currStationData.dDaysLate++;
                                        }
                                    }
                                    else if (slaData.status_id == Globals.SlaInTime)
                                    {
                                        currStationData.dDaysInTime++;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        List<tbl_sla_data> lstMySlaData = lstSlaData
                            .Where(a => a.employee_name.Equals(strEmpName))
                                    .ToList<tbl_sla_data>();

                        for (int i = 0; i < 7; i++)
                        {
                            foreach (tbl_sla_data slaData in lstMySlaData)
                            {
                                tbl_sla_actions ActionData =
                                    Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                            .Single<tbl_sla_actions>();

                                if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                                    slaData.end_date >= this.OriginalValueStation.AddDays(i))
                                {
                                    if (slaData.status_id == Globals.SlaLate)
                                    {
                                        if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                        {
                                            currStationData.dDaysInTime++;
                                        }
                                        else
                                        {
                                            currStationData.dDaysLate++;
                                        }
                                    }
                                    else if (slaData.status_id == Globals.SlaInTime)
                                    {
                                        currStationData.dDaysInTime++;
                                    }
                                }
                            }
                        }
                    }

                    lstCalculatedList.Add(currStationData);
                }
            }
            else
            {
                List<tbl_sla_data> lstMySlaData = lstSlaData
                            .Where(a => a.employee_name.Equals(lbWorkersInDept.SelectedItem.ToString()))
                                    .ToList<tbl_sla_data>();

                StationData currStationData = new StationData();
                currStationData.WorkerName = lbWorkersInDept.SelectedItem.ToString();

                for (int i = 0; i < 7; i++)
                {
                    foreach (tbl_sla_data slaData in lstMySlaData)
                    {
                        tbl_sla_actions ActionData =
                            Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                    .Single<tbl_sla_actions>();

                        if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                            slaData.end_date >= this.OriginalValueStation.AddDays(i))
                        {
                            if (slaData.status_id == Globals.SlaLate)
                            {
                                if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                {
                                    currStationData.dDaysInTime++;
                                    currStationData.nOrderID = slaData.order_id;

                                    this.lstCurrChartData.Add(currStationData);
                                }
                                else
                                {
                                    currStationData.dDaysLate++;
                                    currStationData.nOrderID = slaData.order_id;

                                    this.lstCurrChartData.Add(currStationData);
                                }
                            }
                            else if (slaData.status_id == Globals.SlaInTime)
                            {
                                currStationData.dDaysInTime++;
                                currStationData.nOrderID = slaData.order_id;

                                this.lstCurrChartData.Add(currStationData);
                            }
                        }
                    }
                }

                lstCalculatedList.Add(currStationData);
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
            if (tbTrackBar.Value == 0)
            {
                lstToChart = this.Search(lstSlaData, Globals.StatusClosed);
            }
            // דוח לגבי עבודות בתהליך
            else if (tbTrackBar.Value == 1)
            {
                lstToChart = this.Search(lstSlaData, Globals.StatusInWork);
            }

            foreach (var row in lstToChart)
            {
                chartWorkers.Series["בזמן"].Points.AddXY(row.DayName, row.workInProcess);
                chartWorkers.Series["מאחר"].Points.AddXY(row.DayName, row.lateWorks);
            }
        }

        private void PerformStationsSearch()
        {
            this.OriginalValueStation = this.dtFrom.Value;

            List<StationData> lstToChart = new List<StationData>();

            chartStations.Series["בזמן"].Points.Clear();
            chartStations.Series["מאחר"].Points.Clear();

            if (Globals.AllSlaData == null)
            {
                Utilities.GetAllSlaData();
            }

            List<tbl_sla_data> lstSlaDeptData = Globals.AllSlaData
                .Where(a => a.user_id == nSelectedDepartmentID &&
                            a.end_date >= this.dtFrom.Value).ToList<tbl_sla_data>();

            if (lstSlaDeptData.Count == 0)
            {
                tbPanel.Text = "לא נמצא מידע עבור מחלקה זו";
            }
            else
            {
                tbPanel.Text = "";

                // Search station week
                if (rbStationWeek.Checked)
                {
                    this.lstCurrChartData.Clear();
                    this.dtToDateStation = this.dtFrom.Value.AddDays(7);
                    lstToChart = this.SearchStationWeek(lstSlaDeptData);
                }
                else if (rbStationMonth.Checked &&
                        this.dtFrom.Value.Day == 1)
                {
                    this.lstMonthData.Clear();
                    this.lstCurrChartData.Clear();

                    this.OriginalValueStation = this.dtFrom.Value;

                    List<StationData> lstCalculatedList = new List<StationData>();

                    this.dtToDateStation = new DateTime(dtFrom.Value.Year,
                                                        dtFrom.Value.Month,
                                                        DateTime.DaysInMonth(dtFrom.Value.Year, this.dtFrom.Value.Month));

                    for (int i = 0; i < 4; i++)
                    {
                        List<StationData> lstTempList = this.SearchStationWeek(lstSlaDeptData);

                        foreach (StationData stationData in lstTempList)
                        {
                            this.lstMonthData.Add(stationData);
                        }

                        this.OriginalValueStation = this.OriginalValueStation.AddDays(7);
                    }

                    if ((this.dtToDateStation - this.OriginalValueStation).TotalDays > 0)
                    {
                        int nDateDifference = (int)(this.dtToDateStation - this.OriginalValueStation).TotalDays;

                        if (lbWorkersInDept.SelectedItem.ToString().Equals("כולם"))
                        {
                            foreach (string strEmpName in lbWorkersInDept.Items)
                            {
                                StationData currStationData = new StationData();
                                currStationData.WorkerName = strEmpName;

                                if (strEmpName.Equals("כולם"))
                                {
                                    for (int i = 0; i < nDateDifference; i++)
                                    {
                                        foreach (tbl_sla_data slaData in lstSlaDeptData)
                                        {
                                            tbl_sla_actions ActionData =
                                                Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                                        .Single<tbl_sla_actions>();

                                            if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                                                slaData.end_date >= this.OriginalValueStation.AddDays(i))
                                            {
                                                if (slaData.status_id == Globals.SlaLate)
                                                {
                                                    if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                                    {
                                                        currStationData.dDaysInTime++;
                                                    }
                                                    else
                                                    {
                                                        currStationData.dDaysLate++;
                                                    }
                                                }
                                                else if (slaData.status_id == Globals.SlaInTime)
                                                {
                                                    currStationData.dDaysInTime++;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    List<tbl_sla_data> lstMySlaData = lstSlaDeptData
                                        .Where(a => a.employee_name.Equals(strEmpName))
                                                .ToList<tbl_sla_data>();

                                    for (int i = 0; i < nDateDifference; i++)
                                    {
                                        foreach (tbl_sla_data slaData in lstMySlaData)
                                        {
                                            tbl_sla_actions ActionData =
                                                Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                                        .Single<tbl_sla_actions>();

                                            if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                                                slaData.end_date >= this.OriginalValueStation.AddDays(i))
                                            {
                                                if (slaData.status_id == Globals.SlaLate)
                                                {
                                                    if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                                    {
                                                        currStationData.dDaysInTime++;
                                                    }
                                                    else
                                                    {
                                                        currStationData.dDaysLate++;
                                                    }
                                                }
                                                else if (slaData.status_id == Globals.SlaInTime)
                                                {
                                                    currStationData.dDaysInTime++;
                                                }
                                            }
                                        }
                                    }
                                }

                                lstCalculatedList.Add(currStationData);
                            }
                        }
                        else
                        {
                            List<tbl_sla_data> lstMySlaData = lstSlaDeptData
                                        .Where(a => a.employee_name.Equals(lbWorkersInDept.SelectedItem.ToString()))
                                                .ToList<tbl_sla_data>();

                            StationData currStationData = new StationData();
                            currStationData.WorkerName = lbWorkersInDept.SelectedItem.ToString();

                            for (int i = 0; i < nDateDifference; i++)
                            {
                                foreach (tbl_sla_data slaData in lstMySlaData)
                                {
                                    tbl_sla_actions ActionData =
                                        Globals.AllActions.Where(a => a.ID == slaData.sla_id)
                                                                .Single<tbl_sla_actions>();

                                    if (slaData.begin_date <= this.OriginalValueStation.AddDays(i) &&
                                        slaData.end_date >= this.OriginalValueStation.AddDays(i))
                                    {
                                        if (slaData.status_id == Globals.SlaLate)
                                        {
                                            if (Utilities.CalculateSlaStatus(slaData.begin_date, new TimeSpan(8, 0, 0), ActionData.sla_hours, OriginalValue.AddDays(i))) //this.dateToSearch.AddDays(i)))
                                            {
                                                currStationData.dDaysInTime++;
                                                currStationData.nOrderID = slaData.order_id;

                                                this.lstCurrChartData.Add(currStationData);
                                            }
                                            else
                                            {
                                                currStationData.dDaysLate++;
                                                currStationData.nOrderID = slaData.order_id;

                                                this.lstCurrChartData.Add(currStationData);
                                            }
                                        }
                                        else if (slaData.status_id == Globals.SlaInTime)
                                        {
                                            currStationData.dDaysInTime++;
                                            currStationData.nOrderID = slaData.order_id;

                                            this.lstCurrChartData.Add(currStationData);
                                        }
                                    }
                                }
                            }

                            lstCalculatedList.Add(currStationData);
                        }
                    }

                    foreach (StationData stationData in lstCalculatedList)
                    {
                        this.lstMonthData.Add(stationData);
                    }
                }
                else
                {
                    tbPanel.Text = "עליך לבחור את היום הראשון בחודש על מנת לחפש חודש קלנדרי";
                }
            }

            if (rbStationMonth.Checked &&
                this.dtFrom.Value.Day == 1)
            {
                Dictionary<string, StationData> dcData = new Dictionary<string, StationData>();
                string strFirstEmp = string.Empty;

                for (int i = 0; i < this.lstMonthData.Count; i++)
                { 
                    if (i == 0)
                    {
                        strFirstEmp = this.lstMonthData[0].WorkerName;
                    }

                    if (i > 0 &&
                        this.lstMonthData[i].WorkerName.Equals(strFirstEmp))
                    {
                        break;
                    }

                    StationData currStationData = new StationData();

                    dcData.Add(this.lstMonthData[i].WorkerName, this.lstMonthData[i]);
                    currStationData.WorkerName = this.lstMonthData[i].WorkerName;
                    currStationData.dDaysInTime = this.lstMonthData[i].dDaysInTime;
                    currStationData.dDaysLate = this.lstMonthData[i].dDaysLate;

                    for (int j = 0; j < this.lstMonthData.Count; j++)
                    {
                        
                        if(i != j &&
                           this.lstMonthData[j].WorkerName.Equals(this.lstMonthData[i].WorkerName))
                        {
                            if(dcData.ContainsKey(this.lstMonthData[j].WorkerName))
                            {
                                currStationData.dDaysInTime += this.lstMonthData[j].dDaysInTime;
                                currStationData.dDaysLate += this.lstMonthData[j].dDaysLate;
                            }
                        }
                    }

                    lstToChart.Add(currStationData);
                }
            }

            foreach (var row in lstToChart)
            {
                chartStations.Series["בזמן"].Points.AddXY(row.WorkerName, row.dDaysInTime);
                chartStations.Series["מאחר"].Points.AddXY(row.WorkerName, row.dDaysLate);
            }
        }

        private void lbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbWorkersInDept.Items.Clear();
            lbWorkersInDept.Items.Add("כולם");
            lbWorkersInDept.SelectedIndex = 0;

            nSelectedDepartmentID = Globals.AllUserGroups.
                        Where(a => a.name.Equals(lbDepartment.SelectedItem.ToString()))
                            .Single<tbl_user_groups>().ID;

            foreach (tbl_employees employee in allEmployees)
            {
                if(employee.Department_id == nSelectedDepartmentID)
                {
                    lbWorkersInDept.Items.Add(employee.name);
                }
            }

            this.PerformStationsSearch();
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

        private void rbStationWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStationWeek.Checked)
            {
                rbStationMonth.Checked = false;
            }

            this.PerformStationsSearch();
        }

        private void rbStationMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(rbStationMonth.Checked)
            {
                rbStationWeek.Checked = false;
            }
        }

        private void chartStations_Click(object sender, EventArgs e)
        {
            if (lbWorkersInDept.SelectedItem.ToString().Equals("כולם"))
            {
                tbPanel.Text = "עליך לבחור עובד ספציפי על מנת לראות נתונים על העבודות שביצע";
            }
            else
            {
                tbPanel.Text = String.Empty;

                List<int> lstOrdersId = new List<int>();

                if(this.lstCurrChartData.Count > 0)
                {
                    foreach (StationData currItem in lstCurrChartData)
                    {
                        if (currItem.WorkerName.Equals(lbWorkersInDept.SelectedItem.ToString()))
                        {
                            lstOrdersId.Add(currItem.nOrderID);
                        }
                    }

                    new AdminOverviewForm(lstOrdersId).ShowDialog();
                }
                else
                {
                    tbPanel.Text = "אין עבודות להצגה על עובד זה";
                }
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            this.PerformStationsSearch();
        }

        private void lbWorkersInDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PerformStationsSearch();
        }

        private void pbStationRefresh_Click(object sender, EventArgs e)
        {
            pbRefresh_Click(new object(), new EventArgs());
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
