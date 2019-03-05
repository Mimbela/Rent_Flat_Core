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
        IRepository repo;
        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }
        //------------------
        public IActionResult Index()
        {
            var tiposVivienda = this.repo.GetTiposViviendas();
            var costas = this.repo.GetNombreCostas();

            BusquedaModel busquedaModel = new BusquedaModel();

            busquedaModel.TiposVivienda.AddRange(tiposVivienda.Select(x => new SelectListItem() { Value = x.Cod_tipo_vivienda.ToString(), Text = x.Descripcion }));
            busquedaModel.ListaCostas.AddRange(costas.Select(x => new SelectListItem() { Value = x.Cod_Provincia.ToString(), Text = x.NombreProvincia }));

            ViewBag.Resumen2 = this.repo.GetViviendas();

            return View(busquedaModel);
        }
      //  [HttpPost]
        //public IActionResult ListaPisosPorFiltro(BusquedaModel busqueda)
        //{
        //    if (busqueda is null) busqueda = new BusquedaModel();
        //    busqueda.Cod_Casa = 0;
        //    busqueda.Cod_Cliente = 0;

        //    return View(this.repo.GetViviendasByFilter(busqueda.TiposViviendaSelectedValue, busqueda.CostasSelectedValue, busqueda.NumeroBaniosSelectedValue, busqueda.NumeroHabitacionesSelectedValue, busqueda.Cod_Casa, busqueda.Cod_Cliente));
        //}

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