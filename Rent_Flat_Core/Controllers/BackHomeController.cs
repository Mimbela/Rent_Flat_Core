using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core.Controllers
{
    public class BackHomeController : Controller
    {
        IRepository repo;
        public BackHomeController(IRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index(int? indice)//lo haré con linq//? son opcionales
        {
            if (indice == null)
            {
                indice = 0;
            }

            int numeroregistros = 0;


          //  List<VISTATODOSCLIENTES> clientes = this.repo.PaginarClientes(indice.GetValueOrDefault(), ref numeroregistros);
            ViewBag.Registros = numeroregistros;

            //  return View(clientes);
            return View();
        }
    }
}