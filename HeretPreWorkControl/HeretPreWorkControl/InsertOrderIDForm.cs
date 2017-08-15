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
    public partial class InsertOrderIDForm : Form
    {
        tbl_orders OrderToInsert;

        public InsertOrderIDForm(tbl_orders CurrentOrder)
        {
            InitializeComponent();

            this.OrderToInsert = CurrentOrder;
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            if(tbOrderNum.Text == String.Empty)
            {
                tbPanel.Text = "שגיאה! עליך להזין מספר הזמנה";
            }
            else
            {
                this.OrderToInsert.order_number = tbOrderNum.Text;
                this.OrderToInsert.current_status_id = Globals.StatusClosed;

                try
                {
                    using (var context = new DB_Entities())
                    {
                        context.tbl_orders.Attach(this.OrderToInsert);
                        var Entry = context.Entry(this.OrderToInsert);

                        Entry.Property(o => o.order_number).IsModified = true;
                        Entry.Property(o => o.current_status_id).IsModified = true;
                        // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                        context.SaveChanges();

                        MyJobsForm.isJobSucceeded = true;
                        tbPanel.Text = "מספר ההזמנה הוכנס למערכת בהצלחה !";
                    }
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }
        }
    }
}
