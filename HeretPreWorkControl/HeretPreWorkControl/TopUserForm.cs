using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class TopUserForm : Form
    {
        // private DataSet Result;

        public TopUserForm()
        {
            InitializeComponent();
        }

        private void TopUserForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "שלום " + Globals.Name;

            tmrSpecialApproveTimer_Tick(new object(), new EventArgs());
            tmrLateOrdersInsertTimer_Tick(new object(), new EventArgs());
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            new CreateUserForm().Show();
        }

        private void TopUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGetClientsFromExcel_Click(object sender, EventArgs e)
        {
            /*    Excel excel = new Excel("D:\\פרויקט חרט\\קובץ לקוחות.xlsx", 1);

                Dictionary<int, string[]> dictionary = excel.ReadFrom(2, 1);
                using (var context = new DB_Entities())
                {
                    try
                    {
                        foreach (var item in dictionary)
                        {
                            tbl_clients client = new tbl_clients();
                            client.ID = item.Key;
                            client.name = item.Value[0].ToString();

                            if (item.Value[1] != null)
                            {
                                client.english_name = item.Value[1].ToString();
                            }

                            client.status = item.Value[2].ToString();
                            client.person_responsible = item.Value[3].ToString();


                            context.tbl_clients.AddOrUpdate(client);
                        }

                        context.SaveChanges();

                        tbPanel.Text = "שמירה בוצעה בהצלחה";
                    }
                    catch(Exception ex)
                    {
                        tbPanel.Text = "שגיאה נסה שוב";
                    }
                }*/
        }

        private void tmrLateOrdersInsertTimer_Tick(object sender, EventArgs e)
        {
            using (var context = new DB_Entities())
            {
                try
                {
                    List<tbl_orders> lstLateOrders = context.tbl_orders
                                .Where(o => o.alert_creation_date == Globals.AlertNow).ToList<tbl_orders>();

                    foreach (tbl_orders order in lstLateOrders)
                    {
                        Utilities.CreatePopup("הזמנה הוזנה באיחור", "הזמנה מספר " + order.ID +
                                              " הוזנה באיחור למערכת .\n לחץ על התראה זו בכדי לצפות בה במסך תמונת מצב",
                                              Globals.ToTamatz);

                        order.alert_creation_date = Globals.Alerted;

                        context.tbl_orders.Attach(order);
                        var Entry = context.Entry(order);

                        Entry.Property(o => o.alert_creation_date).IsModified = true;

                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }
        }

        // תדירות האירוע - פעם בהרבה זמן
        private void tmrSpecialApproveTimer_Tick(object sender, EventArgs e)
        {
            int nPrevCount = 0;

            if(Globals.SpecialApprovedJobs != null)
            {
                nPrevCount = Globals.SpecialApprovedJobs.Count;
            }

            using (var context = new DB_Entities())
            {
                try
                {
                    List<tbl_orders> lstSpecialApprovedOrders = context.tbl_orders
                                .Where(o => o.special_department_id == Globals.AdminID).ToList<tbl_orders>();

                    int nCurrCount = lstSpecialApprovedOrders.Count;

                    if (nCurrCount > nPrevCount)
                    {
                        Utilities.CreatePopup("אישור קידום עבודה", "הזמנה חוזרת התקבלה, ונוצרה בקשה לקידום העבודה " +
                                              "לחץ על התראה זו כדי להכנס למסך קידום עבודות להמשך תהליך",
                                              Globals.ToSpecialApprove);

                        pbSpecialApprove.Image = Properties.Resources.Special_Approval_Icon_Note;
                    }
                    else if(nCurrCount > 0)
                    {
                        pbSpecialApprove.Image = Properties.Resources.Special_Approval_Icon_Note;
                    }
                    else
                    {
                        pbSpecialApprove.Image = Properties.Resources.Special_Approval_Icon;
                    }

                    Utilities.SetSpecialApprovedJobs(lstSpecialApprovedOrders);
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }
        }

        private void pbSpecialApprove_Click(object sender, EventArgs e)
        {
            new SpecialApprovedJobsForm().Show();
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {
            new AdminOverviewForm().Show();
        }

        private void pbStatistics_Click(object sender, EventArgs e)
        {
            new ManagerReportForm().Show();
        }

        private void pbCreateEmloyee_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm().Show();
        }
    }
}
