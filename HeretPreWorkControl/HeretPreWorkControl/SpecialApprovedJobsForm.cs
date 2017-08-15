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
    public partial class SpecialApprovedJobsForm : Form
    {
        Boolean isSucceeded = false;

        public SpecialApprovedJobsForm()
        {
            InitializeComponent();

            Utilities.GetAllClientsList();

            LoadRelevantData();
            Utilities.SetZebraMode(dataGridView);
        }

        private void LoadRelevantData()
        {
            foreach (tbl_orders Order in Globals.SpecialApprovedJobs)
            {
                string strFirstCol = Order.ID.ToString();
                string strSecondCol = String.Empty;

                try
                {
                    strSecondCol = Globals.AllClients.Where(a => a.ID == Order.client_id).Single<tbl_clients>().name;
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }

                string strThirdCol = Utilities.GetDateInNormalFormat(Order.contact_date.Value);

                string strFourthCol = Order.files_number.ToString();

                string strFifthCol = Utilities.GetFilledDataFromOrder(Order);

                string strSixthCol = Order.amount.ToString();

                string strLastCol = Order.sales_agent_name;

                dataGridView.Rows.Add(strFirstCol, strSecondCol, strThirdCol, strFourthCol, strFifthCol, strSixthCol, strLastCol);
            }
        }

        private void pbApprove_Click(object sender, EventArgs e)
        {
            tbl_orders SelectedOrder = this.GetSelectedOrder();

            Utilities.GetAllActionToDeptList();

            List<tbl_action_to_dept> lstActionsToDept = new List<tbl_action_to_dept>();

            lstActionsToDept =
                    Globals.AllActionToDept
                        .Where(ad => ad.action_ID == 7)
                                    .ToList<tbl_action_to_dept>();

            new MovementsForm(lstActionsToDept, SelectedOrder, 7).Show();
        }

        private tbl_orders GetSelectedOrder()
        {
            tbl_orders selectedOrder = null;

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
                            Globals.SpecialApprovedJobs.Where(m => m.ID == nOrderID &&
                                                      m.client_id == nClientID).SingleOrDefault<tbl_orders>();

                    if (SelectedOrder == null)
                    {
                        tbPanel.Text = "שגיאה! יש תקלה באמינות הנתונים אנא רענן ונסה שוב";
                    }
                    else
                    {
                        selectedOrder = SelectedOrder;
                    }
                }
            }

            return selectedOrder;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            if (Globals.SpecialApprovedJobs != null)
            {
                Globals.SpecialApprovedJobs.Clear();
            }

            using (var context = new DB_Entities())
            {
                try
                {
                    Globals.SpecialApprovedJobs = context.tbl_orders
                                    .Where(o => o.special_department_id == Globals.AdminID).ToList<tbl_orders>();

                    isSucceeded = true;
                }
                catch(Exception ex)
                {
                    isSucceeded = false;
                }
                
            }
                
            dataGridView.Rows.Clear();
            LoadRelevantData();

            if (isSucceeded)
            {
                tbPanel.Text = "רענון בוצע בהצלחה !";

                if (Globals.SpecialApprovedJobs == null || Globals.SpecialApprovedJobs.Count == 0)
                {
                    tbPanel.Text += " אין קידום עבודות לאישור";
                }
            }
            else
            {
                isSucceeded = true;
            }

        }

        private void pbDecline_Click(object sender, EventArgs e)
        {
            tbl_orders SelectedOrder = this.GetSelectedOrder();

            if (SelectedOrder != null)
            {
                SelectedOrder.special_department_id = null;

                using (var context = new DB_Entities())
                {
                    try
                    {
                        context.tbl_orders.Attach(SelectedOrder);
                        var Entry = context.Entry(SelectedOrder);

                        Entry.Property(o => o.special_department_id).IsModified = true;

                        context.SaveChanges();

                        tbPanel.Text = "סירוב קידום העבודה בוצע! אנא רענן לנתונים עדכניים";

                    }
                    catch(Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
            }
        }
    }
}
