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
    public partial class ViewAllOrderDetails : Form
    {
        private tbl_orders order;
        private bool isEnabled;

        public ViewAllOrderDetails(tbl_orders selectedOrder)
        {
            InitializeComponent();

            Utilities.AllEmployeesForResponsible();

            foreach (tbl_employees employee in Globals.AllEmployeesResp)
            {
                if (employee.Department_id.Equals(Globals.ResponsibleID))
                {
                    lbResponseWorker.Items.Add(employee.name);
                }
            }

            dtContactDate.Format = DateTimePickerFormat.Custom;
            dtContactDate.CustomFormat = "dd/MM/yyyy";
            dtContactDate.MaxDate = DateTime.Today;

            lbKadasWork.Items.Add(Globals.KadasApprovePDF);
            lbKadasWork.Items.Add(Globals.KadasNewPDF);
            lbKadasWork.Items.Add(Globals.KadasSunCopyNew);
            lbKadasWork.Items.Add(Globals.KadasGraphicUpdate);

            lbStudioWork.Items.Add(Globals.StudioOnlyPrisa);
            lbStudioWork.Items.Add(Globals.StudioPrisaForOffer);
            lbStudioWork.Items.Add(Globals.StudioOnlyModel);
            lbStudioWork.Items.Add(Globals.StudioPrisaAndModel);
            lbStudioWork.Items.Add(Globals.StudioCutModel);

            if (Globals.UserGroupID != Globals.AdminID)
            {
                pbSalesUpdate.Visible = false;
                lblSalesUpdate.Visible = false;
            }

            this.order = selectedOrder;
            this.isEnabled = false;
            ChangeScreenUI();
            initScreenValues();
        }

        private void initScreenValues()
        {
            tbSalesAgent.Text = this.order.sales_agent_name;
            tbClientNumber.Text = this.order.client_id + "";
            dtContactDate.Value = this.order.contact_date.Value.Date;
            tbFilesNo.Text = this.order.files_number + "";
            tbTemplateNumber.Text = this.order.template_id;
            tbPrisaNumber.Text = this.order.prisa_id;
            tbClientOrderNum.Text = this.order.client_order_id;
            tbProjDesc.Text = this.order.project_desc;
            tbAmount.Text = this.order.amount + "";
            lbStudioWork.SelectedItem = this.order.studio_work;
            lbKadasWork.SelectedItem = this.order.kadas_work;
            tbModelNumber.Text = this.order.model_id;
            
            tbl_clients client = Globals.AllClients.Where(a => a.ID == order.client_id).SingleOrDefault<tbl_clients>();

            if(client != null)
            {
                tbClientName.Text = client.name;
                lbResponseWorker.SelectedItem = client.person_responsible;
            }

            tbActionType.Text = Globals.AllActions.Where(a => a.ID == order.action_type_id).Single<tbl_sla_actions>().desc;
            
            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_user_groups userGroup = context.tbl_user_groups
                                    .Where(s => s.ID == order.curr_departnent_id)
                                                    .FirstOrDefault<tbl_user_groups>();

                    if (userGroup != null)
                    {
                        tbCurrentDepartment.Text = userGroup.name;
                    }

                    tbl_orders_id[] orderNumbers = context.tbl_orders_id
                                    .Where(s => s.order_id == order.ID)
                                                    .ToArray<tbl_orders_id>();

                    if(orderNumbers.Length > 0)
                    {
                        for(int i = 0; i < orderNumbers.Length; i++)
                        {
                            cbOrderNumbers.Items.Add(orderNumbers[i].heret_order_id);
                        }

                        cbOrderNumbers.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }

            switch(this.order.current_status_id)
            {
                case Globals.StatusInWork:
                    tbWorkStatus.Text = Globals.StatusJobInWork;
                    break;

                case Globals.StatusClosed:
                    tbWorkStatus.Text = Globals.StatusJobClosed;
                    break;

                default:
                    break;
            }
        }

        private void pbSalesUpdate_Click(object sender, EventArgs e)
        {
            if (this.order.current_status_id == Globals.StatusClosed)
            {
                tbPanel.Text = "שגיאה ! הזמנה זו סגורה אין באפשרותך לערוך את פרטיה";
            }
            else
            {
                this.isEnabled = !this.isEnabled;

                ChangeScreenUI();
            }
        }

        private void ChangeScreenUI()
        {
            Color color;
            if(this.isEnabled)
            {
                color = Color.White;
                lblSalesUpdate.Text = "הצג הזמנה";
            }
            else
            {
                color = Color.Wheat;
                lblSalesUpdate.Text = "ערוך הזמנה";
            }

            // Change The availability of the item
            //tbSalesAgent.Enabled = this.isEnabled;
            //tbClientName.Enabled = this.isEnabled;
            tbClientNumber.Enabled = this.isEnabled;
            tbModelNumber.Enabled = this.isEnabled;
            dtContactDate.Enabled = this.isEnabled;
            tbFilesNo.Enabled = this.isEnabled;
            tbTemplateNumber.Enabled = this.isEnabled;
            tbPrisaNumber.Enabled = this.isEnabled;
            tbClientOrderNum.Enabled = this.isEnabled;
            tbProjDesc.Enabled = this.isEnabled;
            tbAmount.Enabled = this.isEnabled;
            lbStudioWork.Enabled = this.isEnabled;
            lbResponseWorker.Enabled = this.isEnabled;
            //tbCurrentDepartment.Enabled = this.isEnabled;
            //tbActionType.Enabled = this.isEnabled;
            //tbOrderNumber.Enabled = this.isEnabled;
            //tbWorkStatus.Enabled = this.isEnabled;
            lbKadasWork.Enabled = this.isEnabled;

            // Change the color of the item
            //tbSalesAgent.BackColor = color;
            //tbClientName.BackColor = color;
            tbClientNumber.BackColor = color;
            tbModelNumber.BackColor = color;
            dtContactDate.BackColor = color;
            tbFilesNo.BackColor = color;
            tbTemplateNumber.BackColor = color;
            tbPrisaNumber.BackColor = color;
            tbClientOrderNum.BackColor = color;
            tbProjDesc.BackColor = color;
            tbAmount.BackColor = color;
            lbStudioWork.BackColor = color;
            //tbCurrentDepartment.BackColor = color;
            //tbActionType.BackColor = color;
            //tbOrderNumber.BackColor = color;
            //tbWorkStatus.BackColor = color;
            lbKadasWork.BackColor = color;
            lbResponseWorker.BackColor = color;

            // Button save ui properties change
            lblSave.Visible = this.isEnabled;
            btnSave.Visible = this.isEnabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean isConvertionOk;
            int nAmount, nClientID, nFilesNo;
            string strToConvert;

            //this.order.sales_agent_name = tbSalesAgent.Text;
            this.order.contact_date = dtContactDate.Value.Date;
            this.order.template_id = tbTemplateNumber.Text;
            this.order.prisa_id = tbPrisaNumber.Text;
            this.order.client_order_id = tbClientOrderNum.Text;
            this.order.project_desc = tbProjDesc.Text;
            this.order.model_id = tbModelNumber.Text;
            //this.order.order_number = tbOrderNumber.Text;
            if (lbStudioWork.SelectedItem != null)
            {
                this.order.studio_work = lbStudioWork.SelectedItem.ToString();
            }
            
            if (lbKadasWork.SelectedItem != null)
            {
                this.order.kadas_work = lbKadasWork.SelectedItem.ToString();
            }
            
            if (tbClientName.Text == "")
            {
                tbPanel.Text = "שגיאה ! מספר הלקוח שהוכנס אינו קיים במערכת";
            }
            else
            {
                // Convert Files Number
                strToConvert = tbFilesNo.Text.ToString().Trim(' ');

                if (!strToConvert.Equals(String.Empty))
                {
                    isConvertionOk = int.TryParse(strToConvert, out nFilesNo);

                    if (!isConvertionOk)
                    {
                        tbFilesNo.BackColor = Color.Tomato;
                        tbPanel.Text = "שגיאה ! אנא הזן ספרות בלבד בשדה מספר קבצים";
                    }
                    else
                    {
                        tbFilesNo.BackColor = Color.White;
                        this.order.files_number = nFilesNo;

                        // Convert amount
                        strToConvert = tbAmount.Text.ToString().Trim(' ');

                        if (!strToConvert.Equals(String.Empty))
                        {
                            isConvertionOk = int.TryParse(strToConvert, out nAmount);

                            if (!isConvertionOk)
                            {
                                tbAmount.BackColor = Color.Tomato;
                                tbPanel.Text = "שגיאה ! אנא הזן ספרות בלבד בשדה כמות";
                            }
                            else
                            {
                                tbAmount.BackColor = Color.White;
                                this.order.amount = nAmount;

                                // Convert the client number
                                strToConvert = tbClientNumber.Text.ToString().Trim(' ');

                                if (!strToConvert.Equals(String.Empty))
                                {
                                    isConvertionOk = int.TryParse(strToConvert, out nClientID);

                                    if (!isConvertionOk)
                                    {
                                        tbClientNumber.BackColor = Color.Tomato;
                                        tbPanel.Text = "שגיאה ! אנא הזן ספרות בלבד בשדה מספר לקוח";
                                    }
                                    else
                                    {
                                        tbClientNumber.BackColor = Color.White;
                                        this.order.client_id = nClientID;

                                        // Save the changes in the db
                                        try
                                        {
                                            using (var context = new DB_Entities())
                                            {
                                                context.tbl_orders.Attach(order);
                                                var Entry = context.Entry(order);

                                                Entry.Property(o => o.contact_date).IsModified = true;
                                                Entry.Property(o => o.template_id).IsModified = true;
                                                Entry.Property(o => o.prisa_id).IsModified = true;
                                                Entry.Property(o => o.project_desc).IsModified = true;
                                                Entry.Property(o => o.model_id).IsModified = true;
                                                Entry.Property(o => o.studio_work).IsModified = true;
                                                Entry.Property(o => o.kadas_work).IsModified = true;
                                                Entry.Property(o => o.files_number).IsModified = true;
                                                Entry.Property(o => o.amount).IsModified = true;
                                                Entry.Property(o => o.client_id).IsModified = true;

                                                tbl_clients client = Globals.AllClients.Where(a => a.ID == order.client_id).SingleOrDefault<tbl_clients>();
                                                context.tbl_clients.Attach(client);
                                                var Entry2 = context.Entry(client);
                                                if(!lbResponseWorker.SelectedItem.ToString().Equals(client.person_responsible))
                                                {
                                                    client.person_responsible = lbResponseWorker.SelectedItem.ToString();
                                                    Entry2.Property(o => o.person_responsible).IsModified = true;
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
                                else
                                {
                                    tbPanel.Text = "עליך למלא את השדה מספר לקוח";
                                }
                            }
                        }
                        else
                        {
                            tbPanel.Text = "עליך למלא את השדה כמות";
                        }
                    }
                }
                else
                {
                    tbPanel.Text = "עליך למלא את השדה מספר קבצים";
                }
            }
        }

        private void tbClientNumber_Leave(object sender, EventArgs e)
        {
            if (!tbClientNumber.Text.ToString().Trim(' ').Equals(String.Empty))
            {
                int nClientNumber;
                Boolean isConvertionOk = int.TryParse(tbClientNumber.Text.ToString(), out nClientNumber);

                if (!isConvertionOk)
                {
                    tbClientNumber.BackColor = Color.Tomato;
                    tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר לקוח";
                }
                else
                {
                    tbClientNumber.BackColor = Color.White;

                    tbl_clients client = Globals.AllClients.Where(a => a.ID == nClientNumber).SingleOrDefault<tbl_clients>();

                    if (client != null)
                    {
                        tbClientName.Text = client.name;
                    }
                    else
                    {
                        tbClientName.Text = String.Empty;
                        tbPanel.Text = "מספר לקוח לא זוהה במערכת";
                    }
                }
            }
            else
            {
                tbClientName.Clear();
            }
        }

        private void ViewAllOrderDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Globals.KeyValueF6)
            {
                using (var form = new SearchClientPopup())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        tbClientNumber.Text = form.IDToReturn.ToString();

                        this.tbClientNumber_Leave(new object(), new EventArgs());
                    }
                }
            }
            else if (e.KeyValue == Globals.KeyValueEnter)
            {
                if (tbClientNumber.Focused)
                {
                    this.tbClientNumber_Leave(new object(), new EventArgs());
                }
            }
        }
    }
}
