﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscuelaMaster.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EscuelaMasterEntities : DbContext
    {
        public EscuelaMasterEntities()
            : base("name=EscuelaMasterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblHobbiesUsuario> TblHobbiesUsuario { get; set; }
        public virtual DbSet<TblUsuario> TblUsuario { get; set; }
        
    }
}