using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Costas")]
    public class Costas
    {
        [Key]
        [Column("Cod_Provincia")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Provincia { get; set; }

        [Column("NombreProvincia")]
        public String NombreProvincia { get; set; }

        [Column("Foto")]
        public byte[] Foto { get; set; }

    }
}
