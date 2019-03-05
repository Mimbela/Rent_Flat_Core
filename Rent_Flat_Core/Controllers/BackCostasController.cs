using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core.Controllers
{
    public class BackCostasController : Controller
    {
        IRepository repo;
        public BackCostasController(IRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Nombre_Costas()
        {
            return View(this.repo.GetNombreCostas());
        }

        //--------------------------------------------------------------------
        //GET: EDIT

 
      //  [AutorizacionUsuarios(Roles = "Director")]

        public IActionResult Edit(int id)
        {

            return View(this.repo.BuscarCosta(id));
        }
        [HttpPost]

        public IActionResult Edit(Costas c)
        {
            if (!ModelState.IsValid)
            {
                return View(c);
            }
            this.repo.ModificarCosta(c);
            return RedirectToAction("Nombre_Costas");
        }
        //----------------------------
        //GET: CREATE

      //  [AutorizacionUsuarios(Roles = "Director")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Costas costas)
        {
            if (!ModelState.IsValid)
            {
                return View(costas);
            }
            this.repo.InsertarCosta(costas);
            return RedirectToAction("Nombre_Costas");
        }
        //-----------------------
        //DELETE
   //     [AutorizacionUsuarios(Roles = "Director")]

        public IActionResult Delete(int id)
        {
            Costas costas = this.repo.BuscarCosta(id);
            return View(costas);
        }

        //Delete
        public IActionResult EliminarCostas(int id)
        {
            this.repo.EliminarCosta(id);
            return RedirectToAction("Nombre_Costas");
        }

    }
}