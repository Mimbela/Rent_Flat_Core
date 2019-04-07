using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
   
    public class Precios_Vivienda
    {
       
        public int Cod_Precio { get; set; }

        
        public int Cod_casa { get; set; }

       
        public decimal Precio { get; set; }

      
        public DateTime Fecha_alta { get; set; }

      
        public DateTime Fecha_baja { get; set; }

       
        public bool Precio_activo { get; set; }
    }
}
