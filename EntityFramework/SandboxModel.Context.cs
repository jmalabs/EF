﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SANDBOX2Entities : DbContext
    {
        public SANDBOX2Entities()
            : base("name=SANDBOX2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUTHOR> AUTHORS { get; set; }
        public virtual DbSet<COURSE> COURSES { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    
        public virtual ObjectResult<GetCourses_Result> GetCourses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCourses_Result>("GetCourses");
        }
    }
}
