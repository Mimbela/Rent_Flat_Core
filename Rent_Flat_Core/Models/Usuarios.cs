using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    
    public class Usuarios
    {
        
        public int Cod_usuario { get; set; }

       
        public String Login { get; set; }

      
        public String Password { get; set; }

       
        public String Nombre { get; set; }

        
        public string Apellido { get; set; }

       
        public int DIR { get; set; }

       
        public string Email { get; set; }

      
        public string Telefono { get; set; }

       
        public bool Mostrar_info_contacto { get; set; }

        
        public String Perfil { get; set; }
    }
}
