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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            dtContactDate.Format = DateTimePickerFormat.Custom;
            dtContactDate.CustomFormat = "dd/MM/yyyy";
            dtContactDate.MaxDate = DateTime.Today;

            lbPriseTempDesc.Items.Add(Globals.PrisaNumber);
            lbPriseTempDesc.Items.Add(Globals.TemplateNumber);
            lbPriseTempDesc.Items.Add(Globals.ProjectDesc);

            tbSalesAgent.Text = Globals.Name;

            Utilities.GetAllClientsList();
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

                    if(client != null)
                    {
                        tbClientName.Text = client.name;

                        SetFieldsEnabled(true);
                    }
                    else
                    {
                        tbClientName.Text = String.Empty;
                        tbPanel.Text = "מספר לקוח לא זוהה במערכת";

                        SetFieldsEnabled(false);
                    }
                }
            }
            else
            {
                tbClientName.Clear();
                SetFieldsEnabled(false);
            }
        }

        private void SetFieldsEnabled(bool isEnabled)
        {
            tbFilesNo.Enabled = isEnabled;
            tbPrisaTempDesc.Enabled = isEnabled;
            lbPriseTempDesc.Enabled = isEnabled;
            tbAmount.Enabled = isEnabled;
            cbMoveToManager.Enabled = isEnabled;

            InsertButton.Enabled = isEnabled;

            if(isEnabled)
            {
                tbFilesNo.BackColor = Color.White;
                tbPrisaTempDesc.BackColor = Color.White;
                lbPriseTempDesc.BackColor = Color.White;
                tbAmount.BackColor = Color.White;
            }
            else
            {
                tbFilesNo.BackColor = Color.Wheat;
                tbPrisaTempDesc.BackColor = Color.Wheat;
                lbPriseTempDesc.BackColor = Color.Wheat;
                tbAmount.BackColor = Color.Wheat;

                tbFilesNo.Clear();
                tbPrisaTempDesc.Clear();
                tbAmount.Clear();

                lbPriseTempDesc.SelectedItem = null;
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            tbl_orders NewOrder = new tbl_orders();
            Boolean isSucceeded = false;

            int nFilesNo, nAmount;
            string strToConvert = tbFilesNo.Text.ToString().Trim(' ');

            if (!strToConvert.Equals(String.Empty))
            {
                Boolean isConvertionOk = int.TryParse(strToConvert, out nFilesNo);

                if (!isConvertionOk)
                {
                    tbFilesNo.BackColor = Color.Tomato;
                    tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר קבצים";
                }
                else
                {
                    tbFilesNo.BackColor = Color.White;

                    if (lbPriseTempDesc.SelectedItem == null)
                    {
                        tbPanel.Text = "שגיאה ! יש לבחור באחת האופציות מהרשימה";
                    }
                    else if (tbPrisaTempDesc.Text.ToString().Trim(' ').Equals(String.Empty))
                    {
                        tbPrisaTempDesc.BackColor = Color.Tomato;
                        tbPanel.Text = "שגיאה ! השדה " + lbPriseTempDesc.SelectedItem.ToString() + " ריק!";
                    }
                    // נשאר רק השדרה כמות
                    else
                    {
                        tbPrisaTempDesc.BackColor = Color.White;
                        strToConvert = tbAmount.Text.ToString().Trim(' ');
                        isConvertionOk = int.TryParse(strToConvert, out nAmount);

                        if (!isConvertionOk)
                        {
                            tbAmount.BackColor = Color.Tomato;
                            tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה כמות";
                        }
                        else
                        {
                            tbAmount.BackColor = Color.White;

                            // הכל טוב
                            NewOrder.ID = Utilities.GetNextOrderID();

                            if (NewOrder.ID != -1)
                            {
                                NewOrder.client_id = int.Parse(tbClientNumber.Text.ToString());
                                NewOrder.sales_agent_name = Globals.Name;

                                NewOrder.contact_date = dtContactDate.Value;
                                NewOrder.creation_date = DateTime.Today.Date;

                                NewOrder.action_type_id = Globals.ActionTypeNewOrder;
                                NewOrder.amount = nAmount;
                                NewOrder.files_number = nFilesNo;

                                NewOrder.current_status_id = Globals.StatusInWork;

                                if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.TemplateNumber))
                                {
                                    NewOrder.template_id = tbPrisaTempDesc.Text.ToString();
                                }
                                else if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.PrisaNumber))
                                {
                                    NewOrder.prisa_id = tbPrisaTempDesc.Text.ToString();
                                }
                                else if (lbPriseTempDesc.SelectedItem.ToString().Equals(Globals.ProjectDesc))
                                {
                                    NewOrder.project_desc = tbPrisaTempDesc.Text.ToString();
                                }

                                if (cbMoveToManager.Checked)
                                {
                                    // Shit you mother fucker
                                }
                                else
                                {
                                    // Keep calm
                                }

                                using (var context = new DB_Entities())
                                {
                                    try
                                    {
                                        context.tbl_orders.Add(NewOrder);
                                        context.SaveChanges();

                                        tbPanel.Text = "ההזמנה נוצרה בהצלחה !";

                                        isSucceeded = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                    }
                                }
                            }
                            else
                            {
                                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                            }
                        }
                    }
                }
            }
            else
            {
                tbPanel.Text = "עליך למלא את השדה מספר קבצים";
            }

            if(isSucceeded)
            {
                Utilities.GetAllActionToDeptList();

                List<tbl_action_to_dept> lstActionsToDept = Globals.AllActionToDept
                                            .Where(ad => ad.action_ID == NewOrder.action_type_id)
                                                        .ToList<tbl_action_to_dept>();

                // פתח מסך ניתוב עבודה לפי ID של מחלקה
                new MovementsForm(lstActionsToDept, NewOrder).Show();
            }
        }

        private void CreateOrderForm_KeyUp(object sender, KeyEventArgs e)
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
                if(tbClientNumber.Focused)
                {
                    this.tbClientNumber_Leave(new object(), new EventArgs());
                }
            }
        }
    }
}
