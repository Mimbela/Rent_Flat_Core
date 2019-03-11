using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
   
    public class Tipos_Vivienda
    {
       
        public int Cod_tipo_vivienda { get; set; }

      
        public String Descripcion { get; set; }
    }
}
