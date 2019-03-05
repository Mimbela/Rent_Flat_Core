using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    public class Galeria_FotosViewModel
    {
        public int Cod_imagen { get; set; }
        public int Cod_casa { get; set; }
        public byte[] Foto { get; set; }
        public int Orden { get; set; }
       
        //no existe en core
        // public HttpPostedFileBase ImgData { get; set; }
    }
}
