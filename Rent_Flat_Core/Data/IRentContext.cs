using Microsoft.EntityFrameworkCore;
using Rent_Flat_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Data
{
    public interface IRentContext
    {
        DbSet<Clientes> Clientes { get; set; }
        DbSet<Costas> Costas { get; set; }
        DbSet<Galeria_Fotos> Galeria_Fotos { get; set; }
        DbSet<Precios_Vivienda> Precios_Vivienda { get; set; }
        DbSet<Tipos_Vivienda> Tipos_Vivienda { get; set; }
        DbSet<Usuarios> Usuarios { get; set; }
        DbSet<Viviendas> Viviendas { get; set; }

        int SaveChanges();

        //todo lo que vaya a utilizar lo necesito en la interface
    }
           
}
