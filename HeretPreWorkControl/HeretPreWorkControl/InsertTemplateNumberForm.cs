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
    public partial class InsertTemplateNumberForm : Form
    {
        private tbl_orders Order;

        public InsertTemplateNumberForm(tbl_orders CurrentOrder)
        {
            InitializeComponent();

            this.Order = CurrentOrder;
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            if (tbTemplateNum.Text.Trim(' ').Equals(String.Empty))
            {
                tbPanel.Text = "שגיאה! אנא הזן מספר תבנית";
            }
            else
            {
                try
                {
                    this.Order.template_id = tbTemplateNum.Text;

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            context.tbl_orders.Attach(this.Order);
                            var Entry = context.Entry(this.Order);

                            Entry.Property(o => o.template_id).IsModified = true;

                            context.SaveChanges();

                            MyJobsForm.isJobSucceeded = true;
                            tbPanel.Text = "מספר התבנית נשמר בהצלחה";
                        }
                        catch (Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! עליך להזין ספרות בשדה מספר תבנית";
                }
            }
        }

        private void tbTemplateNum_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == Globals.KeyValueEnter)
            {
                this.pbExecute_Click(new object(), new EventArgs());
            }
        }
    }
}
