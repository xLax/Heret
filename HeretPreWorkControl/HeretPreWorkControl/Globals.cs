using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeretPreWorkControl
{
    public class Globals
    {
        public const int AdminID = 1;
        public const int SalesUserID = 2;
        public const int StudioUserID = 3;
        public const int KadasUserID = 4;
        public const int OrdersUserID = 5;

        public const int ToMyJobs = 1;
        public const int ToDeclinedOrders = 2;
        public static int OpenScreenID;

        // Data for drop downs and shit
        public const string PrisaNumber = "מספר פריסה";
        public const string TemplateNumber = "מספר תבנית";
        public const string ProjectDesc = "תיאור פרויקט";

        public const string PriceReason = "מחיר גבוה";
        public const string TimeReason = "זמן אספקה";
        public const string DelayReason = "דחיית פרויקט";
        public const string OtherReason = "אחר";

        // על העבודה להתבצע עד השעה 12 של היום או מחר (תלוי מתי התקבלה) חשוב
        public const int SlaUntil12 = 0;
        // ערך שמסמן ביצוע מיידי
        public const int SlaImmediate = -1;

        public const int StatusInWork = 1;
        public const int StatusClosed = 2;
        public const int StatusDenied = 3;

        // Amount of milliseconds in one day ( for the decline timer )
        public const long MillInDay = 86400000;

        // Meaning that the next step is to recieve the order from the client
        public const int ActionTypeIDRecieveClientOrder = 5;

        public static int UserID;
        public static String UserName;
        public static String Name;
        public static int UserGroupID;
        public static String UserGroup;

        public static List<tbl_clients> AllClients;
        public static List<tbl_sla_actions> AllActions;

        public static List<tbl_orders> MyDeclinedOrders;
        public static List<tbl_orders> MyJobs;

        public static TopUserForm TopUserFormInstance;
        public static SalesMainForm SalesFormInstance;
        public static NotSalesMainForm NotSalesFormInstance;
    }
}
