using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        [Column("IdCliente")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCliente { get; set; }

        [Column("NombreCliente")]
        public String NombreCliente { get; set; }
        //--
        [Column("ApellidoCliente")]
        public String ApellidoCliente { get; set; }

        [Column("EmailCliente")]
        public String EmailCliente { get; set; }

        [Column("Direccion")]
        public String Direccion { get; set; }

        [Column("Ciudad")]
        public String Ciudad { get; set; }

        [Column("Dni")]
        public int Dni { get; set; }

        [Column("Telefono")]
        public int Telefono { get; set; }

    }
}
