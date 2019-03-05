using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Cod_usuario")]
        public int Cod_usuario { get; set; }

        [Column("Login")]
        public String Login { get; set; }

        [Column("Password")]
        public String Password { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Apellido")]
        public string Apellido { get; set; }

        [Column("DIR")]
        public int DIR { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Telefono")]
        public int Telefono { get; set; }

        [Column("Mostrar_info_contacto")]
        public byte[] Mostrar_info_contacto { get; set; }

        [Column("Perfil")]
        public String Perfil { get; set; }
    }
}
