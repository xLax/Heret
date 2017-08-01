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

            LoadRelevantData();
            SetZebraMode();
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
                    tbl_sla_actions ActionData =
                        Globals.AllActions.Where(a => a.ID == Order.action_type_id)
                                                        .Single<tbl_sla_actions>();

                    Nullable<System.DateTime> recievedDate = Order.dep_recieve_date;
                    Nullable<System.TimeSpan> recievedHour = Order.dep_recieve_hour;

                    string strSlaStatus = Utilities.CalculateSlaStatus(recievedDate, recievedHour, ActionData.sla_hours);

                    // Last Col
                    string strAction = ActionData.desc;

                    dataGridView.Rows.Add(nOrderID, strClientName, nFilesNo, strThirdCol, strSlaStatus, strAction);
                }
            }
        }

        private void SetZebraMode()
        {
            dataGridView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            tbl_orders SelectedOrder = this.GetSelectedOrder();

            // Calculate who you can transfer the job to and what department and shit like this
            // and open ניתוב עבודות with the data
            // ** Check if the action is insert order ( By orders department ) and than you end the 
            //    Order and open popup with insert order number.

            if(SelectedOrder != null)
            {
                List<tbl_action_to_dept> lstNextDepartmentsID = new List<tbl_action_to_dept>();

                try
                {
                    using (var context = new DB_Entities())
                    {
                        lstNextDepartmentsID =
                            context.tbl_action_to_dept
                                .Where(ad => ad.action_ID == SelectedOrder.curr_departnent_id)
                                            .ToList<tbl_action_to_dept>();

                    }
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }

                if (lstNextDepartmentsID.Count != 0)
                {
                    if(lstNextDepartmentsID.Count == 1 &&
                       lstNextDepartmentsID[0].recieved_department_ID == Globals.OrdersUserID)
                    {
                        // Insert order number
                        new InsertOrderIDForm(SelectedOrder);
                    }
                    else if(lstNextDepartmentsID.Count > 1)
                    {
                        // פתח מסך ניתוב עבודה לפי ID של מחלקה
                        
                    }
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

                if(Globals.MyJobs == null || Globals.MyJobs.Count == 0)
                {
                    tbPanel.Text += " אין עבודות לביצוע";
                }
            }
            else
            {
                isLoadSucceeded = true;
            }
            
        }

        private void pbSetDeclinedAndInsert_Click(object sender, EventArgs e)
        {
            tbl_orders selectedOrder = this.GetSelectedOrder();

            if (selectedOrder != null)
            {
                new EnterDeclinedOrdersForm(selectedOrder).Show();
            }
        }

        private tbl_orders GetSelectedOrder()
        {
            tbl_orders selectedOrder = null;

            if(dataGridView.SelectedRows.Count == 0)
            {
                tbPanel.Text = "שגיאה! עליך לסמן את אחת השורות";
            }
            else if (dataGridView.SelectedRows.Count > 1)
            {
                tbPanel.Text = "שגיאה! עליך לבחור עבודה אחת בכל פעם";
            }
            else
            {
                // Get all the data about the selected row
                int nOrderID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                string strClientName = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                Nullable<int> NoFiles = (Nullable<int>)dataGridView.SelectedRows[0].Cells[2].Value;
                string strThirdCol = dataGridView.SelectedRows[0].Cells[3].Value.ToString();

                int nClientID = Globals.AllClients.Where(a => a.name == strClientName).First<tbl_clients>().ID;

                Nullable<int> nPrisaID = null, nTemplateID = null;
                string strProjectDesc = null;

                try
                {
                    nPrisaID = int.Parse(strThirdCol);
                }
                catch (Exception ex)
                {
                    try
                    {
                        nTemplateID = int.Parse(strThirdCol);
                    }
                    catch (Exception ex2)
                    {
                        strProjectDesc = strThirdCol;
                    }
                }

                tbl_orders SelectedOrder =
                        Globals.MyJobs.Where(m => m.ID == nOrderID &&
                                                  m.client_id == nClientID &&
                                                  m.files_number == NoFiles &&
                                                  (m.prisa_id == nPrisaID ||
                                                   m.template_id == nTemplateID ||
                                                   m.project_desc == strProjectDesc)).SingleOrDefault<tbl_orders>();

                if (SelectedOrder == null)
                {
                    tbPanel.Text = "שגיאה! יש תקלה באמינות הנתונים אנא רענן ונסה שוב";
                }
                else
                {
                    selectedOrder = SelectedOrder;
                }
            }

            return selectedOrder;
        }
    }
}
