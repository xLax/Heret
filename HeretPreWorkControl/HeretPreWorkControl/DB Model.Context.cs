﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_Entities : DbContext
    {
        public DB_Entities()
            : base("name=DB_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_action_to_dept> tbl_action_to_dept { get; set; }
        public virtual DbSet<tbl_clients> tbl_clients { get; set; }
        public virtual DbSet<tbl_employees> tbl_employees { get; set; }
        public virtual DbSet<tbl_offers> tbl_offers { get; set; }
        public virtual DbSet<tbl_orders> tbl_orders { get; set; }
        public virtual DbSet<tbl_sla_actions> tbl_sla_actions { get; set; }
        public virtual DbSet<tbl_sla_data> tbl_sla_data { get; set; }
        public virtual DbSet<tbl_user_groups> tbl_user_groups { get; set; }
        public virtual DbSet<tbl_users> tbl_users { get; set; }
        public virtual DbSet<tbl_notifications> tbl_notifications { get; set; }
        public virtual DbSet<tbl_orders_id> tbl_orders_id { get; set; }
    }
}
