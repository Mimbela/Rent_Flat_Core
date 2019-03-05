using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core.Controllers
{
    public class BackTipoViviendaController : Controller
    {
        IRepository repo;
        public BackTipoViviendaController(IRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult GetTiposVivienda()
        {

            return View(this.repo.GetTiposViviendas());
        }
        //---------------------------------------------------------------------
        //GET: EDIT

      //  [Authorize(Roles = "Director")]
        public IActionResult Edit(int id)
        {

            return View(this.repo.BuscarTipoVivienda(id));
        }
        [HttpPost]
        public IActionResult Edit(Tipos_Vivienda c)
        {
            if (!ModelState.IsValid)
            {
                return View(c);
            }
            this.repo.ModificarTipoVivienda(c);
            return RedirectToAction("GetTiposVivienda");
        }
        //----------------------------
        //GET: CREATE

      //  [Authorize(Roles = "Director")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tipos_Vivienda u)
        {
            if (!ModelState.IsValid)
            {
                return View(u);
            }
            this.repo.InsertarTipoViviendas(u);
            return RedirectToAction("GetTiposVivienda");
        }

        //----------------------------
        //DELETE

      //  [Authorize(Roles = "Director")]
        public IActionResult Delete(int id)
        {
            Tipos_Vivienda tipos = this.repo.BuscarTipoVivienda(id);
            return View(tipos);
        }


        public IActionResult EliminarTipoVivienda(int id)
        {
            this.repo.EliminarTipoViviendas(id);
            return RedirectToAction("GetTiposVivienda");
        }
    }
}