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
        private tbl_users[] users;

        public CreateUserForm()
        {
            InitializeComponent();

            lbUserType.Items.Add(Globals.SalesUserType);
            lbUserType.Items.Add(Globals.StudioUserType);
            lbUserType.Items.Add(Globals.KadasUserType);
            lbUserType.Items.Add(Globals.OrdersUserType);
            lbUserType.Items.Add(Globals.AdminUserType);

            this.usrNewUser = new tbl_users();

            Utilities.GetAllUserList();

            this.ChosenUserTypeID = 0;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string strUserName = tbUserName.Text.Trim(' ');

            tbWorkerName.BackColor = Color.White;
            tbUserName.BackColor = Color.White;
            tbPassword.BackColor = Color.White;
            lbUserType.BackColor = Color.White;

            if (tbWorkerName.Text == "")
            {
                tbPanel.Text = "לא הוזן שם עובד !";
                tbWorkerName.BackColor = Color.Tomato;
            }
            else if (tbUserName.Text == "")
            {                
                tbPanel.Text = "לא הוזן שם משתמש !";
                tbUserName.BackColor = Color.Tomato;
            }
            else if (tbPassword.Text == "")
            {                
                tbPanel.Text = "לא הוזנה סיסמא !";
                tbPassword.BackColor = Color.Tomato;
            }
            else if (lbUserType.SelectedItem == null)
            {                
                tbPanel.Text = "לא נבחר סוג משתמש !";
                lbUserType.BackColor = Color.Tomato;
            }
            else
            {
                // Set the info of the new user
                this.usrNewUser.ID = Utilities.GetNextUserID();
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
                            userData.name = tbWorkerName.Text;
                            userData.password = tbPassword.Text;
                            userData.user_group_id = ChosenUserTypeID;

                            context.tbl_users.Attach(userData);
                            var Entry = context.Entry(userData);

                            Entry.Property(o => o.name).IsModified = true;
                            Entry.Property(o => o.password).IsModified = true;
                            Entry.Property(o => o.user_group_id).IsModified = true;
                            
                            context.SaveChanges();

                            tbPanel.Text = "המשתמש עודכן בהצלחה !";
                        }
                        else
                        {
                            if (this.usrNewUser.user_group_id == Globals.AdminID)
                            {
                                tbPanel.Text = "אין באפשרותך ליצור משתמש מנהל חדש";
                            }
                            else
                            {
                                context.tbl_users.Add(this.usrNewUser);
                                Globals.AllUsers.Add(this.usrNewUser);
                                context.SaveChanges();
                                tbPanel.Text = "המשתמש נוצר בהצלחה !";
                            }
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
                case Globals.AdminUserType:
                    ChosenUserTypeID = Globals.AdminID;
                    break;

                default:
                    break;

            }
        }

        private void CreateUserForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Globals.KeyValueEnter)
            {
                tbPanel.Text = String.Empty;
                string strUserName = tbUserName.Text.Trim(' ');

                using (var context = new DB_Entities())
                {
                    try
                    {
                        var userData = context.tbl_users
                                        .Where(s => s.user_name == strUserName)
                                                        .FirstOrDefault<tbl_users>();
                        if (userData != null)
                        {
                            tbWorkerName.Text = userData.name;
                            tbUserName.Text = userData.user_name;
                            tbPassword.Text = userData.password;

                            switch (userData.user_group_id)
                            {
                                case Globals.SalesUserID:
                                    lbUserType.SelectedItem = Globals.SalesUserType;
                                    break;
                                case Globals.StudioUserID:
                                    lbUserType.SelectedItem = Globals.StudioUserType;
                                    break;
                                case Globals.KadasUserID:
                                    lbUserType.SelectedItem = Globals.KadasUserType;
                                    break;
                                case Globals.OrdersUserID:
                                    lbUserType.SelectedItem = Globals.OrdersUserType;
                                    break;
                                case Globals.AdminID:
                                    lbUserType.SelectedItem = Globals.AdminUserType;
                                    break;

                                default:
                                    break;

                            }
                            lbUserType_SelectedIndexChanged(sender, e);
                            tbPanel.Text = "שם המשתמש נמצא !";
                        }
                        else
                        {
                            tbWorkerName.Text = String.Empty;
                            tbPassword.Text = String.Empty;
                            tbPanel.Text = "שם משתמש זה אינו קיים במערכת !";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
            }
        }

        private void cbMoveToManager_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
