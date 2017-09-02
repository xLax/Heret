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
    public partial class ShowAllNotificationsForm : Form
    {
        public ShowAllNotificationsForm()
        {
            InitializeComponent();

            if (Globals.lstAllNotifications == null)
            {
                Globals.lstAllNotifications = new List<string>();
                tbPanel.Text = "אין התראות חדשות";
            }
            else
            {
                tbPanel.Text = "";

                foreach (string Note in Globals.lstAllNotifications)
                {
                    ListViewItem currItem = new ListViewItem(Note);

                    lvListView.Items.Add(currItem);
                }
            }
        }

        private void pbSetWatched_Click(object sender, EventArgs e)
        {
            Globals.lstAllNotifications.Clear();

            if (Globals.UserGroupID == Globals.SalesUserID)
            {
                Globals.SalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon;
            }
            else if (Globals.UserGroupID != Globals.AdminID)
            {
                Globals.NotSalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon;
            }

            tbPanel.Text = "כל ההתראות נצפו, רענן לנתונים עדכניים";
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            lvListView.Clear();

            foreach (string Note in Globals.lstAllNotifications)
            {
                ListViewItem currItem = new ListViewItem(Note);

                lvListView.Items.Add(currItem);
            }

            string strIsEmpty = String.Empty;

            if(Globals.lstAllNotifications.Count == 0)
            {
                strIsEmpty = " אין התראות לצפייה";
            }
            tbPanel.Text = "רענון בוצע בהצלחה!" + strIsEmpty;
        }
    }
}
