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
    
    public partial class tbl_orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_orders()
        {
            this.tbl_sla_data = new HashSet<tbl_sla_data>();
            this.tbl_offers = new HashSet<tbl_offers>();
        }
    
        public int ID { get; set; }
        public Nullable<int> sales_agent_id { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<System.DateTime> contact_date { get; set; }
        public Nullable<int> files_number { get; set; }
        public Nullable<int> template_id { get; set; }
        public Nullable<int> prisa_id { get; set; }
        public string project_desc { get; set; }
        public Nullable<int> amount { get; set; }
        public string studio_work { get; set; }
        public Nullable<System.DateTime> reject_date { get; set; }
        public string reject_reason { get; set; }
        public string comments { get; set; }
        public Nullable<int> curr_departnent_id { get; set; }
        public Nullable<int> studio_agent_id { get; set; }
        public Nullable<int> kadas_agent_id { get; set; }
        public Nullable<int> orders_agent_id { get; set; }
        public Nullable<int> action_type_id { get; set; }
        public Nullable<int> client_response_id { get; set; }
        public Nullable<int> special_approve { get; set; }
        public Nullable<int> special_department_id { get; set; }
        public string order_number { get; set; }
        public int current_status_id { get; set; }
        public Nullable<System.DateTime> dep_recieve_date { get; set; }
        public Nullable<System.TimeSpan> dep_recieve_hour { get; set; }
        public Nullable<int> client_order_id { get; set; }
        public string kadas_work { get; set; }
    
        public virtual tbl_client_response tbl_client_response { get; set; }
        public virtual tbl_clients tbl_clients { get; set; }
        public virtual tbl_user_groups tbl_user_groups { get; set; }
        public virtual tbl_users tbl_users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_sla_data> tbl_sla_data { get; set; }
        public virtual tbl_users tbl_users1 { get; set; }
        public virtual tbl_users tbl_users2 { get; set; }
        public virtual tbl_user_groups tbl_user_groups1 { get; set; }
        public virtual tbl_sla_actions tbl_sla_actions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_offers> tbl_offers { get; set; }
    }
}
