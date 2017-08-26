﻿using System;
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
    public partial class SalesMainForm : Form
    {
        private int nPrevJobCount;

        public SalesMainForm()
        {
            InitializeComponent();
        }

        private void SalesMainForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "שלום " + Globals.Name;

            nPrevJobCount = Utilities.GetMyJobCount();

            if (nPrevJobCount > 0)
            {
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

            int nDeclinedOrdersCount = Utilities.GetNewDeclinedOrdersAndCount();

            if (nDeclinedOrdersCount > 0)
            {
                pbEnterDeclinedOrder.Image = Properties.Resources.Enter_Rejected_Job_Icon_Note;

                Utilities.CreatePopup("עליך להזין עבודה שנדחתה",
                                      "הצעת מחיר שלא נענתה על ידי הלקוח תוך שבועיים." +
                                      "אנא הכנס למסך הזנת הזמנות שנדחו והזן את פרטי ההזמנה",
                                      Globals.ToDeclinedOrders);

                tbPanel.Text = "יש להזין הזמנה שנדחתה !";
            }
            else if(nDeclinedOrdersCount == 0)
            {
                if (nPrevJobCount > 0)
                {
                    Utilities.CreatePopup("התקבלה עבודה חדשה",
                                          "אנא הכנס למסך עבודות לביצוע על מנת לבקר את עבודתך",
                                          Globals.ToMyJobs);
                }

                pbEnterDeclinedOrder.Image = Properties.Resources.Enter_Rejected_Job_Icon;
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }

            Utilities.GetMyNotifications();

            if(pbAllNotifications.Image == null)
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

        private void pbMyJobs_Click(object sender, EventArgs e)
        {
            new MyJobsForm().Show();
        }

        private void tmrTimerDeclinedJob_Tick(object sender, EventArgs e)
        {
            int nDeclinedOrdersCount = Utilities.GetNewDeclinedOrdersAndCount();

            if (nDeclinedOrdersCount > 0)
            {
                pbEnterDeclinedOrder.Image = Properties.Resources.Enter_Rejected_Job_Icon_Note;

                Utilities.CreatePopup("עליך להזין עבודה שנדחתה",
                                      "הצעת מחיר שלא נענתה על ידי הלקוח תוך שבועיים." +
                                      "אנא הכנס למסך הזנת הזמנות שנדחו והזן את פרטי ההזמנה",
                                      Globals.ToDeclinedOrders);

                tbPanel.Text = "יש להזין הזמנה שנדחתה !";

            }
            else if(nDeclinedOrdersCount == 0)
            {
                pbEnterDeclinedOrder.Image = Properties.Resources.Enter_Rejected_Job_Icon;
            }
            else
            {
                tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
            }
        }

        private void pbEnterDeclinedOrder_Click(object sender, EventArgs e)
        {
            if(Globals.MyDeclinedOrders.Count == 0)
            {
                tbPanel.Text = "אין הזמנות שנדחו שצריך להזין";
                // new EnterDeclinedOrdersForm(new tbl_orders()).Show();
            }
            else
            {
                foreach (tbl_orders Order in Globals.MyDeclinedOrders)
                {
                    new EnterDeclinedOrdersForm(Order).Show();
                }
            }   
        }

        private void SalesMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            new CreateClientForm().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new CreateOrderForm().Show();
        }

        private void pbAllNotifications_Click(object sender, EventArgs e)
        {
            new ShowAllNotificationsForm().ShowDialog();
        }
    }
}
