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

            lbRejectReason.Items.Add(Globals.PriceReason);
            lbRejectReason.Items.Add(Globals.TimeReason);
            lbRejectReason.Items.Add(Globals.DelayReason);
            lbRejectReason.Items.Add(Globals.OtherReason);

            tbAgentName.Text = Globals.Name;
            tbInsertDate.Text = Utilities.GetDateInNormalFormat(System.DateTime.Now.Date);

            DeclinedOrder = DecOrder;
        }

        private void SetAllFieldsEnabled()
        {
            foreach (Control control in this.Controls)
            {
                if(!control.Name.Equals("tbAgentName") &&
                   !control.Name.Equals("tbInsertDate") &&
                   control is TextBox)
                {
                    (control as TextBox).Enabled = true;
                    (control as TextBox).BackColor = Color.White;
                }
            }
        }

        private void EnterDeclinedOrdersForm_Load(object sender, EventArgs e)
        {
            if (Globals.AllClients == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        List<tbl_clients> Clients = context.tbl_clients.ToList<tbl_clients>();
                        Utilities.SetClientList(Clients);
                    }
                    catch(Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }   
                }
            }

            if (this.DeclinedOrder.client_id == null)
            {
                SetAllFieldsEnabled();
            }
            else
            {
                FillScreenWithOrderData(DeclinedOrder);
            }
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
            if (DeclinedOrder.template_id != 0 &&
                DeclinedOrder.template_id != null)
            {
                lbPriseTempDesc.SelectedItem = Globals.TemplateNumber;
                tbPrisaTempDesc.Text = DeclinedOrder.template_id.ToString();
            }
            else if (DeclinedOrder.prisa_id != 0 &&
                     DeclinedOrder.prisa_id != null)
            {
                lbPriseTempDesc.SelectedItem = Globals.PrisaNumber;
                tbPrisaTempDesc.Text = DeclinedOrder.prisa_id.ToString();
            }
            else
            {
                lbPriseTempDesc.SelectedItem = Globals.ProjectDesc;
                tbPrisaTempDesc.Text = DeclinedOrder.project_desc;
            }

            tbAmount.Text = DeclinedOrder.amount.ToString();
        }

        private void pbCleanAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if ((control as TextBox).Enabled == true)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        if ((control as TextBox).Name.Equals("tbClientName"))
                        {
                            (control as TextBox).Clear();
                        }
                    }
                }
                else if(control is ListBox)
                {
                    (control as ListBox).SelectedItem = null;
                }
            }
        }

        private void tbContactDate_Leave(object sender, EventArgs e)
        {
            List<tbl_orders> lstDeclinedOrders = new List<tbl_orders>();

            tbContactDate.BackColor = Color.White;

            try
            {
                string strDate = tbContactDate.Text.ToString();
                int nDay = int.Parse(strDate.Substring(0, 2));
                int nMonth = int.Parse(strDate.Substring(3, 2));
                int nYear = int.Parse(strDate.Substring(6, 4));

                DateTime dtContactDate = new DateTime(nYear, nMonth, nDay);

                if(!tbClientNumber.Text.Equals(String.Empty))
                {
                    lstDeclinedOrders =
                    Globals.MyDeclinedOrders
                        .Where(d => d.client_id == int.Parse(tbClientNumber.Text) &&
                                    d.contact_date == dtContactDate )
                                        .ToList<tbl_orders>();
                }
                else
                {
                    lstDeclinedOrders =
                    Globals.MyDeclinedOrders
                        .Where(d => d.contact_date == dtContactDate)
                                        .ToList<tbl_orders>();
                }
            }
            catch (Exception ex)
            {
                tbContactDate.BackColor = Color.Tomato;
                tbPanel.Text = "שגיאה! אנא הזן תאריך בפורמט dd/mm/yyyy";
            }

            if (lstDeclinedOrders.Count == 1)
            {
                FillScreenWithOrderData(lstDeclinedOrders[0]);
            }
        }

        private void tbClientNumber_Leave(object sender, EventArgs e)
        {
            List<tbl_orders> lstDeclinedOrders = new List<tbl_orders>();

            tbClientNumber.BackColor = Color.White;

            if(!tbClientNumber.Text.Equals(String.Empty))
            {
                try
                {
                    lstDeclinedOrders =
                        Globals.MyDeclinedOrders
                            .Where(d => d.client_id == int.Parse(tbClientNumber.Text))
                                            .ToList<tbl_orders>();
                }
                catch (Exception ex)
                {
                    tbClientNumber.BackColor = Color.Tomato;
                    tbPanel.Text = "שגיאה! אנא הזן מספרים בשדה מספר לקוח";
                }

                if (lstDeclinedOrders.Count == 1)
                {
                    FillScreenWithOrderData(lstDeclinedOrders[0]);
                }
            }     
        }

        private void tbNoFiles_Leave(object sender, EventArgs e)
        {
            List<tbl_orders> lstDeclinedOrders = new List<tbl_orders>();

            tbNoFiles.BackColor = Color.White;

            try
            {
                string strDate = tbContactDate.Text.ToString();
                if(!strDate.Equals(String.Empty) &&
                   !tbClientNumber.Text.Equals(String.Empty) &&
                   !tbNoFiles.Text.Equals(String.Empty))
                {
                    int nDay = int.Parse(strDate.Substring(0, 2));
                    int nMonth = int.Parse(strDate.Substring(3, 2));
                    int nYear = int.Parse(strDate.Substring(6, 4));

                    DateTime dtContactDate = new DateTime(nYear, nMonth, nDay);

                    lstDeclinedOrders =
                        Globals.MyDeclinedOrders
                            .Where(d => d.client_id == int.Parse(tbClientNumber.Text) &&
                                        d.contact_date == dtContactDate && 
                                        d.files_number == int.Parse(tbNoFiles.Text))
                                                .ToList<tbl_orders>();
                }
            }
            catch (Exception ex)
            {
                tbNoFiles.BackColor = Color.Tomato;
                tbPanel.Text = "שגיאה! אנא הזן מספרים בשדה מספר קבצים";
            }

            if (lstDeclinedOrders.Count == 1)
            {
                FillScreenWithOrderData(lstDeclinedOrders[0]);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DeclinedOrder.reject_date = System.DateTime.Now.Date;

            if (lbRejectReason.SelectedItem == null)
            {
                tbPanel.Text = "אנא סמן סיבת דחייה";
            }
            else 
            {
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
        }
    }
}
