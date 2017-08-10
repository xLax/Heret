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
    public partial class ViewAllOrderDetails : Form
    {
        private tbl_orders order;
        private bool isEnabled;

        public ViewAllOrderDetails(tbl_orders selectedOrder)
        {
            InitializeComponent();

            dtContactDate.Format = DateTimePickerFormat.Custom;
            dtContactDate.CustomFormat = "dd/MM/yyyy";
            dtContactDate.MaxDate = DateTime.Today;

            this.order = selectedOrder;
            this.isEnabled = false;
            ChangeScreenUI();
            initScreenValues();
        }

        private void initScreenValues()
        {
            tbSalesAgent.Text = this.order.sales_agent_name;
            tbClientNumber.Text = this.order.client_id + "";
            dtContactDate.Value = this.order.contact_date.Value.Date;
            tbFilesNo.Text = this.order.files_number + "";
            tbTemplateNumber.Text = this.order.template_id;
            tbPrisaNumber.Text = this.order.prisa_id;
            tbProjDesc.Text = this.order.project_desc;
            tbAmount.Text = this.order.amount + "";
            tbOrderNumber.Text = this.order.order_number;
            tbStudioWork.Text = this.order.studio_work;
            tbKadasWork.Text = this.order.kadas_work;

            tbl_clients client = Globals.AllClients.Where(a => a.ID == order.client_id).SingleOrDefault<tbl_clients>();

            if(client != null)
            {
                tbClientName.Text = client.name;
            }

            tbActionType.Text = Globals.AllActions.Where(a => a.ID == order.action_type_id).Single<tbl_sla_actions>().desc;
            
            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_user_groups userGroup = context.tbl_user_groups
                                    .Where(s => s.ID == order.curr_departnent_id)
                                                    .FirstOrDefault<tbl_user_groups>();

                    if (userGroup != null)
                    {
                        tbCurrentDepartment.Text = userGroup.name;
                    }
                    
                }
                catch (Exception ex)
                {
                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                }
            }

            switch(this.order.current_status_id)
            {
                case Globals.StatusInWork:
                    tbWorkStatus.Text = Globals.StatusJobInWork;
                    break;

                case Globals.StatusClosed:
                    tbWorkStatus.Text = Globals.StatusJobClosed;
                    break;

                default:
                    break;
            }
        }

        private void pbSalesUpdate_Click(object sender, EventArgs e)
        {
            this.isEnabled = !this.isEnabled;

            ChangeScreenUI();
        }

        private void ChangeScreenUI()
        {
            Color color;
            if(this.isEnabled)
            {
                color = Color.White;
            }
            else
            {
                color = Color.Wheat;
            }

            // Change The availability of the item
            tbSalesAgent.Enabled = this.isEnabled;
            tbClientName.Enabled = this.isEnabled;
            tbClientNumber.Enabled = this.isEnabled;
            dtContactDate.Enabled = this.isEnabled;
            tbFilesNo.Enabled = this.isEnabled;
            tbTemplateNumber.Enabled = this.isEnabled;
            tbPrisaNumber.Enabled = this.isEnabled;
            tbProjDesc.Enabled = this.isEnabled;
            tbAmount.Enabled = this.isEnabled;
            tbStudioWork.Enabled = this.isEnabled;
            tbCurrentDepartment.Enabled = this.isEnabled;
            //tbActionType.Enabled = this.isEnabled;
            tbOrderNumber.Enabled = this.isEnabled;
            //tbWorkStatus.Enabled = this.isEnabled;
            tbKadasWork.Enabled = this.isEnabled;

            // Change the color of the item
            tbSalesAgent.BackColor = color;
            tbClientName.BackColor = color;
            tbClientNumber.BackColor = color;
            dtContactDate.BackColor = color;
            tbFilesNo.BackColor = color;
            tbTemplateNumber.BackColor = color;
            tbPrisaNumber.BackColor = color;
            tbProjDesc.BackColor = color;
            tbAmount.BackColor = color;
            tbStudioWork.BackColor = color;
            tbCurrentDepartment.BackColor = color;
            //tbActionType.BackColor = color;
            tbOrderNumber.BackColor = color;
            //tbWorkStatus.BackColor = color;
            tbKadasWork.BackColor = color;

            // Button save ui properties change
            lblSave.Visible = this.isEnabled;
            btnSave.Visible = this.isEnabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
