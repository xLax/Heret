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
    public partial class UpdateOrderForm : Form
    {
        private tbl_orders order;

        public UpdateOrderForm(tbl_orders selectedOrder)
        {
            InitializeComponent();

            lbPriseTempDesc.Items.Add(Globals.PrisaNumber);
            lbPriseTempDesc.Items.Add(Globals.TemplateNumber);
            lbPriseTempDesc.Items.Add(Globals.ProjectDesc);
            lbPriseTempDesc.Items.Add(Globals.ModelNumber);

            this.order = selectedOrder;

            lbPriseTempDesc.SelectedIndex = 0;
        }

        private void lbPriseTempDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lbPriseTempDesc.SelectedItem.ToString())
            {
                case Globals.PrisaNumber:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Center;
                    tbDescription.RightToLeft = RightToLeft.No;
                    tbDescription.Text = this.order.prisa_id;
                    tbDescription.BackColor = Color.White;
                    break;

                case Globals.TemplateNumber:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Center;
                    tbDescription.RightToLeft = RightToLeft.No;
                    tbDescription.Text = this.order.template_id;
                    tbDescription.BackColor = Color.White;
                    break;

                case Globals.ModelNumber:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Center;
                    tbDescription.RightToLeft = RightToLeft.No;
                    tbDescription.Text = this.order.model_id;
                    tbDescription.BackColor = Color.White;
                    break;

                case Globals.ProjectDesc:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Right;
                    tbDescription.RightToLeft = RightToLeft.Yes;
                    tbDescription.Text = this.order.project_desc;
                    tbDescription.BackColor = Color.White;
                    break;

                default:
                    tbDescription.Enabled = false;
                    tbDescription.BackColor = Color.Wheat;
                    break;
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(tbDescription.Text == "" || lbPriseTempDesc.SelectedItem == null)
            {
                tbPanel.Text = "שגיאה ! לא הוזנו נתונים";
            }
            else
            {
                switch (lbPriseTempDesc.SelectedItem.ToString())
                {
                    case Globals.PrisaNumber:
                        this.order.prisa_id = tbDescription.Text;
                        break;

                    case Globals.TemplateNumber:
                        this.order.template_id = tbDescription.Text;
                        break;

                    case Globals.ModelNumber:
                        this.order.model_id = tbDescription.Text;
                        break;

                    case Globals.ProjectDesc:
                        this.order.project_desc = tbDescription.Text;
                        break;

                    default:
                        break;
                }

                try
                {
                    using (var context = new DB_Entities())
                    {
                        context.tbl_orders.Attach(order);
                        var Entry = context.Entry(order);

                        switch (lbPriseTempDesc.SelectedItem.ToString())
                        {
                            case Globals.PrisaNumber:
                                Entry.Property(o => o.prisa_id).IsModified = true;
                                break;

                            case Globals.TemplateNumber:
                                Entry.Property(o => o.template_id).IsModified = true;
                                break;

                            case Globals.ModelNumber:
                                Entry.Property(o => o.model_id).IsModified = true;
                                break;

                            case Globals.ProjectDesc:
                                Entry.Property(o => o.project_desc).IsModified = true;
                                break;

                            default:
                                break;
                        }

                        context.SaveChanges();

                        tbPanel.Text = "ההזמנה עודכנה בהצלחה !";
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
