﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GranDeShopEntities : DbContext
    {
        public GranDeShopEntities()
            : base("name=GranDeShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DetallePedidos> DetallePedidos { get; set; }
        public virtual DbSet<EncabezadoPedidos> EncabezadoPedidos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}