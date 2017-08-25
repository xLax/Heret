using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeretPreWorkControl
{
    public class Globals
    {
        // Keyboard Values
        public const int KeyValueEnter = 13;
        public const int KeyValueF6 = 117;

        // User group ID
        public const int ResponsibleID = 0;
        public const int AdminID = 1;
        public const int SalesUserID = 2;
        public const int StudioUserID = 3;
        public const int KadasUserID = 4;
        public const int OrdersUserID = 5;

        public const string SalesUserType = "סוכן מכירות";
        public const string StudioUserType = "סטודיו";
        public const string KadasUserType = "קדם דפוס";
        public const string OrdersUserType = "הזמנות";

        public const int ToMyJobs = 1;
        public const int ToDeclinedOrders = 2;
        public const int ToTamatz = 3;
        public const int ToSpecialApprove = 4;
        public static int OpenScreenID;

        // Data for drop downs and shit
        public const string PrisaNumber = "מספר פריסה";
        public const string TemplateNumber = "מספר תבנית";
        public const string ProjectDesc = "תיאור פרויקט";
        public const string ModelNumber = "מספר דגם";

        public const string PriceReason = "מחיר גבוה";
        public const string TimeReason = "זמן אספקה";
        public const string DelayReason = "דחיית פרויקט";
        public const string OtherReason = "אחר";

        public const string KadasApprovePDF = "PDF לאישור";
        public const string KadasNewPDF = "עבודה חדשה ( PDF )";
        public const string KadasSunCopyNew = "עבודה חדשה ( העתק שמש )";
        public const string KadasGraphicUpdate = "עדכון גרפי";

        public const string StudioOnlyPrisa = "פריסה בלבד";
        public const string StudioPrisaForOffer = "הערכת פריסה להצעת מחיר";
        public const string StudioOnlyModel = "דגם בלבד";
        public const string StudioPrisaAndModel = "פריסה ודגם";
        public const string StudioCutModel = "חיתוך דגמים";

        public const string StatusActiveClient = "פעיל";
        public const string StatusBlockedClient = "אזהרת חסימה";
        public const string StatusLimitedClient = "מוגבל";

        public const string StatusJobClosed = "סגור";
        public const string StatusJobInWork = "בתהליך";
        public const string StatusJobDenied = "סירוב לקוח";
        public const string StatusJobAll = "הכל";

        public const string NewOrder = "הזמנה חדשה";
        public const string RecieveClientOrder = "קבלת הזמנת לקוח";
        public const string InsertOrderID = "הכנסת מספר הזמנה";
        public const string SetAndSendOffer = "הכנסת הצעת מחיר ושליחה ללקוח";

        public const string StudioWaitClient = "המתנת סטודיו לאישור לקוח";
        public const string KadasWaitClient = "המתנת קד\"ס לאישור הלקוח";

        public const string SlaStatusLate = "מאחר";
        public const string SlaStatusInWork = "בתהליך";

        // public const string UnnecessaryWork = "לא נדרש";

        // על העבודה להתבצע עד השעה 12 של היום או מחר (תלוי מתי התקבלה) חשוב
        public const int SlaUntil12 = 0;
        // ערך שמסמן ביצוע מיידי
        public const int SlaImmediate = -1;
        // ערך שמסמן שאין SLA
        public const int SlaNone = -2;

        public const int StatusInWork = 1;
        public const int StatusClosed = 2;
        public const int StatusDenied = 3;

        // Amount of milliseconds in one day ( for the decline timer )
        public const long MillInDay = 86400000;

        // Action Type constants
        public const int ActionTypeNewOrder = 0;
        public const int ActionTypeRecieveClientOrder = 5;
        public const int ActionTypeInsertOrderID = 10;
        public const int ActionTypeSetAndSendOffer = 3;

        public const int ActionTypeKadasApprovePDF = 20;
        public const int ActionTypeKadasNewPDF = 21;
        public const int ActionTypeKadasSunCopyNew = 22;
        public const int ActionTypeKadasGraphicUpdate = 23;

        public const int ActionTypeStudioOnlyPrisa = 15;
        public const int ActionTypeStudioPrisaForOffer = 16;
        public const int ActionTypeStudioOnlyModel = 17;
        public const int ActionTypeStudioPrisaAndModel = 18;
        public const int ActionTypeStudioCutModel = 19;

        public const int ActionTypeStudioWaitClient = 11;
        public const int ActionTypeKadasWaitClient = 12;

        public const string AcitonMoveCheckListToOrders = "העברת צ'ק ליסט מכירות + קד\"ס להזמנות";

        public static int UserID;
        public static String UserName;
        public static String Name;
        public static int UserGroupID;
        public static String UserGroup;

        public static List<tbl_employees> AllEmployeesResp;
        public static List<tbl_clients> AllClients;
        public static List<tbl_sla_actions> AllActions;
        public static List<tbl_action_to_dept> AllActionToDept;
        public static List<tbl_user_groups> AllUserGroups;
        public static List<tbl_employees> AllMyEmployees;

        public static List<tbl_orders> MyDeclinedOrders;
        public static List<tbl_orders> MyJobs;
        public static List<tbl_orders> SpecialApprovedJobs;
        public static List<tbl_orders> AllJobs;

        public static TopUserForm TopUserFormInstance;
        public static SalesMainForm SalesFormInstance;
        public static NotSalesMainForm NotSalesFormInstance;

        public static List<tbl_sla_data> AllSlaData;

        public static int AlertNow = 1;
        public static int Alerted = 2;

        public static int SlaInTime = 1;
        public static int SlaLate = 2;
    }
}
