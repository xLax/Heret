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
    
    public partial class tbl_sla_actions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_sla_actions()
        {
            this.tbl_action_to_dept = new HashSet<tbl_action_to_dept>();
            this.tbl_action_to_dept1 = new HashSet<tbl_action_to_dept>();
            this.tbl_orders = new HashSet<tbl_orders>();
        }
    
        public int ID { get; set; }
        public string name { get; set; }
        public int sla_hours { get; set; }
        public string desc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_action_to_dept> tbl_action_to_dept { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_action_to_dept> tbl_action_to_dept1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_orders> tbl_orders { get; set; }
    }
}
