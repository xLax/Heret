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
    
    public partial class tbl_orders_id
    {
        public int ID { get; set; }
        public int order_id { get; set; }
        public string heret_order_id { get; set; }
    
        public virtual tbl_orders tbl_orders { get; set; }
    }
}
