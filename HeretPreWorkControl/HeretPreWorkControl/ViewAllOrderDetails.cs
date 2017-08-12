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

            dtContactDate.Format = DateTimePickerFormat.Custom;
            dtContactDate.CustomFormat = "dd/MM/yyyy";
            dtContactDate.MaxDate = DateTime.Today;

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
            tbProjDesc.Text = this.order.project_desc;
            tbAmount.Text = this.order.amount + "";
            tbOrderNumber.Text = this.order.order_number;
            tbStudioWork.Text = this.order.studio_work;
            tbKadasWork.Text = this.order.kadas_work;

            tbl_clients client = Globals.AllClients.Where(a => a.ID == order.client_id).SingleOrDefault<tbl_clients>();

            if(client != null)
            {
                tbClientName.Text = client.name;
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
            this.isEnabled = !this.isEnabled;

            ChangeScreenUI();
        }

        private void ChangeScreenUI()
        {
            Color color;
            if(this.isEnabled)
            {
                color = Color.White;
            }
            else
            {
                color = Color.Wheat;
            }

            // Change The availability of the item
            tbSalesAgent.Enabled = this.isEnabled;
            tbClientName.Enabled = this.isEnabled;
            tbClientNumber.Enabled = this.isEnabled;
            dtContactDate.Enabled = this.isEnabled;
            tbFilesNo.Enabled = this.isEnabled;
            tbTemplateNumber.Enabled = this.isEnabled;
            tbPrisaNumber.Enabled = this.isEnabled;
            tbProjDesc.Enabled = this.isEnabled;
            tbAmount.Enabled = this.isEnabled;
            tbStudioWork.Enabled = this.isEnabled;
            tbCurrentDepartment.Enabled = this.isEnabled;
            //tbActionType.Enabled = this.isEnabled;
            tbOrderNumber.Enabled = this.isEnabled;
            //tbWorkStatus.Enabled = this.isEnabled;
            tbKadasWork.Enabled = this.isEnabled;

            // Change the color of the item
            tbSalesAgent.BackColor = color;
            tbClientName.BackColor = color;
            tbClientNumber.BackColor = color;
            dtContactDate.BackColor = color;
            tbFilesNo.BackColor = color;
            tbTemplateNumber.BackColor = color;
            tbPrisaNumber.BackColor = color;
            tbProjDesc.BackColor = color;
            tbAmount.BackColor = color;
            tbStudioWork.BackColor = color;
            tbCurrentDepartment.BackColor = color;
            //tbActionType.BackColor = color;
            tbOrderNumber.BackColor = color;
            //tbWorkStatus.BackColor = color;
            tbKadasWork.BackColor = color;

            // Button save ui properties change
            lblSave.Visible = this.isEnabled;
            btnSave.Visible = this.isEnabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean isConvertionOk;
            int nAmount, nClientID, nFilesNo;
            string strToConvert;

            this.order.sales_agent_name = tbSalesAgent.Text;
            this.order.contact_date = dtContactDate.Value.Date;
            this.order.template_id = tbTemplateNumber.Text;
            this.order.prisa_id = tbPrisaNumber.Text;
            this.order.project_desc = tbProjDesc.Text;
            this.order.order_number = tbOrderNumber.Text;
            this.order.studio_work = tbStudioWork.Text;
            this.order.kadas_work = tbKadasWork.Text;

            tbClientNumber.Text = this.order.client_id + "";

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
        //if (lbPriseTempDesc.SelectedItem == null)
        //{
        //    tbPanel.Text = "שגיאה ! יש לבחור באחת האופציות מהרשימה";
        //}
        //else if (tbPrisaTempDesc.Text.ToString().Trim(' ').Equals(String.Empty))
        //{
        //    tbPrisaTempDesc.BackColor = Color.Tomato;
        //    tbPanel.Text = "שגיאה ! השדה " + lbPriseTempDesc.SelectedItem.ToString() + " ריק!";
        //}
        //// נשאר רק השדרה כמות
        //else
        //{
        //    tbPrisaTempDesc.BackColor = Color.White;
        //    strToConvert = tbAmount.Text.ToString().Trim(' ');
        //    isConvertionOk = int.TryParse(strToConvert, out nAmount);

        //    if (!isConvertionOk)
        //    {
        //        tbAmount.BackColor = Color.Tomato;
        //        tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה כמות";
        //    }
        //    else
        //    {
        //        tbAmount.BackColor = Color.White;

        //        // הכל טוב
        //        NewOrder.ID = Utilities.GetNextOrderID();

        //        if (NewOrder.ID != -1)
        //        {
        //            NewOrder.client_id = int.Parse(tbClientNumber.Text.ToString());
        //            NewOrder.sales_agent_name = Globals.Name;

        //            NewOrder.dep_recieve_date = DateTime.Today.Date;
        //            NewOrder.dep_recieve_hour = DateTime.Now.TimeOfDay;

        //            NewOrder.contact_date = dtContactDate.Value;
        //            NewOrder.creation_date = DateTime.Today.Date;

        //            NewOrder.action_type_id = Globals.ActionTypeNewOrder;
        //            NewOrder.amount = nAmount;
        //            NewOrder.files_number = nFilesNo;

        //            NewOrder.current_status_id = Globals.StatusInWork;

        //            if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.TemplateNumber))
        //            {
        //                NewOrder.template_id = tbPrisaTempDesc.Text.ToString();
        //            }
        //            else if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.PrisaNumber))
        //            {
        //                NewOrder.prisa_id = tbPrisaTempDesc.Text.ToString();
        //            }
        //            else if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.ProjectDesc))
        //            {
        //                NewOrder.project_desc = tbPrisaTempDesc.Text.ToString();
        //            }

        //            string strPromoteMessage = String.Empty;

        //            if (cbMoveToManager.Checked)
        //            {
        //                // Shit you mother fucker
        //                NewOrder.special_department_id = Globals.AdminID;
        //                strPromoteMessage = "ובקשת קידום נשלחה";
        //            }
        //            else
        //            {
        //                // Keep calm
        //            }

        //            if (NewOrder.creation_date.Value.AddDays(-2) >= NewOrder.contact_date)
        //            {
        //                NewOrder.alert_creation_date = Globals.AlertNow;
        //            }

        //            using (var context = new DB_Entities())
        //            {
        //                try
        //                {
        //                    context.tbl_orders.Add(NewOrder);
        //                    context.SaveChanges();

        //                    tbPanel.Text = "ההזמנה נוצרה בהצלחה ! " + strPromoteMessage;

        //                    isSucceeded = true;
        //                }
        //                catch (Exception ex)
        //                {
        //                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
        //                }
        //            }
        //        }
        //        else
        //        {
        //            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
        //        }
        //    }
        //}

    }
}
