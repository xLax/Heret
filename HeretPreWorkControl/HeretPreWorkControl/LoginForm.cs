using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            String strUserName = tbUserName.Text.Trim(' ');
            String strPassword = tbPassword.Text;

            if(strUserName == String.Empty)
            {
                tbPanel.Text = "שגיאה! עליך להזין שם משתמש";
                tbUserName.BackColor = Color.Tomato;
                tbPassword.BackColor = Color.White;
            }
            else
            {
                tbUserName.BackColor = Color.White;

                if(strPassword == String.Empty)
                {
                    tbPanel.Text = "שגיאה! עליך להזין סיסמא";
                    tbPassword.BackColor = Color.Tomato;
                }
                else
                {
                    tbPassword.BackColor = Color.White;

                    using (var context = new DB_Entities())
                    {
                        try
                        {
                            var userData = context.tbl_users
                                            .Where(s => s.user_name == strUserName &&
                                                        s.password == strPassword)
                                                            .FirstOrDefault<tbl_users>();
                            if (userData == null)
                            {
                                tbPanel.Text = "שגיאה! שם המשתמש והסיסמא אינם תואמים";
                            }
                            else
                            {
                                tbPanel.Text = "ההתחברות הצליחה !";

                                var userGroupData = context.tbl_user_groups
                                            .Where(s => s.ID == userData.user_group_id)
                                                            .FirstOrDefault<tbl_user_groups>();
                                
                                Utilities.SetGlobalUserData(userData.ID,
                                                            userData.user_name, 
                                                            userData.name, 
                                                            userData.user_group_id,
                                                            userGroupData.name);

                                this.OpenNextForm(userData.user_group_id);

                            }
                        }
                        catch (Exception ex)
                        {
                            tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                        }
                    }
                }
            }
        }

        private void OpenNextForm(int nUserGroupID)
        {
            switch(nUserGroupID)
            {
                case (Globals.AdminID):
                {
                    

                    break;
                }
                case (Globals.SalesUserID):
                {
                    SalesMainForm form = new SalesMainForm();
                    Utilities.SetMainForm(form);
                    form.Show();

                    this.Hide();

                    break;
                }
                // Kadas / Studio / Orders
                default:
                {
                    NotSalesMainForm form = new NotSalesMainForm();
                    Utilities.SetMainForm(form);
                    form.Show();

                    this.Hide();

                    break;
                }
            }
        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            // Key value of the key "Enter"
            if (e.KeyValue == 13)
            {
                this.Login_Button_Click(new object(), new EventArgs());
            }
        }
    }
}
