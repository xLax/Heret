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
                    }
                    else
                    {
                        tbClientName.Text = String.Empty;
                        tbPanel.Text = "מספר לקוח לא זוהה במערכת";
                    }
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {

        }
    }
}
