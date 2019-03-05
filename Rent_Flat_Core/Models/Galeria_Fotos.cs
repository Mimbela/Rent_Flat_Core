using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Galeria_Fotos")]
    public class Galeria_Fotos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Cod_imagen")]
        public int Cod_imagen { get; set; }


        [Column("Cod_casa")]
        public int Cod_casa { get; set; }


        [Column("Foto")]
        public byte[] Foto { get; set; }


        [Column("Orden")]
        public int Orden { get; set; }
    }
}
