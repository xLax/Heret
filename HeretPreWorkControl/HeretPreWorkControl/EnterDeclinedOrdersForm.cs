using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace HeretPreWorkControl
{
    public partial class EnterDeclinedOrdersForm : Form
    {
        private tbl_orders DeclinedOrder;

        public EnterDeclinedOrdersForm(tbl_orders DecOrder)
        {
            InitializeComponent();

            lbPriseTempDesc.Items.Add(Globals.PrisaNumber);
            lbPriseTempDesc.Items.Add(Globals.TemplateNumber);
            lbPriseTempDesc.Items.Add(Globals.ProjectDesc);
            lbPriseTempDesc.Items.Add(Globals.ModelNumber);

            lbRejectReason.Items.Add(Globals.PriceReason);
            lbRejectReason.Items.Add(Globals.TimeReason);
            lbRejectReason.Items.Add(Globals.DelayReason);
            lbRejectReason.Items.Add(Globals.OtherReason);

            lbRejectReason.SelectedIndex = 0;

            tbAgentName.Text = Globals.Name;
            tbInsertDate.Text = Utilities.GetDateInNormalFormat(System.DateTime.Now.Date);

            DeclinedOrder = DecOrder;
        }

        private void EnterDeclinedOrdersForm_Load(object sender, EventArgs e)
        {
            if (Globals.AllClients == null)
            {
                Utilities.GetAllClientsList();
            }

            FillScreenWithOrderData(DeclinedOrder);
        }

        private void FillScreenWithOrderData(tbl_orders DeclinedOrder)
        {
            tbClientNumber.Text = DeclinedOrder.client_id.ToString();
            tbContactDate.Text = Utilities.GetDateInNormalFormat(DeclinedOrder.contact_date.Value);
            tbNoFiles.Text = DeclinedOrder.files_number.ToString();

            // Gets the client name
            tbClientName.Text =
                Globals.AllClients
                        .Where(c => c.ID == DeclinedOrder.client_id)
                                .First<tbl_clients>().name;

            tbPrisaTempDesc.Text = Utilities.GetFilledDataFromOrder(DeclinedOrder);

            // Need to know which one for the drop down list
            if (DeclinedOrder.template_id != null)
            {
                lbPriseTempDesc.SelectedItem = Globals.TemplateNumber;
                tbPrisaTempDesc.Text = DeclinedOrder.template_id.ToString();
            }
            else if (DeclinedOrder.prisa_id != null)
            {
                lbPriseTempDesc.SelectedItem = Globals.PrisaNumber;
                tbPrisaTempDesc.Text = DeclinedOrder.prisa_id.ToString();
            }
            else if(DeclinedOrder.model_id != null)
            {
                lbPriseTempDesc.SelectedItem = Globals.ModelNumber;
                tbPrisaTempDesc.Text = DeclinedOrder.model_id.ToString();
            }
            else
            {
                lbPriseTempDesc.SelectedItem = Globals.ProjectDesc;
                tbPrisaTempDesc.Text = DeclinedOrder.project_desc;
            }

            tbAmount.Text = DeclinedOrder.amount.ToString();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DeclinedOrder.reject_date = System.DateTime.Now.Date;

            DeclinedOrder.reject_reason = lbRejectReason.SelectedItem.ToString();
            DeclinedOrder.comments = tbComments.Text.ToString();
            DeclinedOrder.current_status_id = Globals.StatusDenied;
            
            try
            {
                using (var context = new DB_Entities())
                {
                    context.tbl_orders.Attach(DeclinedOrder);
                    var Entry = context.Entry(DeclinedOrder);
                    Entry.Property(o => o.reject_date).IsModified = true;
                    Entry.Property(o => o.reject_reason).IsModified = true;
                    Entry.Property(o => o.comments).IsModified = true;
                    Entry.Property(o => o.current_status_id).IsModified = true;
            
                    // context.tbl_orders.AddOrUpdate(DeclinedOrder);
            
                    context.SaveChanges();
            
                    if(Utilities.GetNewDeclinedOrdersAndCount() == 0)
                    {
                        Globals.SalesFormInstance.pbEnterDeclinedOrder.Image = 
                                        Properties.Resources.Enter_Rejected_Job_Icon;
                    }
            
                    if(Utilities.GetMyJobCount() == 0)
                    {
                        Globals.SalesFormInstance.pbMyJobs.Image =
                                        Properties.Resources.My_Jobs;
                    }
            
                    tbPanel.Text = "ההזמנה הוזנה בהצלחה !";
                }
            }
            catch(Exception ex)
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }
        }

        private void pbEnterLater_Click(object sender, EventArgs e)
        {
            DeclinedOrder.dep_recieve_date = System.DateTime.Now.Date;

            try
            {
                using (var context = new DB_Entities())
                {
                    context.tbl_orders.Attach(DeclinedOrder);
                    var Entry = context.Entry(DeclinedOrder);
                    Entry.Property(o => o.dep_recieve_date).IsModified = true;

                    // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                    context.SaveChanges();

                    if (Utilities.GetNewDeclinedOrdersAndCount() == 0)
                    {
                        Globals.SalesFormInstance.pbEnterDeclinedOrder.Image =
                                        Properties.Resources.Enter_Rejected_Job_Icon;
                    }

                    if (Utilities.GetMyJobCount() == 0)
                    {
                        Globals.SalesFormInstance.pbMyJobs.Image =
                                        Properties.Resources.My_Jobs;
                    }

                    tbPanel.Text = "הזנת הסירוב נדחתה בהצלחה למועד מאוחר יותר!";
                }
            }
            catch (Exception ex)
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }
        }
    }
}
