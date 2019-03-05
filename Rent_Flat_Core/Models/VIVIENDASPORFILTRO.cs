using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    [Table("VIVIENDASPORFILTRO")]
    public class VIVIENDASPORFILTRO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Cod_casa")]
        public int Cod_casa { get; set; }

        [Column("Ciudad")]
        public String Ciudad { get; set; }

        [Column("Cod_Provincia")]
        public int Cod_Provincia { get; set; }

        [Column("Cod_TipoVivienda")]
        public int Cod_TipoVivienda { get; set; }

        [Column("Codigo_Posta")]
        public int Codigo_Posta { get; set; }

        [Column("Descripcion_vivienda")]
        public string Descripcion_vivienda { get; set; }

        [Column("Garaje")]
        public bool Garaje { get; set; }

        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Column("Num_banios")]
        public int Num_banios { get; set; }

        [Column("Num_habitaciones")]
        public int Num_habitaciones { get; set; }

        [Column("Tamanio_vivienda")]
        public int Tamanio_vivienda { get; set; }

        [Column("Ubicacion")]
        public String Ubicacion { get; set; }

        [Column("Cod_tipo_vivienda")]
        public int Cod_tipo_vivienda { get; set; }

        [Column("Descripcion_tipo")]
        public string Descripcion_tipo { get; set; }

        [Column("Foto")]
        public byte[] Foto { get; set; }

        [Column("NombreProvincia")]
        public string NombreProvincia { get; set; }

        [Column("ApellidoCliente")]
        public string ApellidoCliente { get; set; }

        [Column("CIUDAD_CLIENTE")]
        public string CIUDAD_CLIENTE { get; set; }

        [Column("Direccion")]
        public string Direccion { get; set; }

        [Column("Dni")]
        public string Dni { get; set; }

        [Column("EmailCliente")]
        public string EmailCliente { get; set; }

        [Column("NombreCliente")]
        public string NombreCliente { get; set; }

        [Column("Telefono")]
        public int Telefono { get; set; }

        [Column("PrecioActivo")]
        public decimal PrecioActivo { get; set; }

        [Column("PrecioAnterior")]
        public decimal PrecioAnterior { get; set; }

        [Column("ViviendaImagen")]
        public byte[] ViviendaImagen { get; set; }


    }
}

    
