using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("Viviendas")]
    public class Viviendas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Cod_casa")]
        public int Cod_casa { get; set; }

        [Column("Cod_Provincia")]
        public int Cod_Provincia { get; set; }

        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Column("Ubicacion")]
        public String Ubicacion { get; set; }

        [Column("Codigo_Posta")]
        public int Codigo_Posta { get; set; }

        [Column("Ciudad")]
        public string Ciudad { get; set; }

        [Column("Num_habitaciones")]
        public int Num_habitaciones { get; set; }

        [Column("Num_banios")]
        public int Num_banios { get; set; }

        [Column("Tamanio_vivienda")]
        public int Tamanio_vivienda { get; set; }

        [Column("Descripcion")]
        public String Descripcion { get; set; }

        [Column("Garaje")]
        public byte[] Garaje { get; set; }

        [Column("Cod_TipoVivienda")]
        public int Cod_TipoVivienda { get; set; }
    }
}
