﻿using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext() : base("Consultorio")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<MMedicos> MMedicos { get; set; }
        public DbSet<MPacientes> MPacientes { get; set; }
        public DbSet<MCitas> MCitas { get; set; }

    }

   
}
