using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    
    public class Costas
    {
        
      
        public int Cod_Provincia { get; set; }

        
        public String NombreProvincia { get; set; }

        
        public byte[] Foto { get; set; }

    }
}
