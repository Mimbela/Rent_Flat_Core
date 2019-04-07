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
            var costas = await this.repo.GetNombreCostasAsync();
            BusquedaModel busquedaModel = new BusquedaModel();
            
           // busquedaModel.TiposVivienda.AddRange(tiposVivienda.Select(x => new SelectListItem() { Value = x.Cod_tipo_vivienda.ToString(), Text = x.Descripcion }));
           foreach (var tipoVivienda in tiposVivienda)
            {
                var algo = new SelectListItem();
                algo.Value = tipoVivienda.Cod_tipo_vivienda.ToString();
                algo.Text = tipoVivienda.Descripcion;
                busquedaModel.TiposVivienda.Add(algo);
            }
        //  busquedaModel.ListaCostas.AddRange(costas.Select(x => new SelectListItem() { Value = x.Cod_Provincia.ToString(), Text = x.NombreProvincia }));

            foreach (var costa in costas)
            {
                var algo2 = new SelectListItem();
                algo2.Value = costa.Cod_Provincia.ToString();
                algo2.Text = costa.NombreProvincia;

                busquedaModel.ListaCostas.Add(algo2);
            }
             return View(busquedaModel);
        }



        public async Task <IActionResult> ListaPisosPorFiltro()
        {
            BusquedaModel busqueda = new BusquedaModel();
            var resultado =await this.repo.GetViviendasByFilterAsync(busqueda);
            return View(resultado);
        }


        [HttpPost]
        public async Task<IActionResult> ListaPisosPorFiltro(BusquedaModel busqueda)
        {
            if (busqueda is null) busqueda = new BusquedaModel();
            busqueda.Cod_Casa = 0;
            busqueda.Cod_Cliente = 0;
            var otro = await this.repo.GetViviendasByFilterAsync(busqueda);
            return View(otro);
        }
        public async Task <IActionResult> Property(int cod_casa)//para sacar una casa para la descripción
        {
            BusquedaModel busqueda = new BusquedaModel();
            busqueda.TiposViviendaSelectedValue = 0;
            busqueda.TiposViviendaSelectedValue= 0;
            busqueda.CostasSelectedValue= 0;
            busqueda.NumeroBaniosSelectedValue=0;
            busqueda.NumeroBaniosSelectedValue= 0;
            busqueda.Cod_Cliente= 0;
            busqueda.Cod_Casa = cod_casa;
            var propiedad = await this.repo.GetViviendasByFilterAsync(busqueda);
            return View(propiedad.FirstOrDefault());
        }



        public async Task <IActionResult> ListaPisosPorFiltroLoad(int idCosta)
        {
            BusquedaModel busqueda = new BusquedaModel();
            busqueda.CostasSelectedValue = idCosta;
            busqueda.TiposViviendaSelectedValue = 0;
            busqueda.TiposViviendaSelectedValue = 0;
          
            busqueda.NumeroBaniosSelectedValue = 0;
            busqueda.NumeroBaniosSelectedValue = 0;
            busqueda.Cod_Cliente = 0;
            busqueda.Cod_Casa = 0;


            var resultado = await this.repo.GetViviendasByFilterAsync(busqueda);
            return View("~/Views/Home/ListaPisosPorFiltro.cshtml", resultado);
        }



    }
    
}