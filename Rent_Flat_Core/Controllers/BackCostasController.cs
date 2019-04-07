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
    public class BackCostasController : Controller
    {
        RepositoryApiRent repo;
        public BackCostasController(RepositoryApiRent repo)
        {
            this.repo = repo;
        }
        public async Task <IActionResult> Nombre_Costas()
        {
            return View(await this.repo.GetNombreCostasAsync());
        }

        //--------------------------------------------------------------------
        //GET: EDIT
        public async Task<IActionResult> Edit(int id)
        {
            //Costas hosp = await this.repo.BuscarCostaAsync(id);

            return View(await this.repo.BuscarCostaAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Costas clientes, int id)
        {
            await this.repo.ModificarCostaAsync(clientes, id);

            if (!ModelState.IsValid)
            {
                
                return View(clientes);
            }
           
            return RedirectToAction("Nombre_Costas");
        }

        //--------------------------------------------------------------------
        //CREATE

        public async Task<IActionResult> Create()
        {
            
            return View(new Costas());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Costas cl)
        {

            if (!ModelState.IsValid)
            {
                return View(cl);
               
            }
            await this.repo.InsertarCostaAsync(cl);
            return RedirectToAction("Nombre_Costas");
        }

        //--------------------------

        public async Task<IActionResult> Delete(int id)
        {
            Costas cl = await this.repo.BuscarCostaAsync(id);
            return View(cl);
        }


        [HttpPost]
        public async Task<IActionResult> EliminarCosta(int Cod_Provincia)
        {
            await this.repo.EliminarCostaAsync(Cod_Provincia);
            return RedirectToAction("Nombre_Costas");

        }



        //  [AutorizacionUsuarios(Roles = "Director")]

        //public IActionResult Edit(int id)
        //{

        //    return View(this.repo.BuscarCosta(id));
        //}
        //[HttpPost]

        //public IActionResult Edit(Costas c)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(c);
        //    }
        //    this.repo.ModificarCosta(c);
        //    return RedirectToAction("Nombre_Costas");
        //}
        //----------------------------
        //GET: CREATE

        //  [AutorizacionUsuarios(Roles = "Director")]
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Costas costas)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(costas);
        //    }
        //    this.repo.InsertarCosta(costas);
        //    return RedirectToAction("Nombre_Costas");
        //}
        //-----------------------
        //DELETE
        //     [AutorizacionUsuarios(Roles = "Director")]

        //public IActionResult Delete(int id)
        //{
        //    Costas costas = this.repo.BuscarCosta(id);
        //    return View(costas);
        //}

        ////Delete
        //public IActionResult EliminarCostas(int id)
        //{
        //    this.repo.EliminarCosta(id);
        //    return RedirectToAction("Nombre_Costas");
        //}

    }
}