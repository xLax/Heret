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
    public partial class InsertModelNumberForm : Form
    {
        private tbl_orders Order;

        public InsertModelNumberForm(tbl_orders CurrentOrder)
        {
            InitializeComponent();

            this.Order = CurrentOrder;
        }

        private void pbExecute_Click(object sender, EventArgs e)
        {
            if(tbModelNum.Text.Trim(' ').Equals(String.Empty))
            {
                tbPanel.Text = "שגיאה! אנא הזן מספר דגם";
            }
            else
            {
                try
                {
                    this.Order.model_id = tbModelNum.Text;

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            context.tbl_orders.Attach(this.Order);
                            var Entry = context.Entry(this.Order);

                            Entry.Property(o => o.model_id).IsModified = true;

                            context.SaveChanges();

                            tbPanel.Text = "מספר הדגם נשמר בהצלחה";
                        }
                        catch(Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה! עליך להזין ספרות בשדה מספר דגם";
                }
            }
        }
    }
}
