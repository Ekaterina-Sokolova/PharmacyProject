﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PharmacyProjectEntities1 : DbContext
    {
        public PharmacyProjectEntities1()
            : base("name=PharmacyProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autorization> Autorization { get; set; }
        public virtual DbSet<Farm> Farm { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Pokup> Pokup { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
    }
}
