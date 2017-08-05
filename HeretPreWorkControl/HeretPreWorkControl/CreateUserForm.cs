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
        private int ChosenUserTypeID;
        private tbl_users usrNewUser;

        public CreateUserForm()
        {
            InitializeComponent();

            lbUserType.Items.Add(Globals.SalesUserType);
            lbUserType.Items.Add(Globals.StudioUserType);
            lbUserType.Items.Add(Globals.KadasUserType);
            lbUserType.Items.Add(Globals.OrdersUserType);

            this.usrNewUser = new tbl_users();
            this.ChosenUserTypeID = 0;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string strUserName = tbUserName.Text.Trim(' ');

            if (tbWorkerName.Text == "")
            {
                tbPanel.Text = "לא הוזן שם עובד !";
                tbWorkerName.BackColor = Color.Tomato;
            }
            else if (tbUserName.Text == "")
            {
                tbWorkerName.BackColor = Color.White;
                tbPanel.Text = "לא הוזן שם משתמש !";
                tbUserName.BackColor = Color.Tomato;
            }
            else if (tbPassword.Text == "")
            {
                tbUserName.BackColor = Color.White;
                tbPanel.Text = "לא הוזנה סיסמא !";
                tbPassword.BackColor = Color.Tomato;
            }
            else if (lbUserType.SelectedText == "")
            {
                tbPassword.BackColor = Color.White;
                tbPanel.Text = "לא נבחר סוג משתמש !";
                lbUserType.BackColor = Color.Tomato;
            }
            else
            {
                lbUserType.BackColor = Color.White;

                // Set the info of the new user
                this.usrNewUser.name = tbWorkerName.Text;
                this.usrNewUser.user_group_id = ChosenUserTypeID;
                this.usrNewUser.user_name = tbUserName.Text;
                this.usrNewUser.password = tbPassword.Text;

                using (var context = new DB_Entities())
                {
                    try
                    {
                        var userData = context.tbl_users
                                        .Where(s => s.user_name == strUserName)
                                                        .FirstOrDefault<tbl_users>();
                        if (userData != null)
                        {
                            tbPanel.Text = "שם המשתמש שהוזן קיים כבר במערכת ! יש להזין שם משתמש אחר";
                        }
                        else
                        {
                            context.tbl_users.Add(this.usrNewUser);
                            context.SaveChanges();
                            tbPanel.Text = "המשתמש נוצר בהצלחה !";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
            }
        }

        private void lbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbUserType.SelectedItem)
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
