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
    public partial class MovementsForm : Form
    {
        private List<tbl_action_to_dept> lstActionsToDepartments;
        private tbl_orders currentOrder;
        private Dictionary<int, string> dcAllData = new Dictionary<int, string>();
        private Dictionary<int, string> dcEnglishData = new Dictionary<int, string>();

        private Boolean isSpecial = false;
        private int nActionTypeID = 0;
        private int nSelectedDepartID = 0;

        public MovementsForm(List<tbl_action_to_dept> lstActionsToDept, tbl_orders SelectedOrder, int nActionType)
        {
            InitializeComponent();

            lbKadasWork.Items.Add(Globals.KadasApprovePDF);
            lbKadasWork.Items.Add(Globals.KadasGraphicUpdate);
            lbKadasWork.Items.Add(Globals.KadasNewPDF);
            lbKadasWork.Items.Add(Globals.KadasSunCopyNew);

            lbStudioWork.Items.Add(Globals.StudioCutModel);
            lbStudioWork.Items.Add(Globals.StudioOnlyModel);
            lbStudioWork.Items.Add(Globals.StudioOnlyPrisa);
            lbStudioWork.Items.Add(Globals.StudioPrisaAndModel);
            lbStudioWork.Items.Add(Globals.StudioPrisaForOffer);

            dcEnglishData.Add(Globals.SalesUserID, "Sales");
            dcEnglishData.Add(Globals.KadasUserID, "Kadas");
            dcEnglishData.Add(Globals.StudioUserID, "Studio");
            dcEnglishData.Add(Globals.OrdersUserID, "Orders");

            dtSalesOfferDate.Format = DateTimePickerFormat.Custom;
            dtSalesOfferDate.CustomFormat = "dd/MM/yyyy";
            dtSalesOfferDate.MaxDate = DateTime.Today;
            dtSalesOfferDate.Value = DateTime.Today.Date;

            this.lstActionsToDepartments = lstActionsToDept;
            this.currentOrder = SelectedOrder;
            this.nActionTypeID = nActionType;
        }

        private void MovementsForm_Load(object sender, EventArgs e)
        {
            Utilities.GetAllUserGroupList();

            foreach (tbl_action_to_dept actionToDept in this.lstActionsToDepartments)
            {
                if(!dcAllData.ContainsKey(actionToDept.recieved_department_ID))
                {
                    string strRecievedDept = Globals.AllUserGroups
                        .Where(a => a.ID == actionToDept.recieved_department_ID)
                            .Single<tbl_user_groups>().name;

                    dcAllData.Add(actionToDept.recieved_department_ID, strRecievedDept);

                    dataGridView.Rows.Add(strRecievedDept);
                }                
            }

            Utilities.SetZebraMode(dataGridView);

            HideAllInputFields();
        }

        private void HideAllInputFields()
        {
            foreach (Control control in this.Controls)
            {
                if (!(control is PictureBox) &&
                    !(control is DataGridView))
                {
                    if (!control.Name.Equals("label1") &&
                        !control.Name.Equals("tbPanel"))
                    {
                        control.Visible = false;
                    }
                }
            }
        }

        private void pbMoveButton_Click(object sender, EventArgs e)
        {
            Boolean isSucceded = false;

            if(dataGridView.SelectedRows.Count > 1)
            {
                tbPanel.Text = "אנא בחר מחלקה אחת";
            }
            else if(dataGridView.SelectedRows.Count == 0)
            {
                tbPanel.Text = "אנא בחר מחלקה (סמן את כל השורה )";
            }
            else if(nSelectedDepartID == 0)
            {
                tbPanel.Text = "אנא בחר מחלקה להעברת העבודה";
            }
            else
            {
                if(nSelectedDepartID == Globals.SalesUserID)
                {
                    string strOfferID = tbSalesOfferID.Text.ToString();
                    DateTime dtSentTime = dtSalesOfferDate.Value.Date;

                    tbl_action_to_dept actionToDept =
                        lstActionsToDepartments.Where(a => a.recieved_department_ID == Globals.SalesUserID &&
                                                           a.recieved_department_action_id == Globals.ActionTypeSetAndSendOffer)
                                .SingleOrDefault<tbl_action_to_dept>();

                    if (actionToDept == null)
                    {
                        currentOrder.action_type_id =
                        lstActionsToDepartments.Where(a => a.recieved_department_ID == Globals.SalesUserID)
                                .Single<tbl_action_to_dept>().recieved_department_action_id;
                    }
                    else
                    {
                        currentOrder.action_type_id = actionToDept.recieved_department_action_id;
                    }

                    try
                    {
                        using (var context = new DB_Entities())
                        {
                            if (!strOfferID.Trim(' ').Equals(String.Empty))
                            {
                                tbl_offers currOffer = new tbl_offers();
                                currOffer.offer_id = strOfferID;
                                currOffer.offer_date = dtSentTime;
                                currOffer.order_id = currentOrder.ID;

                                context.tbl_offers.AddOrUpdate(currOffer);
                            }

                            context.SaveChanges();

                            isSucceded = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
                else if(nSelectedDepartID == Globals.KadasUserID)
                {
                    if(lbKadasWork.SelectedItem == null)
                    {
                        tbPanel.Text = "אנא בחר עבודה לביצוע של מחלקת קדם דפוס";
                    }
                    else
                    {
                        if(nActionTypeID == 7 &&
                           currentOrder.special_department_id != null)
                        {
                            isSpecial = true;
                        }
                        else
                        {
                            string strKadasWork = lbKadasWork.SelectedItem.ToString();

                            if (currentOrder.special_department_id != null)
                            {
                                currentOrder.special_action_type_id = Utilities.GetActionTypeIDFormWork(Globals.KadasUserID, strKadasWork);
                                currentOrder.special_recieved_date = System.DateTime.Now.Date;
                                currentOrder.special_recieved_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
                            }
                            else
                            {
                                currentOrder.action_type_id = Utilities.GetActionTypeIDFormWork(Globals.KadasUserID, strKadasWork);
                            }

                            currentOrder.kadas_work = strKadasWork;

                            isSucceded = true;
                        }
                    }                   
                }
                else if(nSelectedDepartID == Globals.StudioUserID)
                {
                    if (lbStudioWork.SelectedItem == null)
                    {
                        tbPanel.Text = "אנא בחר עבודה לביצוע של מחלקת סטודיו";
                    }
                    else
                    {
                        string strStudioWork = lbStudioWork.SelectedItem.ToString();
                        currentOrder.action_type_id = Utilities.GetActionTypeIDFormWork(Globals.StudioUserID, strStudioWork);
                        currentOrder.studio_work = strStudioWork;

                        isSucceded = true;
                    }
                }
                else
                {
                    if(nActionTypeID == 6 &&
                       currentOrder.special_department_id != null)
                    {
                        isSpecial = true;
                    }
                    else
                    {
                        currentOrder.action_type_id = Globals.ActionTypeInsertOrderID;
                        isSucceded = true;
                    }
                }

                if(isSucceded)
                {
                    MyJobsForm.isJobSucceeded = true;

                    if (currentOrder.special_department_id == null ||
                        nSelectedDepartID != Globals.KadasUserID)
                    {
                        currentOrder.curr_departnent_id = nSelectedDepartID;
                        currentOrder.dep_recieve_date = System.DateTime.Now.Date;
                        currentOrder.dep_recieve_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
                    }

                    try
                    {
                        using (var context = new DB_Entities())
                        {
                            context.tbl_orders.Attach(currentOrder);
                            var Entry = context.Entry(currentOrder);

                            Entry.Property(o => o.action_type_id).IsModified = true;
                            Entry.Property(o => o.curr_departnent_id).IsModified = true;
                            Entry.Property(o => o.dep_recieve_date).IsModified = true;
                            Entry.Property(o => o.dep_recieve_hour).IsModified = true;

                            Entry.Property(o => o.special_action_type_id).IsModified = true;
                            Entry.Property(o => o.special_department_id).IsModified = true;
                            Entry.Property(o => o.special_recieved_date).IsModified = true;
                            Entry.Property(o => o.special_recieved_hour).IsModified = true;

                            Entry.Property(o => o.kadas_work).IsModified = true;
                            Entry.Property(o => o.studio_work).IsModified = true;
                            context.SaveChanges();

                            tbPanel.Text = "העברת העבודה התבצעה בהצלחה";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                    }
                }
                else
                {
                    if (isSpecial)
                    {
                        isSpecial = false;

                        if (nSelectedDepartID == Globals.KadasUserID &&
                            currentOrder.special_department_id != Globals.AdminID)
                        {
                            currentOrder.curr_departnent_id = currentOrder.special_department_id;
                            currentOrder.special_department_id = null;

                            using (var context = new DB_Entities())
                            {
                                try
                                {
                                    context.tbl_orders.Attach(currentOrder);
                                    var Entry = context.Entry(currentOrder);

                                    Entry.Property(o => o.curr_departnent_id).IsModified = true;
                                    Entry.Property(o => o.special_department_id).IsModified = true;

                                    context.SaveChanges();
                                    MyJobsForm.isJobSucceeded = true;
                                    tbPanel.Text = "העבודה כבר התקבלה אצל קד\"ס, ונמצאת בתהליך, רענן להמשך תהליך";
                                }
                                catch (Exception ex)
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                        else if(nSelectedDepartID == Globals.OrdersUserID)
                        {
                            tbPanel.Text = "אין באפשרותך להעביר עבודה למחלקת הזמנות, כרגע קיים תהליך מקביל בקד\"ס";
                        }
                        else if(Globals.UserGroupID == Globals.AdminID &&
                                nSelectedDepartID == Globals.KadasUserID &&
                                currentOrder.special_department_id == Globals.AdminID)
                        {
                            string strKadasWork = lbKadasWork.SelectedItem.ToString();
                            currentOrder.special_action_type_id = Utilities.GetActionTypeIDFormWork(Globals.KadasUserID, strKadasWork);
                            currentOrder.special_recieved_date = System.DateTime.Now.Date;
                            currentOrder.special_recieved_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
                            currentOrder.special_department_id = nSelectedDepartID;

                            using (var context = new DB_Entities())
                            {
                                try
                                {
                                    context.tbl_orders.Attach(currentOrder);
                                    var Entry = context.Entry(currentOrder);

                                    Entry.Property(o => o.special_action_type_id).IsModified = true;
                                    Entry.Property(o => o.special_department_id).IsModified = true;
                                    Entry.Property(o => o.special_recieved_date).IsModified = true;
                                    Entry.Property(o => o.special_recieved_hour).IsModified = true;

                                    Entry.Property(o => o.kadas_work).IsModified = true;

                                    context.SaveChanges();

                                    tbPanel.Text = "אישור קידום העבודה התבצע בהצלחה";
                                }
                                catch(Exception ex)
                                {
                                    tbPanel.Text = "שגיאה! החיבור לבסיס הנתונים כשל";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            HideAllInputFields();

            if(dataGridView.SelectedRows.Count == 1 &&
               dataGridView.SelectedRows[0].Cells[0].Value != null)
            {
                string strCellValue = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int nDepartID = dcAllData.Where(a => a.Value.Equals(strCellValue)).Single().Key;

                this.nSelectedDepartID = nDepartID;

                string strToContain = dcEnglishData.Where( a=> a.Key == nDepartID).Single().Value;

                tbl_action_to_dept actionToDept = 
                        lstActionsToDepartments.Where(a => a.recieved_department_ID == Globals.SalesUserID &&
                                                           a.recieved_department_action_id == Globals.ActionTypeSetAndSendOffer)
                                .SingleOrDefault<tbl_action_to_dept>();

                foreach (Control control in this.Controls)
                {
                    if (control.Name.Contains(strToContain))
                    {
                        if(this.nSelectedDepartID == Globals.SalesUserID)
                        {
                            if(actionToDept == null)
                            {
                                control.Visible = false;
                            }
                            else if(actionToDept.recieved_department_action_id == Globals.ActionTypeSetAndSendOffer)
                            {
                                control.Visible = true;
                            }
                        }
                        else
                        {
                            control.Visible = true;
                        }
                    }
                }
            }      
        }
    }
}
