//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STAAS.Configuration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class STAAS_dbEntities2 : DbContext
    {
        public STAAS_dbEntities2()
            : base("name=STAAS_dbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<daily_Management_Configs> daily_Management_Configs { get; set; }
        public virtual DbSet<holiday_Management_Config> holiday_Management_Config { get; set; }
    }
}
