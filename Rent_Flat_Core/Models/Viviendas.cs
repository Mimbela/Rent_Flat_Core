using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
   
    public class Viviendas
    {
      
        public int Cod_casa { get; set; }

    
        public int Cod_Provincia { get; set; }

     
        public int IdCliente { get; set; }

      
        public String Ubicacion { get; set; }

      
        public string Codigo_Posta { get; set; }

      
        public string Ciudad { get; set; }

      
        public int Num_habitaciones { get; set; }

      
        public int Num_banios { get; set; }

       
        public int Tamanio_vivienda { get; set; }

      
        public String Descripcion { get; set; }

     
        public bool Garaje { get; set; }

     
        public int Cod_TipoVivienda { get; set; }
    }
}
