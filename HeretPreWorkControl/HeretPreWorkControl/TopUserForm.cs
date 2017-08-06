using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class TopUserForm : Form
    {
        private DataSet Result;

        public TopUserForm()
        {
            InitializeComponent();
        }

        private void TopUserForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "שלום " + Globals.Name;
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            new CreateUserForm().Show();
        }

        private void TopUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGetClientsFromExcel_Click(object sender, EventArgs e)
        {
            /*    Excel excel = new Excel("D:\\פרויקט חרט\\קובץ לקוחות.xlsx", 1);

                Dictionary<int, string[]> dictionary = excel.ReadFrom(2, 1);
                using (var context = new DB_Entities())
                {
                    try
                    {
                        foreach (var item in dictionary)
                        {
                            tbl_clients client = new tbl_clients();
                            client.ID = item.Key;
                            client.name = item.Value[0].ToString();

                            if (item.Value[1] != null)
                            {
                                client.english_name = item.Value[1].ToString();
                            }

                            client.status = item.Value[2].ToString();
                            client.person_responsible = item.Value[3].ToString();


                            context.tbl_clients.AddOrUpdate(client);
                        }

                        context.SaveChanges();

                        tbPanel.Text = "שמירה בוצעה בהצלחה";
                    }
                    catch(Exception ex)
                    {
                        tbPanel.Text = "שגיאה נסה שוב";
                    }
                }*/
        }
    }
}
