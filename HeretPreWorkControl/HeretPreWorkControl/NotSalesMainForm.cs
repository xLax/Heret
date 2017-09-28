using System;
using System.Windows.Forms;

namespace HeretPreWorkControl
{
    public partial class NotSalesMainForm : Form
    {
        private int nPrevJobCount;

        public NotSalesMainForm()
        {
            InitializeComponent();
        }

        private void NotSalesMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbMyJobs_Click(object sender, EventArgs e)
        {
            new MyJobsForm().Show();
        }

        private void NotSalesMainForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "שלום ";

            nPrevJobCount = Utilities.GetMyJobCount();

            if (nPrevJobCount > 0)
            {
                Utilities.CreatePopup("התקבלה עבודה חדשה",
                                      "אנא הכנס למסך עבודות לביצוע על מנת לבקר את עבודתך",
                                      Globals.ToMyJobs);

                pbMyJobs.Image = Properties.Resources.My_Jobs_Note;
            }
            else if(nPrevJobCount == 0)
            {
                pbMyJobs.Image = Properties.Resources.My_Jobs;
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }

            Utilities.GetMyNotifications();

            if (pbAllNotifications.Image == null)
            {
                pbAllNotifications.Image = Properties.Resources.All_Notification_Icon;
            }
        }

        private void tmrCheckNewJobsTimer_Tick(object sender, EventArgs e)
        {
            int nCurrJobCount = Utilities.GetMyJobCount();
            string strNoJobsMessage = "אין עבודות לביצוע";

            if (nCurrJobCount > 0)
            {
                if (nCurrJobCount > nPrevJobCount)
                {
                    Utilities.CreatePopup("התקבלה עבודה חדשה",
                                          "אנא הכנס למסך עבודות לביצוע על מנת לבקר את עבודתך",
                                          Globals.ToMyJobs);

                    if (tbPanel.Text.Equals(strNoJobsMessage) ||
                        tbPanel.Text.Equals(String.Empty))
                    {
                        tbPanel.Text = "התקבלה עבודה חדשה !";
                    }

                    nPrevJobCount = nCurrJobCount;
                }
                else if (nCurrJobCount < nPrevJobCount)
                {
                    nPrevJobCount = nCurrJobCount;
                }
                else
                {
                    Utilities.GetMyNotifications();
                }

                pbMyJobs.Image = Properties.Resources.My_Jobs_Note;
            }
            else
            {
                if (nCurrJobCount < nPrevJobCount)
                {
                    nPrevJobCount = nCurrJobCount;
                }

                pbMyJobs.Image = Properties.Resources.My_Jobs;
                tbPanel.Text = strNoJobsMessage;
            }
        }

        private void pbAllNotifications_Click(object sender, EventArgs e)
        {
            new ShowAllNotificationsForm().ShowDialog();
        }
    }
}
