﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOD_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyEntity : DbContext
    {
        public MyEntity()
            : base("name=MyEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PaymentDtl> PaymentDtls { get; set; }
        public virtual DbSet<SkillDtl> SkillDtls { get; set; }
        public virtual DbSet<UserDtl> UserDtls { get; set; }
        public virtual DbSet<TrainingDtl> TrainingDtls { get; set; }
    }
}
