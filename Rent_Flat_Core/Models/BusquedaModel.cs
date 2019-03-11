using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    public class BusquedaModel
    {

        public List<SelectListItem> TiposVivienda { get; set; }

        public List<SelectListItem> ListaCostas { get; set; }
        public List<SelectListItem> NumeroBanios { get; set; }
        public List<SelectListItem> NumeroHabitaciones { get; set; }

        public int TiposViviendaSelectedValue { get; set; }
        public int CostasSelectedValue { get; set; }
        public int NumeroBaniosSelectedValue { get; set; }
        public int NumeroHabitacionesSelectedValue { get; set; }
        public int Cod_Casa { get; set; }
        public int Cod_Cliente { get; set; }


    }
}
