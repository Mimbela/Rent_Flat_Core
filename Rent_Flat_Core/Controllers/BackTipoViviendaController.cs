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
        //IRepository repo;

        RepositoryApiRent repo;
        public BackTipoViviendaController(RepositoryApiRent repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult> GetTipoVivienda()
        {
            return View(await this.repo.GetTiposViviendasAsync());
        }


        //--------

        public async Task<IActionResult> Edit(int id)
        {
            //Costas hosp = await this.repo.BuscarCostaAsync(id);

            return View(await this.repo.BuscarTipoViviendaAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Tipos_Vivienda tipo, int id)
        {
            await this.repo.ModificarTipoViviendaAsync(tipo, id);

            if (!ModelState.IsValid)
            {

                return View(tipo);
            }

            return RedirectToAction("GetTipoVivienda");
        }

        //-----------------
        //CREATE

        public async Task<IActionResult> Create()
        {

            return View(new Tipos_Vivienda());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tipos_Vivienda cl)
        {

            if (!ModelState.IsValid)
            {
                return View(cl);

            }
            await this.repo.InsertarTipoViviendaAsync(cl);
            return RedirectToAction("GetTipoVivienda");
        }

        //-----------------

        public async Task<IActionResult> Delete(int id)
        {
            Tipos_Vivienda cl = await this.repo.BuscarTipoViviendaAsync(id);
            return View(cl);
        }


        [HttpPost]
        public async Task<IActionResult> EliminarTipoVivienda(int Cod_tipo_vivienda)
        {
            await this.repo.EliminarTipoViviendaAsync(Cod_tipo_vivienda);
            return RedirectToAction("GetTipoVivienda");

        }
        //---------------

        //    public IActionResult GetTiposVivienda()
        //    {

        //        return View(this.repo.GetTiposViviendas());
        //    }
        //    //---------------------------------------------------------------------
        //    //GET: EDIT

        //  //  [Authorize(Roles = "Director")]
        //    public IActionResult Edit(int id)
        //    {

        //        return View(this.repo.BuscarTipoVivienda(id));
        //    }
        //    [HttpPost]
        //    public IActionResult Edit(Tipos_Vivienda c)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View(c);
        //        }
        //        this.repo.ModificarTipoVivienda(c);
        //        return RedirectToAction("GetTiposVivienda");
        //    }
        //    //----------------------------
        //    //GET: CREATE

        //  //  [Authorize(Roles = "Director")]
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }
        //    [HttpPost]
        //    public IActionResult Create(Tipos_Vivienda u)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View(u);
        //        }
        //        this.repo.InsertarTipoViviendas(u);
        //        return RedirectToAction("GetTiposVivienda");
        //    }

        //    //----------------------------
        //    //DELETE

        //  //  [Authorize(Roles = "Director")]
        //    public IActionResult Delete(int id)
        //    {
        //        Tipos_Vivienda tipos = this.repo.BuscarTipoVivienda(id);
        //        return View(tipos);
        //    }


        //    public IActionResult EliminarTipoVivienda(int id)
        //    {
        //        this.repo.EliminarTipoViviendas(id);
        //        return RedirectToAction("GetTiposVivienda");
        //    }
    }
}