﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PC_for_you
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PI2233_DBEntities : DbContext
    {
        public PI2233_DBEntities()
            : base("name=PI2233_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<komponenta> komponenta { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<maticna> maticna { get; set; }
        public virtual DbSet<narucuje> narucuje { get; set; }
        public virtual DbSet<narudzba> narudzba { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
    }
}
