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
        Boolean isLoadSucceeded = false;

        private List<int> lstOrdersID = new List<int>();
        Boolean isList = false;
        private List<RowData> lstAllViewData = new List<RowData>();

        public AdminOverviewForm()
        {
            InitializeComponent();
        }

        public AdminOverviewForm(List<int> lstOrders)
        {
            InitializeComponent();
            isList = true;
            this.lstOrdersID = lstOrders;
        }

        private void AdminOverviewForm_Load(object sender, EventArgs e)
        {
            isLoadSucceeded = Utilities.GetAllJobs();

            if(isLoadSucceeded)
            { 
                if(Globals.AllJobs.Count == 0)
                {
                    tbPanel.Text = "אין עבודות התואמות את נתוני החיפוש";
                }
                else if(isList)
                {
                    Utilities.GetAllClientsList();
                    Utilities.GetAllUserGroupList();
                    Utilities.GetAllActionsList();
                    Utilities.SetZebraMode(dataGridView);

                    dtFromDate.Visible = false;
                    lbJobStatus.Visible = false;

                    List<tbl_orders> detailedList = 
                        Globals.AllJobs.Where(a => lstOrdersID.Contains(a.ID)).ToList<tbl_orders>();

                    foreach (tbl_orders order in detailedList)
                    {
                        if (order.creation_date.Value >= dtFromDate.Value)
                        {
                            if (order.special_department_id != null &&
                                order.special_department_id != Globals.AdminID)
                            {
                                InsertSpecialRow(order);
                            }

                            InsertRowFromOrder(order);
                        }

                        if (order.special_department_id != null &&
                            order.special_department_id != Globals.AdminID)
                        {
                            AddSpecialToInternalTable(order);
                        }

                        AddToInternalTable(order);
                    }
                }
                else
                {
                    Utilities.GetAllClientsList();
                    Utilities.GetAllUserGroupList();
                    Utilities.GetAllActionsList();
                    Utilities.SetZebraMode(dataGridView);

                    dtFromDate.Format = DateTimePickerFormat.Custom;
                    dtFromDate.CustomFormat = "dd/MM/yyyy";
                    dtFromDate.MaxDate = DateTime.Today;
                    dtFromDate.MinDate = DateTime.Today.Date.AddYears(-1);
                    dtFromDate.Value = DateTime.Today.Date.AddMonths(-1);

                    lbJobStatus.Items.Add(Globals.StatusJobAll);
                    lbJobStatus.Items.Add(Globals.StatusJobInWork);
                    lbJobStatus.Items.Add(Globals.StatusJobClosed);
                    lbJobStatus.Items.Add(Globals.StatusJobDenied);

                    lbJobStatus.SelectedIndex = 0;

                    foreach (tbl_orders order in Globals.AllJobs)
                    {
                        if (order.creation_date.Value >= dtFromDate.Value)
                        {
                            if (order.special_department_id != null &&
                                order.special_department_id != Globals.AdminID)
                            {
                                InsertSpecialRow(order);
                            }

                            InsertRowFromOrder(order);
                        }

                        if (order.special_department_id != null &&
                            order.special_department_id != Globals.AdminID)
                        {
                            AddSpecialToInternalTable(order);
                        }

                        AddToInternalTable(order);
                    }
                }
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }

            if(Globals.UserGroupID == Globals.SalesUserID)
            {
                label3.Visible = false;
                pbReminder.Visible = false;
            }
        }

        private void AddSpecialToInternalTable(tbl_orders order)
        {
            string strClientName = Globals.AllClients
                .Where(c => c.ID == order.client_id.Value).Single<tbl_clients>().name;

            string strJobStatus = Utilities.GetStatusDesc(order.current_status_id);

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

            RowData row = new RowData();
            row.OrderID = order.ID;
            row.JobStatus = strJobStatus;
            row.SlaStatus = strSlaStatus;
            row.CreationDate = order.creation_date.Value.Date;
            row.CurrentDepartment = strCurrDepartment;
            row.ClientName = strClientName;

            lstAllViewData.Add(row);
        }

        private void AddToInternalTable(tbl_orders order)
        {
            string strJobStatus = Utilities.GetStatusDesc(order.current_status_id);

            string strClientName = Globals.AllClients
               .Where(c => c.ID == order.client_id.Value).Single<tbl_clients>().name;

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

            RowData row = new RowData();
            row.OrderID = order.ID;
            row.JobStatus = strJobStatus;
            row.SlaStatus = strSlaStatus;
            row.CreationDate = order.creation_date.Value.Date;
            row.CurrentDepartment = strCurrDepartment;
            row.ClientName = strClientName;

            lstAllViewData.Add(row);
        }

        private void InsertSpecialRow(tbl_orders order)
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

            string strThirdCol = Utilities.GetFilledDataFromOrder(order);

            dataGridView.Rows.Add(strOrderID, strClientName, strJobStatus,
                                  strCurrDepartment, strCreationDate, strSlaStatus, strThirdCol);
        }

        private void InsertRowFromOrder(tbl_orders order)
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

            string strThirdCol = Utilities.GetFilledDataFromOrder(order);

            dataGridView.Rows.Add(strOrderID, strClientName, strJobStatus,
                                  strCurrDepartment, strCreationDate, strSlaStatus, strThirdCol);
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (lstAllViewData != null)
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
                    else if(lbJobStatus.SelectedItem.Equals(Globals.StatusJobDenied))
                    {
                        lstTempList = lstAllViewData.Where(a => a.CreationDate >= dtFromDate.Value &&
                                                           a.JobStatus == Globals.StatusJobDenied).ToList<RowData>();
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

            if (isLoadSucceeded)
            {
                tbPanel.Text = "ריענון בוצע בהצלחה";
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }
        }

        private tbl_orders GetSelectedOrder()
        {
            tbl_orders orderToReturn = null;

            if (dataGridView.SelectedRows.Count == 0)
            {
                tbPanel.Text = "שגיאה! עליך לסמן את אחת השורות";
            }
            else if (dataGridView.SelectedRows.Count > 1)
            {
                tbPanel.Text = "שגיאה! עליך לבחור עבודה אחת בכל פעם";
            }
            else
            {
                if (dataGridView.SelectedRows[0].Cells[0].Value != null)
                {
                    // Get all the data about the selected row
                    int nOrderID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    string strClientName = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

                    int nClientID = Globals.AllClients.Where(a => a.name == strClientName).First<tbl_clients>().ID;

                    tbl_orders SelectedOrder =
                            Globals.AllJobs.Where(m => m.ID == nOrderID &&
                                                      m.client_id == nClientID).SingleOrDefault<tbl_orders>();

                    if (SelectedOrder == null)
                    {
                        tbPanel.Text = "שגיאה! יש תקלה באמינות הנתונים אנא רענן ונסה שוב";
                    }
                    else
                    {
                        orderToReturn = SelectedOrder;
                    }
                }
            }

            return orderToReturn;
        }

        private int GetSelectedDepartmentID()
        {
            int nSelectedDepartID = -1;

            if (dataGridView.SelectedRows.Count == 0)
            {
                tbPanel.Text = "שגיאה! עליך לסמן את אחת השורות";
            }
            else if (dataGridView.SelectedRows.Count > 1)
            {
                tbPanel.Text = "שגיאה! עליך לבחור עבודה אחת בכל פעם";
            }
            else
            {
                if (dataGridView.SelectedRows[0].Cells[0].Value != null)
                {
                    string strDeptName = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    tbl_user_groups userGroup = Globals.AllUserGroups.Where(u => u.name.Equals(strDeptName)).SingleOrDefault<tbl_user_groups>();

                    if (userGroup == null)
                    {
                        tbPanel.Text = "שגיאה! יש תקלה באמינות הנתונים אנא צא וכנס למערכת";
                    }
                    else
                    {
                        nSelectedDepartID = userGroup.ID;
                    }
                }
            }

            return nSelectedDepartID;
        }

        private void pbEditOrderInfo_Click(object sender, EventArgs e)
        {
            tbl_orders selectedOrder = this.GetSelectedOrder();

            if (selectedOrder != null)
            {
                new ViewAllOrderDetails(selectedOrder).Show();
            }
        }

        private void pbReminder_Click(object sender, EventArgs e)
        {
            tbl_orders order = this.GetSelectedOrder();

            if(order.current_status_id == Globals.StatusClosed)
            {
                tbPanel.Text = "אין באפשרותך לתזכר ביצוע עבודה לעבודה סגורה";
            }
            else
            {
                int nDepartToNotify = this.GetSelectedDepartmentID();

                if (nDepartToNotify != -1)
                {
                    if (order == null)
                    {
                        tbPanel.Text = "שגיאה באמינות הנתונים אנא צא וכנס מהמערכת";
                    }
                    else
                    {
                        tbl_notifications currNotification = new tbl_notifications();
                        currNotification.ID = Utilities.GetNextNotificationID();
                        currNotification.order_id = order.ID;
                        currNotification.Deparment_id = nDepartToNotify;
                        currNotification.is_notified = 0;

                        using (var context = new DB_Entities())
                        {
                            try
                            {
                                context.tbl_notifications.Add(currNotification);
                                context.SaveChanges();

                                tbPanel.Text = "ההתראה נשלחה בהצלחה";
                            }
                            catch (Exception ex)
                            {
                                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                            }
                        }
                    }
                }
            }
        }
    }
}
