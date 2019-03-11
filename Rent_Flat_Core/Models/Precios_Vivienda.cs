using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Precios_Vivienda")]
    public class Precios_Vivienda
    {
        [Key]
        [Column("Cod_Precio")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Precio { get; set; }

        [Column("Cod_casa")]
        public int Cod_casa { get; set; }

        [Column("Precio")]
        public decimal Precio { get; set; }

        [Column("Fecha_alta")]
        public DateTime Fecha_alta { get; set; }

        [Column("Fecha_baja")]
        public DateTime Fecha_baja { get; set; }

        [Column("Precio_activo")]
        public bool Precio_activo { get; set; }
    }
}
