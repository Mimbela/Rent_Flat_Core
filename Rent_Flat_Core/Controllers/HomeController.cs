using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core.Controllers
{
    public class HomeController : Controller
    {
        RepositoryApiRent repo;
        public HomeController(RepositoryApiRent repo)
        {
            this.repo = repo;
        }
        //------------------

        public async Task<IActionResult> Index()
        {

            var tiposVivienda = await this.repo.GetTiposViviendasAsync();
            var costas = await this.repo.GetCostasAsync();
            BusquedaModel busquedaModel = new BusquedaModel();
            busquedaModel.TiposVivienda = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "0", Text = "Tipo Vivienda"}
            };
            busquedaModel.ListaCostas = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "0", Text = "Costa"}
            };
            busquedaModel.NumeroBanios = new List<SelectListItem>()
            {
                 new SelectListItem() { Value = "0", Text = "Baños" },
                new SelectListItem() { Value = "1", Text = "1 Baño" },
                new SelectListItem() { Value = "2", Text = "2 Baños" },
                new SelectListItem() { Value = "3", Text = "3 Baños" }
            };
            busquedaModel.NumeroHabitaciones = new List<SelectListItem>()
            {
                new SelectListItem() { Value = "0", Text = "Habitaciones"},
                new SelectListItem() { Value = "1", Text = "1 Habitación"},
                new SelectListItem() { Value = "2", Text = "2 Habitaciones"},
                new SelectListItem() { Value = "3", Text = "3 Habitaciones"},
                new SelectListItem() { Value = "4", Text = "4 Habitaciones"},
                new SelectListItem() { Value = "5", Text = "5 Habitaciones"},
                new SelectListItem() { Value = "6", Text = "6 Habitaciones"},
            };

            

            busquedaModel.TiposVivienda.AddRange(tiposVivienda.Select(x => new SelectListItem() { Value = x.Cod_tipo_vivienda.ToString(), Text = x.Descripcion }));
            busquedaModel.ListaCostas.AddRange(costas.Select(x => new SelectListItem() { Value = x.Cod_Provincia.ToString(), Text = x.NombreProvincia }));

            //ViewBag.Resumen2 = this.repo.GetViviendas();

            return View(busquedaModel);
        }
        [HttpPost]
        public async Task<IActionResult> ListaPisosPorFiltro(BusquedaModel busqueda)
        {
            if (busqueda is null) busqueda = new BusquedaModel();
            busqueda.Cod_Casa = 0;
            busqueda.Cod_Cliente = 0;
            var otro = await this.repo.GetViviendasByFilterAsync(busqueda);
            return View(otro);

            //public IActionResult Property(int cod_casa)//para sacar una casa para la descripción
            //{
            //    int tipoVivienda = 0;
            //    int costa = 0;
            //    int num_banios = 0;
            //    int num_habitaciones = 0;
            //    int IdCliente = 0;
            //    var propiedad = this.repo.GetViviendasByFilter(tipoVivienda, costa, num_banios, num_habitaciones, cod_casa, IdCliente).FirstOrDefault();
            //    return View(propiedad);
            //}
            //public IActionResult ListaPisosPorFiltro()
            //{
            //    BusquedaModel busqueda = new BusquedaModel();
            //    var resultado = this.repo.GetViviendasByFilter(busqueda.TiposViviendaSelectedValue, busqueda.CostasSelectedValue, busqueda.NumeroBaniosSelectedValue, busqueda.NumeroHabitacionesSelectedValue, busqueda.Cod_Casa, busqueda.Cod_Cliente);
            //    return View(resultado);
            //}

            //public IActionResult ListaPisosPorFiltroLoad(int idCosta)
            //{
            //    BusquedaModel busqueda = new BusquedaModel();
            //    var resultado = this.repo.GetViviendasByFilter(busqueda.TiposViviendaSelectedValue, idCosta, busqueda.NumeroBaniosSelectedValue, busqueda.NumeroHabitacionesSelectedValue, busqueda.Cod_Casa, busqueda.Cod_Cliente);
            //    return View("~/Views/Home/ListaPisosPorFiltro.cshtml", resultado);
            //}



        }
    }
}