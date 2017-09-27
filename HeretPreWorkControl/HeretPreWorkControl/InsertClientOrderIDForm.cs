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
    public partial class InsertClientOrderIDForm : Form
    {
        tbl_orders OrderToInsert;
        Boolean isChangeOccured = false;

        public InsertClientOrderIDForm(tbl_orders currentOrder)
        {
            InitializeComponent();

            this.OrderToInsert = currentOrder;
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            if (tbOrderNum.Text == String.Empty)
            {
                tbPanel.Text = "שגיאה! עליך להזין מספר הזמנת לקוח";
            }
            else
            {
                try
                {
                    this.OrderToInsert.client_order_id = tbOrderNum.Text.ToString();
                    this.OrderToInsert.curr_departnent_id = Globals.SalesUserID;

                    this.OrderToInsert.action_type_id = 
                        Globals.AllActionToDept.Where(a => a.action_ID == Globals.ActionTypeRecieveClientOrder)
                                .Single<tbl_action_to_dept>()
                                        .recieved_department_action_id;

                    this.OrderToInsert.dep_recieve_date = System.DateTime.Now.Date;
                    this.OrderToInsert.dep_recieve_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));

                    try
                    {
                        using (var context = new DB_Entities())
                        {
                            context.tbl_orders.Attach(this.OrderToInsert);
                            var Entry = context.Entry(this.OrderToInsert);

                            Entry.Property(o => o.order_number).IsModified = true;
                            Entry.Property(o => o.curr_departnent_id).IsModified = true;
                            Entry.Property(o => o.action_type_id).IsModified = true;

                            // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                            context.SaveChanges();

                            isChangeOccured = true;
                            MyJobsForm.isJobSucceeded = true;
                            tbPanel.Text = "מספר ההזמנה הוכנס למערכת בהצלחה !";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! עליך להזין ספרות בשדה מס' הזמנת לקוח";
                }
            }
        }
    }
}
