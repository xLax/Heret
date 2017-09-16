using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class MyJobsForm : Form
    {   
        private DataTable dtTable = new DataTable();
        private List<tbl_orders> MyJobs = new List<tbl_orders>();
        private Boolean isLoadSucceeded = true;
        private Boolean isSpecial = false;

        public static Boolean isJobSucceeded = false;

        private tbl_orders ListSelectedOrder;

        public MyJobsForm()
        {
            InitializeComponent();
        }

        private void MyJobsForm_Load(object sender, EventArgs e)
        {
            if(Globals.UserGroupID != Globals.SalesUserID)
            {
                pbSetDeclinedAndInsert.Visible = false;
                lblEnterDeclined.Visible = false;
            }
            else
            {
                Utilities.GetAllClientsList();
                Utilities.GetAllActionsList();

                foreach (tbl_orders order in Globals.MyJobs)
                {
                    if (order.special_department_id != null &&
                        order.special_department_id == Globals.SalesUserID)
                    {
                        string strClientName = Globals.AllClients.Where(c => c.ID == order.client_id).Single<tbl_clients>().name;

                        string strFilesNo = order.files_number.ToString();

                        // Fourth Col
                        string strThirdCol = Utilities.GetFilledDataFromOrder(order);

                        // Fifth Col - Getting sla status
                        tbl_sla_actions ActionData =
                            Globals.AllActions.Where(a => a.ID == order.special_action_type_id)
                                                            .Single<tbl_sla_actions>();

                        Nullable<System.DateTime> recievedDate = order.dep_recieve_date;
                        Nullable<System.TimeSpan> recievedHour = order.dep_recieve_hour;

                        string strSlaStatus = Utilities.CalculateSlaStatus(recievedDate, recievedHour, ActionData.sla_hours);

                        // Last Col
                        string strAction = ActionData.desc;

                        dataGridView.Rows.Add(order.ID.ToString(), strClientName, strFilesNo, strThirdCol, strSlaStatus, strAction);
                    }
                }
            }

            Utilities.GetAllActionToDeptList();
            Utilities.GetAllMyEmployees();

            foreach (tbl_employees employee in Globals.AllMyEmployees)
            {
                lbEmployees.Items.Add(employee.name);
            }

            LoadRelevantData();
            Utilities.SetZebraMode(dataGridView);
        }

        private void LoadRelevantData()
        {
            int nJobCount = Utilities.GetMyJobCount();

            if(nJobCount == 0)
            {
                // No jobs for me
                tbPanel.Text = "אין עבודות לביצוע על ידיך";
                dataGridView.Visible = false;
                pbExecute.Enabled = false;
            }
            else if(nJobCount > 0)
            {
                dataGridView.Visible = true;
                pbExecute.Enabled = true;

                Utilities.GetAllClientsList();
                Utilities.GetAllActionsList();
            }
            else
            {
                isLoadSucceeded = false;
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }

            if(isLoadSucceeded &&
               nJobCount > 0)
            {
                foreach (tbl_orders Order in Globals.MyJobs)
                {
                    // First Col
                    int nOrderID = Order.ID;

                    // Second Col
                    string strClientName =
                        Globals.AllClients.Where(c => c.ID == Order.client_id).Single<tbl_clients>().name;

                    // Third Col
                    Nullable<int> nFilesNo = Order.files_number;

                    // Fourth Col
                    string strThirdCol = Utilities.GetFilledDataFromOrder(Order);

                    // Fifth Col - Getting sla status
                    tbl_sla_actions ActionData;
                    Nullable<System.DateTime> recievedDate;
                    Nullable<System.TimeSpan> recievedHour;

                    if ((Order.special_department_id != null &&
                        Globals.UserGroupID == Globals.KadasUserID) ||
                       (Globals.UserGroupID == Globals.OrdersUserID &&
                        Order.special_department_id != null &&
                        Order.special_department_id == Globals.OrdersUserID))
                    {
                        ActionData = Globals.AllActions.Where(a => a.ID == Order.special_action_type_id)
                                                        .Single<tbl_sla_actions>();

                        recievedDate = Order.special_recieved_date;
                        recievedHour = Order.special_recieved_hour;
                    }
                    else
                    {
                        ActionData = Globals.AllActions.Where(a => a.ID == Order.action_type_id)
                                                        .Single<tbl_sla_actions>();

                        recievedDate = Order.dep_recieve_date;
                        recievedHour = Order.dep_recieve_hour;
                    }

                    string strSlaStatus = Utilities.CalculateSlaStatus(recievedDate, recievedHour, ActionData.sla_hours);

                    // Last Col
                    string strAction = ActionData.desc;

                    dataGridView.Rows.Add(nOrderID, strClientName, nFilesNo, strThirdCol, strSlaStatus, strAction);
                }
            }
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            tbPanel.Clear();
            MyJobsForm.isJobSucceeded = false;

            tbl_orders SelectedOrder = this.GetSelectedOrder(false);

            // Calculate who you can transfer the job to and what department and shit like this
            // and open ניתוב עבודות with the data
            // ** Check if the action is insert order ( By orders department ) and than you end the 
            //    Order and open popup with insert order number.

            if(SelectedOrder != null)
            {
                List<tbl_action_to_dept> lstActionsToDept = new List<tbl_action_to_dept>();
                string strSlaStatus = String.Empty;
                DateTime dtBeginDate;

                int nActionTypeBeforeConvertion = 0;
                tbl_sla_actions ActionData;

                if (((Globals.UserGroupID == Globals.KadasUserID ||
                     Globals.UserGroupID == Globals.OrdersUserID) &&
                   SelectedOrder.special_department_id != null) ||
                   isSpecial)
                {
                    nActionTypeBeforeConvertion = int.Parse(SelectedOrder.special_action_type_id.Value.ToString());


                    ActionData = Globals.AllActions.Where(a => a.ID == SelectedOrder.special_action_type_id)
                                                            .Single<tbl_sla_actions>();

                    strSlaStatus = Utilities.CalculateSlaStatus(SelectedOrder.special_recieved_date,
                                                                SelectedOrder.special_recieved_hour,
                                                                ActionData.sla_hours);

                    dtBeginDate = SelectedOrder.special_recieved_date.Value;
                }
                else
                {
                    nActionTypeBeforeConvertion = int.Parse(SelectedOrder.action_type_id.ToString());
                    ActionData = Globals.AllActions.Where(a => a.ID == SelectedOrder.action_type_id)
                                                            .Single<tbl_sla_actions>();

                    strSlaStatus = Utilities.CalculateSlaStatus(SelectedOrder.dep_recieve_date,
                                                                SelectedOrder.dep_recieve_hour,
                                                                ActionData.sla_hours);

                    dtBeginDate = SelectedOrder.dep_recieve_date.Value;
                }

                int nSlaStatusID = 0;

                if (nActionTypeBeforeConvertion != 13 &&
                    nActionTypeBeforeConvertion != 14)
                {
                    nSlaStatusID = Utilities.ConvertSlaStatusToNumber(strSlaStatus);
                }

                int nActionTypeID =
                    Utilities.ConvertIfNeeded
                        (nActionTypeBeforeConvertion);

                lstActionsToDept =
                        Globals.AllActionToDept
                            .Where(ad => ad.action_ID == nActionTypeID)
                                        .ToList<tbl_action_to_dept>();

                if (lstActionsToDept.Count != 0)
                {
                    if (lstActionsToDept.Count == 1)
                    {
                        if(isSpecial)
                        {
                            if(Utilities.TransferJobAndActionToNext(SelectedOrder, isSpecial))
                            {
                                tbPanel.Text = "העברת העבודה התבצעה בהצלחה";
                                MyJobsForm.isJobSucceeded = true;
                            }
                            else
                            {
                                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                            }
                        }
                        else if(Globals.UserGroupID == Globals.KadasUserID &&
                                SelectedOrder.special_department_id != null)
                        {
                            if (lstActionsToDept[0].action_ID == Globals.ActionTypeKadasWaitClient)
                            {
                                DialogResult result = MessageBox.Show("האם הלקוח אישר ?", "אישור הלקוח", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                                // DialogResult result = MessageBox.Show("האם הלקוח אישר את העבודה ?", "אישור הלקוח", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                    {
                                        tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                        MyJobsForm.isJobSucceeded = true;
                                    }
                                    else
                                    {
                                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                    }
                                }
                                else if (result == DialogResult.No)
                                {
                                    SelectedOrder.special_action_type_id = Utilities.GetActionTypeIDFormWork(Globals.KadasUserID, SelectedOrder.kadas_work);
                                    SelectedOrder.special_recieved_date = System.DateTime.Now.Date;
                                    SelectedOrder.special_recieved_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));

                                    try
                                    {
                                        using (var context = new DB_Entities())
                                        {
                                            context.tbl_orders.Attach(SelectedOrder);
                                            var Entry = context.Entry(SelectedOrder);

                                            Entry.Property(o => o.action_type_id).IsModified = true;
                                            Entry.Property(o => o.dep_recieve_date).IsModified = true;
                                            Entry.Property(o => o.dep_recieve_hour).IsModified = true;
                                            Entry.Property(o => o.special_action_type_id).IsModified = true;
                                            Entry.Property(o => o.special_recieved_date).IsModified = true;
                                            Entry.Property(o => o.special_recieved_hour).IsModified = true;

                                            context.SaveChanges();
                                            MyJobsForm.isJobSucceeded = true;
                                            this.SilentRefresh();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                    }
                                }
                            }
                            else if (SelectedOrder.special_action_type_id >= Globals.ActionTypeKadasApprovePDF &&
                                     SelectedOrder.special_action_type_id <= Globals.ActionTypeKadasGraphicUpdate &&
                                     SelectedOrder.kadas_agent_name == null)
                            {
                                tbPanel.Text = "שים לב! עליך למנות עובד לביצוע לפני ביצוע העבודה";
                            }
                            else
                            {
                                if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                {
                                    tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                    MyJobsForm.isJobSucceeded = true;
                                }
                                else
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                        else if (lstActionsToDept[0].action_ID == Globals.ActionTypeInsertOrderID)
                        {
                            // Insert order number
                            new InsertOrderIDForm(SelectedOrder).ShowDialog();
                        }
                        else if (lstActionsToDept[0].action_ID == Globals.ActionTypeRecieveClientOrder)
                        {
                            // Insert Client order number
                            new InsertClientOrderIDForm(SelectedOrder).ShowDialog();
                        }
                        // Studio model approve - קבלת אישור מהלקוח על דגם סטודיו
                        else if (lstActionsToDept[0].action_ID == Globals.ActionTypeStudioWaitClient)
                        {
                            DialogResult result = MessageBox.Show("האם הלקוח אישר ?", "אישור הלקוח", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                            // DialogResult result = MessageBox.Show("האם הלקוח אישר את הדגם ?", "אישור הלקוח", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                new InsertModelNumberForm(SelectedOrder).ShowDialog();

                                if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                {
                                    tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                    MyJobsForm.isJobSucceeded = true;
                                }
                                else
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                SelectedOrder.action_type_id = Utilities.GetActionTypeIDFormWork(Globals.StudioUserID,SelectedOrder.studio_work);
                                SelectedOrder.dep_recieve_date = System.DateTime.Now.Date;
                                SelectedOrder.dep_recieve_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));

                                try
                                {
                                    using (var context = new DB_Entities())
                                    {
                                        context.tbl_orders.Attach(SelectedOrder);
                                        var Entry = context.Entry(SelectedOrder);

                                        Entry.Property(o => o.action_type_id).IsModified = true;
                                        Entry.Property(o => o.dep_recieve_date).IsModified = true;
                                        Entry.Property(o => o.dep_recieve_hour).IsModified = true;

                                        context.SaveChanges();
                                        MyJobsForm.isJobSucceeded = true;
                                        this.SilentRefresh();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                        else if(lstActionsToDept[0].action_ID == Globals.ActionTypeKadasWaitClient)
                        {
                            DialogResult result = MessageBox.Show("האם הלקוח אישר  ?", "אישור הלקוח", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                            // DialogResult result = MessageBox.Show("האם הלקוח אישר את העבודה ?", "אישור הלקוח", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                new InsertTemplateNumberForm(SelectedOrder).ShowDialog();

                                if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                {
                                    tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                    MyJobsForm.isJobSucceeded = true;
                                }
                                else
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                SelectedOrder.action_type_id = Utilities.GetActionTypeIDFormWork(Globals.KadasUserID, SelectedOrder.kadas_work);
                                SelectedOrder.dep_recieve_date = System.DateTime.Now.Date;
                                SelectedOrder.dep_recieve_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));

                                try
                                {
                                    using (var context = new DB_Entities())
                                    {
                                        context.tbl_orders.Attach(SelectedOrder);
                                        var Entry = context.Entry(SelectedOrder);

                                        Entry.Property(o => o.action_type_id).IsModified = true;
                                        Entry.Property(o => o.dep_recieve_date).IsModified = true;
                                        Entry.Property(o => o.dep_recieve_hour).IsModified = true;
                                        Entry.Property(o => o.special_action_type_id).IsModified = true;
                                        Entry.Property(o => o.special_recieved_date).IsModified = true;
                                        Entry.Property(o => o.special_recieved_hour).IsModified = true;

                                        context.SaveChanges();
                                        MyJobsForm.isJobSucceeded = true;
                                        this.SilentRefresh();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                        else if((SelectedOrder.action_type_id >= Globals.ActionTypeKadasApprovePDF &&
                                 SelectedOrder.action_type_id <= Globals.ActionTypeKadasGraphicUpdate &&
                                 SelectedOrder.kadas_agent_name == null ) ||
                                (SelectedOrder.action_type_id >= Globals.ActionTypeStudioOnlyPrisa &&
                                 SelectedOrder.action_type_id <= Globals.ActionTypeStudioCutModel &&
                                 SelectedOrder.studio_agent_name == null ))
                        {
                            tbPanel.Text = "שים לב! עליך למנות עובד לביצוע לפני ביצוע העבודה";
                        }
                        else if(SelectedOrder.action_type_id == Globals.ActionTypeSetAndSendOffer)
                        {
                            using (var context = new DB_Entities())
                            {
                                try
                                {
                                    tbl_offers currOffer = context.tbl_offers
                                            .Where(o => o.order_id == SelectedOrder.ID)
                                                        .SingleOrDefault<tbl_offers>();

                                    if(currOffer == null)
                                    {
                                        DialogResult result = MessageBox.Show("שים לב! לא הזנת נתונים על הצעת מחיר האם ברצונך להזין כעת ?", "הצעת מחיר", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                                        // DialogResult result = MessageBox.Show("שים לב! לא הזנת נתונים על הצעת מחיר האם ברצונך להזין כעת ?", "הצעת מחיר", MessageBoxButtons.YesNo);

                                        if (result == DialogResult.Yes)
                                        {
                                            new EnterOfferDataPopup(SelectedOrder.ID).ShowDialog();
                                        }
                                        else if (result == DialogResult.No)
                                        {
                                            if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                            {
                                                tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                                MyJobsForm.isJobSucceeded = true;
                                            }
                                            else
                                            {
                                                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Utilities.TransferJobAndActionToNext(SelectedOrder))
                                        {
                                            tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                            MyJobsForm.isJobSucceeded = true;
                                        }
                                        else
                                        {
                                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                        }
                                    }
                                }
                                catch(Exception ex)
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                        else
                        { 
                            // Update current department id and action type to the next
                            if(Utilities.TransferJobAndActionToNext(SelectedOrder))
                            {
                                tbPanel.Text = "עבודה בוצעה בהצלחה ! לנתונים עדכניים לחץ על רענון";
                                MyJobsForm.isJobSucceeded = true;
                            }
                            else
                            {
                                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                            }
                        }

                        if(MyJobsForm.isJobSucceeded &&
                           nSlaStatusID != 0)
                        {
                            tbl_sla_data currSlaData = new tbl_sla_data();

                            currSlaData.ID = Utilities.GetNextSlaDataID();
                            currSlaData.order_id = SelectedOrder.ID;
                            currSlaData.sla_id = nActionTypeBeforeConvertion;
                            currSlaData.user_id = Globals.UserGroupID;
                            currSlaData.begin_date = dtBeginDate;
                            currSlaData.end_date = DateTime.Today;
                            currSlaData.status_id = nSlaStatusID;
                            
                            // Get the agent name if needed
                            if(nActionTypeID == 2 ||
                               nActionTypeID == 4)
                            {
                                currSlaData.employee_name = SelectedOrder.studio_agent_name;
                            }
                            else if(nActionTypeID == 8 ||
                                    nActionTypeID == 9)
                            {
                                currSlaData.employee_name = SelectedOrder.kadas_agent_name;
                            }

                            this.InsertIntoSlaData(currSlaData);
                        }                        
                    }
                    else if(lstActionsToDept.Count > 1)
                    {
                        // פתח מסך ניתוב עבודה לפי ID של מחלקה
                        new MovementsForm(lstActionsToDept, SelectedOrder, nActionTypeID, false).ShowDialog();

                        if(MyJobsForm.isJobSucceeded &&
                           nSlaStatusID != 0)
                        {
                            tbl_sla_data currSlaData = new tbl_sla_data();

                            currSlaData.ID = Utilities.GetNextSlaDataID();
                            currSlaData.order_id = SelectedOrder.ID;
                            currSlaData.sla_id = nActionTypeBeforeConvertion;
                            currSlaData.user_id = Globals.UserGroupID;
                            currSlaData.begin_date = dtBeginDate;
                            currSlaData.end_date = DateTime.Today;
                            currSlaData.status_id = nSlaStatusID;

                            // Get the agent name if needed
                            if (nActionTypeID == 2 ||
                               nActionTypeID == 4)
                            {
                                currSlaData.employee_name = SelectedOrder.studio_agent_name;
                            }
                            else if (nActionTypeID == 8 ||
                                    nActionTypeID == 9)
                            {
                                currSlaData.employee_name = SelectedOrder.kadas_agent_name;
                            }

                            this.InsertIntoSlaData(currSlaData);
                        }
                    }
                }
            }
        }

        private void InsertIntoSlaData(tbl_sla_data currSlaData)
        {
            using (var context = new DB_Entities())
            {
                try
                {
                    context.tbl_sla_data.Add(currSlaData);

                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            if(Globals.MyJobs != null)
            {
                Globals.MyJobs.Clear();
            }
            
            dataGridView.Rows.Clear();
            LoadRelevantData();
            
            if(isLoadSucceeded)
            {
                tbPanel.Text = "רענון בוצע בהצלחה !";

                pbSetEmployee.Visible = false;
                lblEmployee.Visible = false;
                lbEmployees.Visible = false;

                if (Globals.MyJobs == null || Globals.MyJobs.Count == 0)
                {
                    tbPanel.Text += " אין עבודות לביצוע";

                    if(Globals.UserGroupID == Globals.SalesUserID)
                    {
                        Globals.SalesFormInstance.pbMyJobs.Image = Properties.Resources.My_Jobs;
                    }
                    else
                    {
                        Globals.NotSalesFormInstance.pbMyJobs.Image = Properties.Resources.My_Jobs;
                    }
                }
            }
            else
            {
                isLoadSucceeded = true;
            }
            
        }

        private void pbSetDeclinedAndInsert_Click(object sender, EventArgs e)
        {
            tbl_orders selectedOrder = this.GetSelectedOrder(false);

            if (selectedOrder != null)
            {
                new EnterDeclinedOrdersForm(selectedOrder).Show();
            }
        }

        private tbl_orders GetSelectedOrder(Boolean isSelectionChanged)
        {
            tbl_orders selectedOrder = null;

            if(dataGridView.SelectedRows.Count == 0)
            {
                if(!isSelectionChanged)
                {
                    tbPanel.Text = "שגיאה! עליך לסמן את אחת השורות";
                }
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

                    string strActionDesc = dataGridView.SelectedRows[0].Cells[5].Value.ToString();

                    int nClientID = Globals.AllClients.Where(a => a.name == strClientName).First<tbl_clients>().ID;

                    tbl_orders SelectedOrder =
                            Globals.MyJobs.Where(m => m.ID == nOrderID &&
                                                      m.client_id == nClientID).SingleOrDefault<tbl_orders>();

                    if (SelectedOrder == null)
                    {
                        tbPanel.Text = "שגיאה! יש תקלה באמינות הנתונים אנא רענן ונסה שוב";
                    }
                    else
                    {
                        if(SelectedOrder.special_department_id != null &&
                           strActionDesc.Equals(Globals.AcitonMoveCheckListToOrders))
                        {
                            isSpecial = true;
                        }
                        else
                        {
                            isSpecial = false;
                        }
                        
                        selectedOrder = SelectedOrder;
                        
                    }
                }
            }

            return selectedOrder;
        }

        private void pbSetEmployee_Click(object sender, EventArgs e)
        {
            string strEmployeeName = String.Empty;

            if(lbEmployees.SelectedItem == null)
            {
                tbPanel.Text = "שגיאה! עליך לבחור בעובד לביצוע העבודה";
            }
            else 
            {
                if (this.ListSelectedOrder != null)
                {
                    if(this.ListSelectedOrder.special_department_id != null &&
                       Globals.UserGroupID == Globals.KadasUserID)
                    {
                        if (this.ListSelectedOrder.special_department_id == Globals.KadasUserID)
                        {
                            this.ListSelectedOrder.kadas_agent_name = lbEmployees.SelectedItem.ToString();
                        }
                    }
                    else
                    {
                        if (this.ListSelectedOrder.curr_departnent_id == Globals.StudioUserID)
                        {
                            this.ListSelectedOrder.studio_agent_name = lbEmployees.SelectedItem.ToString();
                        }
                        else if (this.ListSelectedOrder.curr_departnent_id == Globals.KadasUserID)
                        {
                            this.ListSelectedOrder.kadas_agent_name = lbEmployees.SelectedItem.ToString();
                        }
                    }

                    strEmployeeName = lbEmployees.SelectedItem.ToString();

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            context.tbl_orders.Attach(this.ListSelectedOrder);
                            var Entry = context.Entry(this.ListSelectedOrder);

                            Entry.Property(o => o.kadas_agent_name).IsModified = true;
                            Entry.Property(o => o.studio_agent_name).IsModified = true;

                            context.SaveChanges();

                            tbPanel.Text = "העובד " + strEmployeeName + " מונה בהצלחה לעבודה";

                            this.SilentRefresh();
                        }
                        catch (Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
                else
                {
                    tbPanel.Text = "שגיאה! עליך לסמן את אחת השורות";
                }
            }
        }

        private void SilentRefresh()
        {
            if (Globals.MyJobs != null)
            {
                Globals.MyJobs.Clear();
            }

            dataGridView.Rows.Clear();
            LoadRelevantData();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.ListSelectedOrder = GetSelectedOrder(true);

            if (this.ListSelectedOrder != null)
            {
                if ((this.ListSelectedOrder.action_type_id >= Globals.ActionTypeKadasApprovePDF &&
                     this.ListSelectedOrder.action_type_id <= Globals.ActionTypeKadasGraphicUpdate) ||
                    (this.ListSelectedOrder.special_department_id != null &&
                     Globals.UserGroupID == Globals.KadasUserID &&
                     this.ListSelectedOrder.special_action_type_id >= Globals.ActionTypeKadasApprovePDF &&
                     this.ListSelectedOrder.special_action_type_id <= Globals.ActionTypeKadasGraphicUpdate))
                {
                    pbSetEmployee.Visible = true;
                    lblEmployee.Visible = true;
                    lbEmployees.Visible = true;

                    if (this.ListSelectedOrder.kadas_agent_name != null)
                    {
                        lbEmployees.SelectedItem = this.ListSelectedOrder.kadas_agent_name;
                    }
                }
                else if (this.ListSelectedOrder.action_type_id >= Globals.ActionTypeStudioOnlyPrisa &&
                         this.ListSelectedOrder.action_type_id <= Globals.ActionTypeStudioCutModel)
                {
                    pbSetEmployee.Visible = true;
                    lblEmployee.Visible = true;
                    lbEmployees.Visible = true;

                    if (this.ListSelectedOrder.studio_agent_name != null)
                    {
                        lbEmployees.SelectedItem = this.ListSelectedOrder.studio_agent_name;
                    }
                }
                else
                {
                    pbSetEmployee.Visible = false;
                    lblEmployee.Visible = false;
                    lbEmployees.Visible = false;
                }
            }
        }

        private void pbSalesUpdate_Click(object sender, EventArgs e)
        {
            tbl_orders selectedOrder = this.GetSelectedOrder(false);

            if (selectedOrder != null)
            {
                new UpdateOrderForm(selectedOrder).Show();
            }
        }
    }
}
