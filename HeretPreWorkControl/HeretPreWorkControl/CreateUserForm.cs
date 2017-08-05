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
    public partial class CreateUserForm : Form
    {
        public static int ChosenUserTypeID = 0;

        public CreateUserForm()
        {
            InitializeComponent();

            lbUserType.Items.Add(Globals.SalesUserType);
            lbUserType.Items.Add(Globals.StudioUserType);
            lbUserType.Items.Add(Globals.KadasUserType);
            lbUserType.Items.Add(Globals.OrdersUserType);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (tbWorkerName.Text == "")
            {
                tbPanel.Text = "לא הוזן שם עובד !";
                tbWorkerName.BackColor = Color.Tomato;
            }
            else if(tbUserName.Text == "")
            {
                tbWorkerName.BackColor = Color.White;
                tbPanel.Text = "לא הוזן שם משתמש !";
                tbUserName.BackColor = Color.Tomato;
            }
            else if(tbPassword.Text == "")
            {
                tbUserName.BackColor = Color.White;
                tbPanel.Text = "לא הוזנה סיסמא !";
                tbPassword.BackColor = Color.Tomato;
            }
            else if(lbUserType.SelectedText == "")
            {
                tbPassword.BackColor = Color.White;
                tbPanel.Text = "לא נבחר סוג משתמש !";
                lbUserType.BackColor = Color.Tomato;
            }
            else
            {
                lbUserType.BackColor = Color.White;
                // Add check if the user name or worker name already exists
                // add saving the data in the db
            }
        }

        private void lbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbUserType.SelectedText)
            {
                case Globals.SalesUserType:
                    ChosenUserTypeID = Globals.SalesUserID;
                    break;
                case Globals.StudioUserType:
                    ChosenUserTypeID = Globals.StudioUserID;
                    break;
                case Globals.KadasUserType:
                    ChosenUserTypeID = Globals.KadasUserID;
                    break;
                case Globals.OrdersUserType:
                    ChosenUserTypeID = Globals.OrdersUserID;
                    break;

                default:
                    break;

            }
        }
    }
}
