//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeretPreWorkControl
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_sla_data
    {
        public int ID { get; set; }
        public int sla_id { get; set; }
        public int order_id { get; set; }
        public int status_id { get; set; }
        public string employee_name { get; set; }
        public System.DateTime begin_date { get; set; }
        public System.DateTime end_date { get; set; }
        public int user_id { get; set; }
    
        public virtual tbl_orders tbl_orders { get; set; }
        public virtual tbl_sla_actions tbl_sla_actions { get; set; }
        public virtual tbl_users tbl_users { get; set; }
        public virtual tbl_users tbl_users1 { get; set; }
    }
}
