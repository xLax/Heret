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
    public partial class SearchClientPopup : Form
    {
        private Boolean isMatch = false;
        public int IDToReturn { get; set; }

        public SearchClientPopup()
        {
            InitializeComponent();

            Utilities.GetAllClientsList();
            this.ActiveControl = tbClientName;
        }

        private void tbClientNumber_TextChanged(object sender, EventArgs e)
        {
            SearchByClientID();
        }

        private void SearchByClientID()
        {
            int nClientNumber;
            string strClientNumberToConvert = tbClientNumber.Text.ToString().Trim(' ');

            Boolean isConvertionOk = int.TryParse(strClientNumberToConvert, out nClientNumber);

            if(!strClientNumberToConvert.Equals(String.Empty))
            {
                if (!isConvertionOk)
                {
                    tbClientNumber.BackColor = Color.Tomato;
                    tbPanel.Text = "שגיאה ! אנא הזן ספרות בשדה מספר לקוח";
                    isMatch = false;
                }
                else
                {
                    tbl_clients client = Globals.AllClients.
                            Where(a => a.ID == nClientNumber).SingleOrDefault<tbl_clients>();

                    if (client != null)
                    {
                        tbClientName.Text = client.name;

                        tbClientName.Enabled = false;
                        tbClientNumber.Enabled = false;
                        isMatch = true;
                    }
                    else
                    {
                        isMatch = false;
                    }
                }
            }
        }

        private void tbClientName_TextChanged(object sender, EventArgs e)
        {
            SearchByClientName();
        }

        private void SearchByClientName()
        {
            List<tbl_clients> lstclients = new List<tbl_clients>();

            lstclients = Globals.AllClients.
                        Where(a => a.name.Contains(tbClientName.Text.ToString())).ToList<tbl_clients>();

            if(tbClientName.Text.ToString().Equals(String.Empty))
            {
                tbPanel.Clear();
            }
            else if (lstclients.Count == 1)
            {
                tbClientNumber.Text = lstclients[0].ID.ToString();
                tbPanel.Text = "נמצאה התאמה";

                tbClientName.BackColor = Color.White;
                tbClientNumber.BackColor = Color.White;

                tbClientName.Enabled = false;
                tbClientNumber.Enabled = false;

                isMatch = true;
            }
            else if (lstclients.Count > 1)
            {
                tbPanel.Text = "יש יותר מלקוח אחד בשם הזה";
                isMatch = false;
            }
            else
            {
                tbPanel.Clear();
                isMatch = false;
            }
        }

        private void pbClean_Click(object sender, EventArgs e)
        {
            tbClientName.Enabled = true;
            tbClientNumber.Enabled = true;

            tbClientName.Clear();
            tbClientNumber.Clear();
            tbPanel.Clear();

            this.ActiveControl = tbClientName;

            isMatch = false;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (isMatch)
            {
                try
                {
                    this.IDToReturn = int.Parse(tbClientNumber.Text.ToString());

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception ex)
                {
                    tbPanel.Text = "שגיאה לא ידועה";
                }
            }
        }
    }
}
