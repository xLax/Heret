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
        private tbl_clients ModifiedClient;

        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void tbClientNumber_Leave(object sender, EventArgs e)
        {
            if (!tbClientNumber.Text.ToString().Equals(String.Empty))
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

                    tbl_clients currClient = FindClient(nClientNumber);

                    // Set default values
                    if (currClient == null)
                    {
                        tbClientName.Clear();
                        tbEnglishClientName.Clear();
                        lbStatusClient.SelectedItem = lbStatusClient.Items[0];
                        lbResponsibleEmployee.SelectedItem = lbResponsibleEmployee.Items[0];

                        this.ModifiedClient = null;
                    }
                    // If the client exists in the system
                    else
                    {
                        tbClientName.Text = currClient.name;
                        tbEnglishClientName.Text = currClient.english_name;
                        lbStatusClient.SelectedItem = currClient.status;
                        lbResponsibleEmployee.SelectedItem = currClient.person_responsible;

                        this.ModifiedClient = currClient;
                    }
                }
            }
        }

        private tbl_clients FindClient(int nClientNumber)
        {
            Utilities.GetAllClientsList();

            tbl_clients clientToReturn = 
                Globals.AllClients.Where(a => a.ID == nClientNumber).SingleOrDefault<tbl_clients>();

            return clientToReturn;
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            lbStatusClient.Items.Add(Globals.StatusActiveClient);
            lbStatusClient.Items.Add(Globals.StatusBlockedClient);
            lbStatusClient.Items.Add(Globals.StatusLimitedClient);

            Utilities.AllEmployeesForResponsible();

            foreach (tbl_employees employee in Globals.AllEmployeesResp)
            {
                if (employee.Department_id.Equals(Globals.ResponsibleID))
                {
                    lbResponsibleEmployee.Items.Add(employee.name);
                }
            }

            lbStatusClient.SelectedItem = lbStatusClient.Items[0].ToString();
            lbResponsibleEmployee.SelectedItem = lbResponsibleEmployee.Items[0].ToString();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (!tbClientNumber.Text.ToString().Equals(String.Empty))
            {
                int nClientNumber;
                Boolean isConvertionOk = int.TryParse(tbClientNumber.Text.ToString(), out nClientNumber);

                if (!isConvertionOk)
                {
                    tbClientNumber.BackColor = Color.Tomato;
                    tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר לקוח";
                }
                else if (tbClientName.Text.Equals(String.Empty))
                {
                    tbClientName.BackColor = Color.Tomato;
                    tbClientNumber.BackColor = Color.White;
                    tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר לקוח";
                }
                // Need to insert
                else if (this.ModifiedClient == null)
                {
                    this.ModifiedClient = new tbl_clients();

                    this.ModifiedClient.ID = nClientNumber;
                    this.ModifiedClient.name = tbClientName.Text.ToString();
                    this.ModifiedClient.english_name = tbEnglishClientName.Text.ToString();
                    this.ModifiedClient.status = lbStatusClient.SelectedItem.ToString();
                    this.ModifiedClient.person_responsible =
                                lbResponsibleEmployee.SelectedItem.ToString();

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            context.tbl_clients.Add(this.ModifiedClient);

                            context.SaveChanges();

                            tbPanel.Text = "הלקוח נוצר בהצלחה !";
                        }
                        catch (Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
                // Need to update
                else
                {
                    this.ModifiedClient.name = tbClientName.Text.ToString();
                    this.ModifiedClient.english_name = tbEnglishClientName.Text.ToString();
                    this.ModifiedClient.status = lbStatusClient.SelectedItem.ToString();
                    this.ModifiedClient.person_responsible =
                                lbResponsibleEmployee.SelectedItem.ToString();

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            context.tbl_clients.Attach(ModifiedClient);
                            var Entry = context.Entry(ModifiedClient);

                            Entry.Property(o => o.name).IsModified = true;
                            Entry.Property(o => o.person_responsible).IsModified = true;
                            Entry.Property(o => o.status).IsModified = true;
                            Entry.Property(o => o.english_name).IsModified = true;

                            context.SaveChanges();

                            tbPanel.Text = "הלקוח עודכן בהצלחה !";
                        }
                        catch (Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
            }
            else
            {
                tbClientNumber.BackColor = Color.Tomato;
                tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר לקוח";
            }
        }
    }
}
