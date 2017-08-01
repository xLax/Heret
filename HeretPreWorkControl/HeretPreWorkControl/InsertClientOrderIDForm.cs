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
                    this.OrderToInsert.client_order_id = int.Parse(tbOrderNum.Text.ToString());

                    try
                    {
                        using (var context = new DB_Entities())
                        {
                            context.tbl_orders.Attach(this.OrderToInsert);
                            var Entry = context.Entry(this.OrderToInsert);

                            Entry.Property(o => o.order_number).IsModified = true;

                            // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                            context.SaveChanges();

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
