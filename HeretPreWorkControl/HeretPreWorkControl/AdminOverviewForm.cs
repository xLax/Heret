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
    public partial class AdminOverviewForm : Form
    {
        public AdminOverviewForm()
        {
            InitializeComponent();
        }

        private void AdminOverviewForm_Load(object sender, EventArgs e)
        {
            Utilities.GetAllJobsInWork();
            Utilities.GetAllClientsList();

            dtFromDate.Format = DateTimePickerFormat.Custom;
            dtFromDate.CustomFormat = "dd/MM/yyyy";
            dtFromDate.MaxDate = DateTime.Today;
            dtFromDate.Value = DateTime.Today.Date.AddMonths(-2);

            lbJobStatus.Items.Add(Globals.StatusJobAll);
            lbJobStatus.Items.Add(Globals.StatusJobInWork);
            lbJobStatus.Items.Add(Globals.StatusJobClosed);

            lbJobStatus.SelectedIndex = 0;

            foreach (tbl_orders order in Globals.AllJobs)
            {
                if(order.special_department_id != null &&
                   order.special_department_id != Globals.AdminID)
                {
                    InsertSpecialRow(order);
                }

                InsertRowFromOrder(order);
            }
        }

        private void InsertSpecialRow(tbl_orders order)
        {
            
        }

        private void InsertRowFromOrder(tbl_orders order)
        {
            string strOrderID = order.ID.ToString();

            string strClientName = Globals.AllClients
                .Where(c => c.ID == order.client_id.Value).Single<tbl_clients>().name;

            string strThirdCol = Utilities.GetDateInNormalFormat(order.contact_date.Value);


        }
    }
}
