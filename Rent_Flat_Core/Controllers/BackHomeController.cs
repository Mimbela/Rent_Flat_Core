using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rent_Flat_Core.Filters;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core.Controllers
{
    [EmpleadosAuthorize]
    public class BackHomeController : Controller
    {
        RepositoryApiRent repo;
        public BackHomeController(RepositoryApiRent repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> Index(/*int? indice*/)//lo haré con linq//? son opcionales
        {
            var viviendas = await this.repo.GetViviendasAsync();
            var tiposViviendas = await this.repo.GetTiposViviendasAsync();
            var costas = await this.repo.GetNombreCostasAsync();
            int totalViviendas = viviendas.Count();
            int totalTiposViviendas = tiposViviendas.Count();
            int totalCostas = costas.Count();
            ViewBag.TotalPisos = totalViviendas;
            ViewBag.TotalTiposVivienda = totalTiposViviendas;
            ViewBag.TotalCostas = totalCostas;

            //if (indice == null)
            //{
            //    indice = 0;
            //}

            //int numeroregistros = 0;


          //  List<VISTATODOSCLIENTES> clientes = this.repo.PaginarClientes(indice.GetValueOrDefault(), ref numeroregistros);
           // ViewBag.Registros = numeroregistros;

            //  return View(clientes);
            return View();
        }
    }
}