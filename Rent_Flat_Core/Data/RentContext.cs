using Microsoft.EntityFrameworkCore;
using Rent_Flat_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Data
{
    public class RentContext:DbContext,IRentContext
    {
        public RentContext(DbContextOptions options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Costas> Costas { get; set; }
        public DbSet<Galeria_Fotos> Galeria_Fotos { get; set; }
        public DbSet<Precios_Vivienda> Precios_Vivienda { get; set; }
        public DbSet<Tipos_Vivienda> Tipos_Vivienda { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Viviendas> Viviendas { get; set; }
    }
}
