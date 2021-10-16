﻿using Microsoft.EntityFrameworkCore;
using ReacerRegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReacerRegistroDetalle.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = DATA\RolesDetalle.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoID = 1,
                Nombre = "Carlos Alfredo",
                DescripcionPermiso = "Administrador"
            });

            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoID = 2,
                Nombre = "Pedro Lopez",
                DescripcionPermiso = "Supervisor"
            });
        }
    }
}
