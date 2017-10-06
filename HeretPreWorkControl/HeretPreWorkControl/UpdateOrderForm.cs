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

        private int updateLabelY;
        private int updateButtonY;
        private int panelY;
        private int heightFromDescToEndScreen;

        public UpdateOrderForm(tbl_orders selectedOrder)
        {
            InitializeComponent();

            lbPriseTempDesc.Items.Add(Globals.PrisaNumber);
            lbPriseTempDesc.Items.Add(Globals.TemplateNumber);
            lbPriseTempDesc.Items.Add(Globals.ProjectDesc);
            lbPriseTempDesc.Items.Add(Globals.ClientOrderNum);

            this.order = selectedOrder;

            lbPriseTempDesc.SelectedIndex = 0;
        }

        private void saveObjectsInfo()
        {
            updateLabelY = lblUpdateOrder.Location.Y - tbDescription.Location.Y - tbDescription.Height;
            updateButtonY = btnUpdateOrder.Location.Y - tbDescription.Location.Y - tbDescription.Height;
            panelY = tbPanel.Location.Y - tbDescription.Location.Y - tbDescription.Height;
            heightFromDescToEndScreen = this.Height - tbDescription.Location.Y - tbDescription.Height;
        }

        private void changeScreenObjectLocations()
        {
            this.Height = tbDescription.Location.Y + tbDescription.Height + heightFromDescToEndScreen;
            btnUpdateOrder.Location = new Point(btnUpdateOrder.Location.X, tbDescription.Location.Y + tbDescription.Height + updateButtonY);
            lblUpdateOrder.Location = new Point(lblUpdateOrder.Location.X, tbDescription.Location.Y + tbDescription.Height + updateLabelY);
            tbPanel.Location = new Point(tbPanel.Location.X, tbDescription.Location.Y + tbDescription.Height + panelY);
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
                    saveObjectsInfo();
                    tbDescription.Multiline = true;
                    tbDescription.Height = 91;
                    changeScreenObjectLocations();
                    break;

                case Globals.TemplateNumber:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Center;
                    tbDescription.RightToLeft = RightToLeft.No;
                    tbDescription.Text = this.order.template_id;
                    tbDescription.BackColor = Color.White;
                    saveObjectsInfo();
                    tbDescription.Multiline = true;
                    tbDescription.Height = 91;
                    changeScreenObjectLocations();
                    break;

                case Globals.ClientOrderNum:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Center;
                    tbDescription.RightToLeft = RightToLeft.No;
                    tbDescription.Text = this.order.model_id;
                    tbDescription.BackColor = Color.White;
                    saveObjectsInfo();
                    tbDescription.Multiline = false;
                    tbDescription.Height = 30;
                    changeScreenObjectLocations();
                    break;

                case Globals.ProjectDesc:
                    tbDescription.Enabled = true;
                    tbDescription.TextAlign = HorizontalAlignment.Right;
                    tbDescription.RightToLeft = RightToLeft.Yes;
                    tbDescription.Text = this.order.project_desc;
                    tbDescription.BackColor = Color.White;
                    saveObjectsInfo();
                    tbDescription.Multiline = true;
                    tbDescription.Height = 91;
                    changeScreenObjectLocations();
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

                    case Globals.ClientOrderNum:
                        this.order.client_order_id = tbDescription.Text;
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

                            case Globals.ClientOrderNum:
                                Entry.Property(o => o.client_order_id).IsModified = true;
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
