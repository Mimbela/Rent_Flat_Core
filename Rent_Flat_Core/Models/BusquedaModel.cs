﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_Flat_Core.Models
{
    public class BusquedaModel
    {
        public BusquedaModel()
        {
            TiposVivienda = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "0", Text = "Tipo Vivienda"}
            };
            ListaCostas = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "0", Text = "Costa"}
            };
            NumeroBanios = new List<SelectListItem>()
            {
                 new SelectListItem() { Value = "0", Text = "Baños" },
                new SelectListItem() { Value = "1", Text = "1 Baño" },
                new SelectListItem() { Value = "2", Text = "2 Baños" },
                new SelectListItem() { Value = "3", Text = "3 Baños" }
            };
          NumeroHabitaciones = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Habitaciones"},
                new SelectListItem() { Value = "1", Text = "1 Habitación"},
                new SelectListItem() { Value = "2", Text = "2 Habitaciones"},
                new SelectListItem() { Value = "3", Text = "3 Habitaciones"},
                new SelectListItem() { Value = "4", Text = "4 Habitaciones"},
                new SelectListItem() { Value = "5", Text = "5 Habitaciones"},
                new SelectListItem() { Value = "6", Text = "6 Habitaciones"},
            };
        }
        #region MOTOR DE BÚSQUEDA
        //selectListItem porque es del dropdownlist(value,text)
        public List<SelectListItem> TiposVivienda { get; set; }

        public List<SelectListItem> ListaCostas { get; set; }
        public List<SelectListItem> NumeroBanios { get; set; }
        public List<SelectListItem> NumeroHabitaciones { get; set; }
        #endregion


        public int TiposViviendaSelectedValue { get; set; }
        public int CostasSelectedValue { get; set; }
        public int NumeroBaniosSelectedValue { get; set; }
        public int NumeroHabitacionesSelectedValue { get; set; }
        public int Cod_Casa { get; set; }
        public int Cod_Cliente { get; set; }


    }
}
