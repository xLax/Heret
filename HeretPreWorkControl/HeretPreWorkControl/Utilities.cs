﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace HeretPreWorkControl
{
    public static class Utilities
    {
        public static PopupNotifier currPopup;

        public static void CreatePopup(String strTitle, String strMessage)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.IsRightToLeft = true;
            popup.Image = Properties.Resources.Notification_Icon;
            popup.TitleText = strTitle;
            popup.ContentText = strMessage;
            popup.Popup();

            if (Globals.UserGroupID == Globals.SalesUserID)
            {
                Globals.SalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
            }
            else if(Globals.UserGroupID != Globals.AdminID)
            {
                Globals.NotSalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
            }

            if(Globals.lstAllNotifications == null)
            {
                Globals.lstAllNotifications = new List<string>();
            }

            Globals.lstAllNotifications.Add(strTitle + " - " + strMessage);
        }

        public static Boolean GetAllJobs()
        {
            Globals.AllJobs = new List<tbl_orders>();
            Boolean isLoadSucceeded = true;

            using (var context = new DB_Entities())
            {
                try
                {
                    if(Globals.UserGroupID == Globals.AdminID)
                    {
                        Globals.AllJobs = context.tbl_orders
                                    .ToList<tbl_orders>();
                    }
                    else
                    {
                        Globals.AllJobs = context.tbl_orders
                            .Where(a => a.sales_agent_name.Equals(Globals.Name))
                                    .ToList<tbl_orders>();
                    }
                }
                catch(Exception ex)
                {
                    isLoadSucceeded = false;
                }
            }

            return isLoadSucceeded;
        }

        public static int GetNextUserID()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_users order = context.tbl_users.OrderByDescending(u => u.ID).FirstOrDefault<tbl_users>();

                    if (order == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = order.ID + 1;
                    }
                }
                catch (Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }

        public static void Popup_Clicked(object sender, System.EventArgs e)
        {
            if(Globals.OpenScreenID == Globals.ToMyJobs)
            {
                new MyJobsForm().Show();
            }
            else if(Globals.OpenScreenID == Globals.ToDeclinedOrders)
            {
                foreach (tbl_orders Order in Globals.MyDeclinedOrders)
                {
                    new EnterDeclinedOrdersForm(Order).Show();
                }
            }
            else if(Globals.OpenScreenID == Globals.ToTamatz)
            {
                // Open תמונת מצב
                new AdminOverviewForm().Show();
            }
            else if(Globals.OpenScreenID == Globals.ToSpecialApprove)
            {
                // Open מסך אישור בקשות קידום עבודה
                new SpecialApprovedJobsForm().Show();
            }

            currPopup.Hide();
        }

        public static List<tbl_notifications> GetMyNotificationsList()
        {
            List<tbl_notifications> lstMyNotes = new List<tbl_notifications>();

            using (var context = new DB_Entities())
            {
                try
                {
                    lstMyNotes = context.tbl_notifications
                        .Where(a => a.sales_agent_name.Equals(Globals.Name)).ToList<tbl_notifications>();
                }
                catch (Exception ex) { };
            }

            return lstMyNotes;
        }

        public static List<tbl_sla_data> GetMySlaData()
        {
            List<tbl_sla_data> lstMyNotes = new List<tbl_sla_data>();

            using (var context = new DB_Entities())
            {
                try
                {
                    lstMyNotes = context.tbl_sla_data
                    .Where(a => a.employee_name.Equals(Globals.Name)).ToList<tbl_sla_data>();
                }
                catch (Exception ex) { };
            }

            return lstMyNotes;
        }

        public static string GetStatusDesc(int nStatusID)
        {
            string strStatusDesc = String.Empty;

            if(nStatusID == Globals.StatusInWork)
            {
                strStatusDesc = Globals.StatusJobInWork;
            }
            else if(nStatusID == Globals.StatusClosed)
            {
                strStatusDesc = Globals.StatusJobClosed;
            }
            else if(nStatusID == Globals.StatusDenied)
            {
                strStatusDesc = Globals.StatusJobDenied;
            }

            return strStatusDesc;
        }

        public static int GetAllSlaData()
        {
            int nResult = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    Globals.AllSlaData = context.tbl_sla_data.ToList<tbl_sla_data>();
                }
                catch (Exception ex)
                {
                    nResult = -1;
                }
            }

            return nResult;
        }

        public static Boolean GetMyNotifications()
        {
            List<tbl_notifications> notes;
            Boolean isSucceeded = true;

            using (var context = new DB_Entities())
            {
                try
                {
                    if (Globals.UserGroupID == Globals.SalesUserID)
                    {
                        notes = context.tbl_notifications.
                            Where(n => n.Deparment_id == Globals.UserGroupID &&
                                       n.sales_agent_name == Globals.Name)
                                        .ToList<tbl_notifications>();
                    }
                    else
                    {
                        notes = context.tbl_notifications.
                                Where(n => n.Deparment_id == Globals.UserGroupID)
                                            .ToList<tbl_notifications>();
                    }

                    foreach (tbl_notifications Note in notes)
                    {
                        Utilities.CreatePopup("תזכורת מנהל", "מנהל המערכת מתזכר אותך לבצע את עבודתך בהזמנה מספר " + Note.order_id);

                        if (Globals.UserGroupID == Globals.SalesUserID)
                        {
                            Globals.SalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
                        }
                        else if (Globals.UserGroupID != Globals.AdminID)
                        {
                            Globals.NotSalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
                        }

                        if(Globals.lstAllNotifications == null)
                        {
                            Globals.lstAllNotifications = new List<string>();
                        }
                    }

                    context.tbl_notifications.RemoveRange(notes);

                    context.SaveChanges();
                }
                catch (Exception ex) { isSucceeded = false; }
            }

            return isSucceeded;

        }

        public static void GetAllUserGroupList()
        {
            List<tbl_user_groups> lstUserGroups;

            if (Globals.AllUserGroups == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstUserGroups = context.tbl_user_groups.ToList<tbl_user_groups>();
                        Utilities.SetAllUserGroupsList(lstUserGroups);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        public static void GetAllUserList()
        {
            List<tbl_users> lstUsers;

            if (Globals.AllUsers == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstUsers = context.tbl_users.ToList<tbl_users>();
                        Globals.AllUsers = lstUsers;
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private static void SetAllUserGroupsList(List<tbl_user_groups> lstUserGroups)
        {
            Globals.AllUserGroups = lstUserGroups;
        }

        public static void GetAllActionToDeptList()
        {
            List<tbl_action_to_dept> lstActionsToDept;

            if (Globals.AllActionToDept == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstActionsToDept = context.tbl_action_to_dept.ToList<tbl_action_to_dept>();
                        Utilities.SetAllActionToDeptList(lstActionsToDept);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private static void SetAllActionToDeptList(List<tbl_action_to_dept> lstActionsToDept)
        {
            Globals.AllActionToDept = lstActionsToDept;
        }

        public static bool CalculateSlaStatus(DateTime begin_date, TimeSpan begin_hour, int sla_hours, DateTime currCalcDate)
        {
            if((currCalcDate - begin_date).TotalHours + (new TimeSpan(13,0,0) - begin_hour).TotalHours >= sla_hours)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AllEmployeesForResponsible()
        {
            List<tbl_employees> lstEmployees;

            if (Globals.AllEmployeesResp == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstEmployees = context.tbl_employees.ToList<tbl_employees>();
                        Utilities.SetAllEmployeesResp(lstEmployees);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private static void SetAllEmployeesResp(List<tbl_employees> lstEmployees)
        {
            Globals.AllEmployeesResp = lstEmployees;
        }

        public static void GetAllClientsList()
        {
            List<tbl_clients> lstClients;

            if(Globals.AllClients == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstClients = context.tbl_clients.ToList<tbl_clients>();
                        Utilities.SetClientList(lstClients);
                    }
                    catch(Exception ex) { }
                }
            }
        }

        public static void GetAllActionsList()
        {
            List<tbl_sla_actions> lstActions;

            if (Globals.AllActions == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        lstActions = context.tbl_sla_actions.ToList<tbl_sla_actions>();
                        Utilities.SetActionsList(lstActions);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        public static void SetSpecialApprovedJobs(List<tbl_orders> lstSpecialApprovedOrders)
        {
            Globals.SpecialApprovedJobs = lstSpecialApprovedOrders;
        }

        public static string GetDateInNormalFormat(DateTime date)
        {
            string strDayVal = date.Day.ToString();
            string strMonthVal = date.Month.ToString();
            string strYearVal = date.Year.ToString();

            return strDayVal + "/" + strMonthVal + "/" + strYearVal;
        }

        // Convertion for the tree navigations
        public static int ConvertIfNeeded(int nActionTypeID)
        {
            if(nActionTypeID == 20 ||
               nActionTypeID == 21 || 
               nActionTypeID == 23 ||
               nActionTypeID == 25)
            {
                nActionTypeID = 8;
            }
            else if(nActionTypeID == 22)
            {
                nActionTypeID = 9;
            }
            else if(nActionTypeID == 17 ||
                    nActionTypeID == 18 ||
                    nActionTypeID == 19)
            {
                nActionTypeID = 4;
            }
            else if(nActionTypeID == 16 ||
                    nActionTypeID == 15 ||
                    nActionTypeID == 24)
            {
                nActionTypeID = 2;
            }

            return nActionTypeID;
        }

        public static int GetNextOrderID()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_orders order = context.tbl_orders.OrderByDescending(u => u.ID).FirstOrDefault<tbl_orders>();

                    if(order == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = order.ID + 1;
                    }
                }
                catch(Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }

        public static int GetNextOrderIDForFiles()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_orders_id order = context.tbl_orders_id.OrderByDescending(u => u.ID).FirstOrDefault<tbl_orders_id>();

                    if (order == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = order.ID + 1;
                    }
                }
                catch (Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }

        public static int ConvertSlaStatusToNumber(string strSlaStatus)
        {
            int nStatusID = 0;

            if(strSlaStatus.Equals(Globals.SlaStatusLate))
            {
                nStatusID = Globals.SlaLate;
            }
            else if(strSlaStatus.Equals(Globals.SlaStatusInWork) ||
                    strSlaStatus.Equals("לביצוע מיידי"))
            {
                nStatusID = Globals.SlaInTime;
            }

            return nStatusID;
        }

        public static void CreatePopup(String strTitle, String strMessage, int nOpenScreenID)
        {
            PopupNotifier popup = new PopupNotifier();

            Globals.OpenScreenID = nOpenScreenID;
            
            popup.Click += new EventHandler(Popup_Clicked);
            popup.IsRightToLeft = true;
            popup.Image = Properties.Resources.Notification_Icon;
            popup.TitleText = strTitle;
            popup.ContentText = strMessage;

            currPopup = popup;

            if (Globals.UserGroupID == Globals.SalesUserID)
            {
                Globals.SalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
            }
            else if (Globals.UserGroupID != Globals.AdminID)
            {
                Globals.NotSalesFormInstance.pbAllNotifications.Image = Properties.Resources.All_Notification_Icon_Note;
            }

            if(Globals.lstAllNotifications == null)
            {
                Globals.lstAllNotifications = new List<string>();
            }
            Globals.lstAllNotifications.Add(strTitle + " - " + strMessage);

            popup.Popup();
        }

        public static string GetFilledDataFromOrder(tbl_orders Order)
        {
            string strToReturn = String.Empty;

            if (Order.template_id != null)
            {
                strToReturn = Order.template_id.ToString();
            }
            else if (Order.prisa_id != null)
            {
                strToReturn = Order.prisa_id.ToString();
            }
            else if(Order.client_order_id != null)
            {
                strToReturn = Order.client_order_id.ToString();
            }
            else
            {
                strToReturn = Order.project_desc;
            }

            return strToReturn;
        }

        public static void SetZebraMode(DataGridView dataGridView)
        {
            dataGridView.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
        }

        public static void SetGlobalUserData(int nUserID, String strUserName, String strName, int nUserGroupID, String strUserGroup)
        {
            Globals.UserID = nUserID;
            Globals.Name = strName;
            Globals.UserName = strUserName;
            Globals.UserGroupID = nUserGroupID;
            Globals.UserGroup = strUserGroup;
        }

        public static void SetClientList(List<tbl_clients> Clients)
        {
            Globals.AllClients = Clients;
        }

        public static Boolean TransferJobAndActionToNext(tbl_orders selectedOrder)
        {
            Boolean isSucceeded = true;

            Utilities.GetAllActionToDeptList();

            List<tbl_action_to_dept> lstActionsToDept = new List<tbl_action_to_dept>();

            int nActionTypeBeforeConvertion = 0;

            if(selectedOrder.special_department_id != null &&
               Globals.UserGroupID == Globals.KadasUserID)
            {
                nActionTypeBeforeConvertion = int.Parse(selectedOrder.special_action_type_id.Value.ToString());
            }
            else
            {
                nActionTypeBeforeConvertion = int.Parse(selectedOrder.action_type_id.ToString());
            }

            int nActionTypeID =
                Utilities.ConvertIfNeeded
                    (nActionTypeBeforeConvertion);

            tbl_action_to_dept MovementData = Globals.AllActionToDept
                                    .Where(a => a.action_ID == nActionTypeID)
                                            .Single<tbl_action_to_dept>();

            if (selectedOrder.special_department_id != null &&
                Globals.UserGroupID == Globals.KadasUserID)
            {
                selectedOrder.special_department_id = MovementData.recieved_department_ID;
                selectedOrder.special_action_type_id = MovementData.recieved_department_action_id;

                selectedOrder.special_recieved_date = System.DateTime.Now.Date;
                selectedOrder.special_recieved_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
            }
            else
            {
                selectedOrder.curr_departnent_id = MovementData.recieved_department_ID;
                selectedOrder.action_type_id = MovementData.recieved_department_action_id;

                selectedOrder.dep_recieve_date = System.DateTime.Now.Date;
                selectedOrder.dep_recieve_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));
            }

            try
            {
                using (var context = new DB_Entities())
                {
                    context.tbl_orders.Attach(selectedOrder);
                    var Entry = context.Entry(selectedOrder);

                    Entry.Property(o => o.action_type_id).IsModified = true;
                    Entry.Property(o => o.curr_departnent_id).IsModified = true;
                    Entry.Property(o => o.dep_recieve_date).IsModified = true;
                    Entry.Property(o => o.dep_recieve_hour).IsModified = true;
                    Entry.Property(o => o.special_action_type_id).IsModified = true;
                    Entry.Property(o => o.special_department_id).IsModified = true;
                    Entry.Property(o => o.special_recieved_date).IsModified = true;
                    Entry.Property(o => o.special_recieved_hour).IsModified = true;
                    // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSucceeded = false;
            }

            return isSucceeded;
        }

        public static Boolean TransferJobAndActionToNext(tbl_orders selectedOrder, Boolean isSpecial)
        {
            Boolean isSucceeded = true;

            Utilities.GetAllActionToDeptList();

            List<tbl_action_to_dept> lstActionsToDept = new List<tbl_action_to_dept>();

            int nActionTypeID =
                Utilities.ConvertIfNeeded
                    (selectedOrder.special_action_type_id.Value);

            tbl_action_to_dept MovementData = Globals.AllActionToDept
                                    .Where(a => a.action_ID == nActionTypeID)
                                            .Single<tbl_action_to_dept>();

            selectedOrder.special_department_id = MovementData.recieved_department_ID;
            selectedOrder.special_action_type_id = MovementData.recieved_department_action_id;

            selectedOrder.special_recieved_date = System.DateTime.Now.Date;
            selectedOrder.special_recieved_hour = TimeSpan.Parse(System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8));

            try
            {
                using (var context = new DB_Entities())
                {
                    context.tbl_orders.Attach(selectedOrder);
                    var Entry = context.Entry(selectedOrder);

                    Entry.Property(o => o.special_action_type_id).IsModified = true;
                    Entry.Property(o => o.special_department_id).IsModified = true;
                    Entry.Property(o => o.special_recieved_date).IsModified = true;
                    Entry.Property(o => o.special_recieved_hour).IsModified = true;
                    // context.tbl_orders.AddOrUpdate(DeclinedOrder);

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                isSucceeded = false;
            }

            return isSucceeded;
        }

        public static int GetNextNotificationID()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_notifications note = context.tbl_notifications.OrderByDescending(u => u.ID).FirstOrDefault<tbl_notifications>();

                    if (note == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = note.ID + 1;
                    }
                }
                catch (Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }

        public static void SetActionsList(List<tbl_sla_actions> Actions)
        {
            Globals.AllActions = Actions;
        }

        public static string CalculateSlaStatus(DateTime? recievedDate, TimeSpan? recievedHour, int nSlaHours)
        {
            string strSlaStatus = String.Empty;
            
            if(nSlaHours == Globals.SlaImmediate)
            {
                if(System.DateTime.Now.Hour - recievedHour.Value.Hours < 2)
                {
                    strSlaStatus = "לביצוע מיידי";
                }
                else
                {
                    strSlaStatus = Globals.SlaStatusLate;
                }
            }
            else if(nSlaHours == Globals.SlaUntil12)
            {
                if(recievedHour.Value.Hours >= 12)
                {
                    if( (int)(System.DateTime.Now.Date - recievedDate).Value.TotalDays >= 1 )
                    {
                        strSlaStatus = Globals.SlaStatusLate;
                    }
                    else
                    {
                        strSlaStatus = Globals.SlaStatusInWork;
                    }
                }
                else
                {
                    if (System.DateTime.Now.Hour >= 12)
                    {
                        strSlaStatus = Globals.SlaStatusLate;
                    }
                    else
                    {
                        strSlaStatus = Globals.SlaStatusInWork;
                    }
                }
            }
            else if(nSlaHours == Globals.SlaNone)
            {
                strSlaStatus = "ללא SLA";
            }
            else
            {
                int nElapsedDaysHours = (int)(System.DateTime.Now.Date - recievedDate).Value.TotalHours;
                int nElapsedHours = System.DateTime.Now.Hour - recievedHour.Value.Hours;

                if (nSlaHours > (nElapsedDaysHours + nElapsedHours))
                {
                    strSlaStatus = Globals.SlaStatusInWork;
                }
                else
                {
                    strSlaStatus = Globals.SlaStatusLate;
                }
            }

            return strSlaStatus;
        }

        public static List<tbl_notifications> GetOrderNotifications(int nOrderID)
        {
            List<tbl_notifications> lstNotification = new List<tbl_notifications>();

            using (var context = new DB_Entities())
            {
                try
                {
                    lstNotification = context.tbl_notifications.
                          Where(a => a.order_id == nOrderID).ToList<tbl_notifications>();
                }
                catch (Exception ex) { };
            }

            return lstNotification;
        }

        public static List<tbl_orders_id> GetMyOrdersIDData(int nOrderID)
        {
            List<tbl_orders_id> lstOrdersID = new List<tbl_orders_id>();

            using (var context = new DB_Entities())
            {
                try
                {
                    lstOrdersID = context.tbl_orders_id.
                          Where(a => a.order_id == nOrderID).ToList<tbl_orders_id>();
                }
                catch(Exception ex) { };
            }

            return lstOrdersID;
        }

        public static void SetNewDeclinedJobs(List<tbl_orders> myDeclinedJobs)
        {
            Globals.MyDeclinedOrders = myDeclinedJobs;
        }

        // Returns the job count.
        // Exceptions : returns -1 if error has occured.
        public static int GetMyJobCount()
        {
            List<tbl_orders> MyJobs = new List<tbl_orders>();
            int nMyJobsCount = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    if(Globals.UserGroupID == Globals.SalesUserID)
                    {
                        MyJobs =
                       context.tbl_orders
                           .Where(o => (o.curr_departnent_id == Globals.UserGroupID ||
                                         o.special_department_id == Globals.UserGroupID) &&
                                         o.current_status_id == Globals.StatusInWork &&
                                         o.sales_agent_name == Globals.Name
                                              ).ToList<tbl_orders>();
                    }
                    else
                    {
                        MyJobs =
                       context.tbl_orders
                           .Where(o => (o.curr_departnent_id == Globals.UserGroupID ||
                                         o.special_department_id == Globals.UserGroupID) &&
                                         o.current_status_id == Globals.StatusInWork
                                              ).ToList<tbl_orders>();
                    }


                    Utilities.SetNewJobs(MyJobs);
                    
                    nMyJobsCount = MyJobs.Count;
                }
                catch (Exception ex)
                {
                    nMyJobsCount = -1;
                }
            }

            return nMyJobsCount;
        }

        public static void SetNewJobs(List<tbl_orders> myJobs)
        {
            Globals.MyJobs = myJobs;
        }

        // Returns false if save to database failed else returns true.
        public static Boolean UpdateOrderRecord(tbl_orders OrderToUpdate)
        {
            Boolean isOperationSucceeded = true;

            try
            {
                using (var context = new DB_Entities())
                {

                }
            }
            catch (Exception ex)
            {
                isOperationSucceeded = false;
            }

            return isOperationSucceeded;
        }

        // Returns -1 when error has occured
        public static int GetNewDeclinedOrdersAndCount()
        {
            int nDeclinedOrderCount = 0;
            List<tbl_orders> MyDeclinedJobs = new List<tbl_orders>();

            using (var context = new DB_Entities())
            {
                try
                {
                    DateTime dtTwoWeeksBeforeToday = DateTime.Now.AddDays(-14);

                    MyDeclinedJobs =
                          context.tbl_orders
                             .Where(o => o.current_status_id == Globals.StatusInWork &&
                                         o.action_type_id == Globals.ActionTypeRecieveClientOrder &&
                                         o.dep_recieve_date <= dtTwoWeeksBeforeToday
                                             ).ToList<tbl_orders>();

                    nDeclinedOrderCount = MyDeclinedJobs.Count;

                    Utilities.SetNewDeclinedJobs(MyDeclinedJobs);
                }
                catch (Exception ex)
                {
                    nDeclinedOrderCount = -1; 
                }
            }

            return nDeclinedOrderCount;
        }

        public static void SetMainForm(SalesMainForm instance)
        {
            Globals.SalesFormInstance = instance;
        }

        public static void SetMainForm(TopUserForm instance)
        {
            Globals.TopUserFormInstance = instance;
        }

        public static void SetMainForm(NotSalesMainForm instance)
        {
            Globals.NotSalesFormInstance = instance;
        }

        public static int GetActionTypeIDFormWork(int nUserID, string strWork)
        {
            int nActionType = -1;

            if (nUserID == Globals.KadasUserID)
            {
                if (strWork.Equals(Globals.KadasApprovePDF))
                {
                    nActionType = Globals.ActionTypeKadasApprovePDF;
                }
                else if (strWork.Equals(Globals.KadasGraphicUpdate))
                {
                    nActionType = Globals.ActionTypeKadasGraphicUpdate;
                }
                else if (strWork.Equals(Globals.KadasNewPDF))
                {
                    nActionType = Globals.ActionTypeKadasNewPDF;
                }
                else if (strWork.Equals(Globals.KadasSunCopyNew))
                {
                    nActionType = Globals.ActionTypeKadasSunCopyNew;
                }
                else if (strWork.Equals(Globals.KadasElse))
                {
                    nActionType = Globals.ActionTypeKadasElse;
                }
            }
            else if(nUserID == Globals.StudioUserID)
            {
                if (strWork.Equals(Globals.StudioCutModel))
                {
                    nActionType = Globals.ActionTypeStudioCutModel;
                }
                else if (strWork.Equals(Globals.StudioOnlyModel))
                {
                    nActionType = Globals.ActionTypeStudioOnlyModel;
                }
                else if (strWork.Equals(Globals.StudioOnlyPrisa))
                {
                    nActionType = Globals.ActionTypeStudioOnlyPrisa;
                }
                else if (strWork.Equals(Globals.StudioPrisaAndModel))
                {
                    nActionType = Globals.ActionTypeStudioPrisaAndModel;
                }
                else if (strWork.Equals(Globals.StudioPrisaForOffer))
                {
                    nActionType = Globals.ActionTypeStudioPrisaForOffer;
                }
                else if (strWork.Equals(Globals.StudioElse))
                {
                    nActionType = Globals.ActionTypeStudioElse;
                }
            }

            return nActionType;
        }

        public static void GetAllMyEmployees()
        {
            List<tbl_employees> lstEmployees;

            if (Globals.AllMyEmployees == null)
            {
                using (var context = new DB_Entities())
                {
                    try
                    {
                        if(Globals.UserGroupID == Globals.AdminID)
                        {
                            lstEmployees = context.tbl_employees.ToList<tbl_employees>();
                        }
                        else
                        {
                            lstEmployees = context.tbl_employees
                                .Where(e => e.Department_id == Globals.UserGroupID)
                                            .ToList<tbl_employees>();
                        }
                        
                        Utilities.SetMyEmployeesList(lstEmployees);
                    }
                    catch (Exception ex) { }
                }
            }
        }

        public static int GetNextSlaDataID()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_sla_data slaData = context.tbl_sla_data.OrderByDescending(u => u.ID).FirstOrDefault<tbl_sla_data>();

                    if (slaData == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = slaData.ID + 1;
                    }
                }
                catch (Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }

        private static void SetMyEmployeesList(List<tbl_employees> lstEmployees)
        {
            Globals.AllMyEmployees = lstEmployees;
        }

        public static List<tbl_offers> GetMyOffersData(int nOrderID)
        {
            List<tbl_offers> lstOffers = new List<tbl_offers>();

            using (var context = new DB_Entities())
            {
                try
                {
                    lstOffers = context.tbl_offers.
                        Where(a => a.order_id == nOrderID).ToList<tbl_offers>();
                }
                catch (Exception ex) { };
            }

            return lstOffers;
        }

        public static int GetNextEmployeeID()
        {
            int nMaxID = 0;

            using (var context = new DB_Entities())
            {
                try
                {
                    tbl_employees employee = context.tbl_employees
                        .OrderByDescending(u => u.ID).FirstOrDefault<tbl_employees>();

                    if (employee == null)
                    {
                        nMaxID = 1;
                    }
                    else
                    {
                        nMaxID = employee.ID + 1;
                    }
                }
                catch (Exception ex)
                {
                    nMaxID = -1;
                }
            }

            return nMaxID;
        }
    }
}
