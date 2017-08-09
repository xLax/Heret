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
    struct RowData
    {
        public int OrderID;
        public string ClientName;
        public string JobStatus;
        public string CurrentDepartment;
        public DateTime CreationDate;
        public string SlaStatus;
    }

    public partial class AdminOverviewForm : Form
    {
        private List<RowData> lstAllViewData = new List<RowData>();

        public AdminOverviewForm()
        {
            InitializeComponent();
        }

        private void AdminOverviewForm_Load(object sender, EventArgs e)
        {
            Utilities.GetAllJobsInWork();
            Utilities.GetAllClientsList();
            Utilities.GetAllUserGroupList();
            Utilities.GetAllActionsList();

            dtFromDate.Format = DateTimePickerFormat.Custom;
            dtFromDate.CustomFormat = "dd/MM/yyyy";
            dtFromDate.MaxDate = DateTime.Today;
            dtFromDate.MinDate = DateTime.Today.Date.AddYears(-12);
            dtFromDate.Value = DateTime.Today.Date.AddYears(-12);

            lbJobStatus.Items.Add(Globals.StatusJobAll);
            lbJobStatus.Items.Add(Globals.StatusJobInWork);
            lbJobStatus.Items.Add(Globals.StatusJobClosed);

            lbJobStatus.SelectedIndex = 0;

            foreach (tbl_orders order in Globals.AllJobs)
            {
                if(order.creation_date.Value >= dtFromDate.Value)
                {
                    if (order.special_department_id != null &&
                   order.special_department_id != Globals.AdminID)
                    {
                        InsertSpecialRow(order, true);
                    }

                    InsertRowFromOrder(order, true);
                }    
            }
        }

        private void InsertSpecialRow(tbl_orders order, Boolean isLoading)
        {
            string strOrderID = order.ID.ToString();

            string strClientName = Globals.AllClients
                .Where(c => c.ID == order.client_id.Value).Single<tbl_clients>().name;

            string strJobStatus = Utilities.GetStatusDesc(order.current_status_id);

            string strCreationDate = Utilities.GetDateInNormalFormat(order.creation_date.Value.Date);

            string strCurrDepartment = String.Empty;
            string strSlaStatus = String.Empty;

            if (order.current_status_id == Globals.StatusInWork)
            {
                strCurrDepartment = Globals.AllUserGroups
                    .Where(u => u.ID == order.special_department_id)
                                .Single<tbl_user_groups>().name;

                // Fifth Col - Getting sla status
                tbl_sla_actions ActionData =
                    Globals.AllActions.Where(a => a.ID == order.special_action_type_id)
                                                    .Single<tbl_sla_actions>();

                Nullable<System.DateTime> recievedDate = order.dep_recieve_date;
                Nullable<System.TimeSpan> recievedHour = order.dep_recieve_hour;

                strSlaStatus = Utilities.CalculateSlaStatus(recievedDate, recievedHour, ActionData.sla_hours);
            }
            else
            {
                strCurrDepartment = "---";
                strSlaStatus = "---";
            }

            string strFifthCol = Utilities.GetDateInNormalFormat(order.creation_date.Value);

            dataGridView.Rows.Add(strOrderID, strClientName, strJobStatus,
                                  strCurrDepartment, strCreationDate, strSlaStatus);

            if(isLoading)
            {
                RowData row = new RowData();
                row.OrderID = order.ID;
                row.JobStatus = strJobStatus;
                row.SlaStatus = strSlaStatus;
                row.CreationDate = order.creation_date.Value.Date;
                row.CurrentDepartment = strCurrDepartment;
                row.ClientName = strClientName;

                lstAllViewData.Add(row);
            }
        }

        private void InsertRowFromOrder(tbl_orders order, Boolean isLoading)
        {
            string strOrderID = order.ID.ToString();

            string strClientName = Globals.AllClients
                .Where(c => c.ID == order.client_id.Value).Single<tbl_clients>().name;

            string strJobStatus = Utilities.GetStatusDesc(order.current_status_id);

            string strCreationDate = Utilities.GetDateInNormalFormat(order.creation_date.Value.Date);

            string strCurrDepartment = String.Empty;
            string strSlaStatus = String.Empty;

            if (order.current_status_id == Globals.StatusInWork)
            {
                strCurrDepartment = Globals.AllUserGroups
                    .Where(u => u.ID == order.curr_departnent_id)
                                .Single<tbl_user_groups>().name;

                // Fifth Col - Getting sla status
                tbl_sla_actions ActionData =
                    Globals.AllActions.Where(a => a.ID == order.action_type_id)
                                                    .Single<tbl_sla_actions>();

                Nullable<System.DateTime> recievedDate = order.dep_recieve_date;
                Nullable<System.TimeSpan> recievedHour = order.dep_recieve_hour;

                strSlaStatus = Utilities.CalculateSlaStatus(recievedDate, recievedHour, ActionData.sla_hours);
            }
            else
            {
                strCurrDepartment = "---";
                strSlaStatus = "---";
            }

            string strFifthCol = Utilities.GetDateInNormalFormat(order.creation_date.Value);

            dataGridView.Rows.Add(strOrderID, strClientName, strJobStatus, 
                                  strCurrDepartment, strCreationDate, strSlaStatus);

            if (isLoading)
            {
                RowData row = new RowData();
                row.OrderID = order.ID;
                row.JobStatus = strJobStatus;
                row.SlaStatus = strSlaStatus;
                row.CreationDate = order.creation_date.Value.Date;
                row.CurrentDepartment = strCurrDepartment;
                row.ClientName = strClientName;

                lstAllViewData.Add(row);
            }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            if(lstAllViewData != null)
            {
                dataGridView.Rows.Clear();

                List<RowData> lstTempList = new List<RowData>();

                if (lbJobStatus.SelectedItem != null)
                {
                    if (lbJobStatus.SelectedItem.Equals(Globals.StatusJobClosed))
                    {
                        lstTempList = lstAllViewData.Where(a => a.CreationDate >= dtFromDate.Value &&
                                                           a.JobStatus == Globals.StatusJobClosed).ToList<RowData>();
                    }
                    else if (lbJobStatus.SelectedItem.Equals(Globals.StatusJobInWork))
                    {
                        lstTempList = lstAllViewData.Where(a => a.CreationDate >= dtFromDate.Value &&
                                                           a.JobStatus == Globals.StatusJobInWork).ToList<RowData>();
                    }
                    else
                    {
                        lstTempList = lstAllViewData.
                            Where(a => a.CreationDate >= dtFromDate.Value).ToList<RowData>();
                    }
                }
                else
                {
                    lstTempList = lstAllViewData.
                            Where(a => a.CreationDate >= dtFromDate.Value).ToList<RowData>();
                }

                foreach (RowData row in lstTempList)
                {
                    dataGridView.Rows.Add(row.OrderID, row.ClientName,
                                          row.JobStatus, row.CurrentDepartment,
                                          Utilities.GetDateInNormalFormat(row.CreationDate),
                                          row.SlaStatus);
                }
            }
        }

        private void lbJobStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtFromDate_ValueChanged(new object(), new EventArgs());
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            lstAllViewData.Clear();
            lbJobStatus.Items.Clear();

            AdminOverviewForm_Load(new object(), new EventArgs());

            tbPanel.Text = "גיטלר";
        }
    }
}
