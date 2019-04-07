using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
   
    public class Clientes
    {
       
        public int IdCliente { get; set; }

      
        public String NombreCliente { get; set; }
        
     
        public String ApellidoCliente { get; set; }

       
        public String EmailCliente { get; set; }

       
        public String Direccion { get; set; }

       
        public String Ciudad { get; set; }

    
        public string Dni { get; set; }

      
        public int Telefono { get; set; }

    }
}
