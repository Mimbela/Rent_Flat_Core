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
    public class BackClientesController : Controller
    {
        RepositoryApiRent repo;
        public BackClientesController(RepositoryApiRent repo)
        {
            this.repo = repo;
        }

        //--------
        public async Task <IActionResult> Clientes()
        {
            return View(await this.repo.GetClientesAsync());
        }


        //-------------EDIT
        public async Task<IActionResult> ModificarCliente(int id)
        {
            Clientes hosp = await this.repo.BuscarClientesAsync(id);

            List <Tipos_Vivienda> v = await this.repo.GetTiposViviendasAsync();
            List<SelectListItem> comboviviendas = new List<SelectListItem>();
            foreach (var item in await this.repo.GetNombreCostasAsync())
            {
                SelectListItem costa = new SelectListItem();
                costa.Value = item.NombreProvincia;
                costa.Text = item.NombreProvincia;
                comboviviendas.Add(costa);
            }
            ViewBag.ComboCostas = comboviviendas;
                 return View(await this.repo.BuscarClientesAsync(id));
            //return View(hosp);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarCliente(Clientes clientes, int id)
        {
            await this.repo.ModificarClienteAsync(clientes, id);

            if (!ModelState.IsValid)
            {
                List<SelectListItem> comboviviendas = new List<SelectListItem>();
                foreach (var item in await this.repo.GetNombreCostasAsync())
                {
                    SelectListItem costa = new SelectListItem();
                    costa.Value = item.NombreProvincia;
                    costa.Text = item.NombreProvincia;
                    comboviviendas.Add(costa);

                }
                ViewBag.ComboCostas = comboviviendas;
                return View(clientes);
            }
                return RedirectToAction("Clientes");
        }

        //--------------------------CREATE

        public async Task <IActionResult>InsertarCliente()
        {
            List<SelectListItem> comboviviendas = new List<SelectListItem>();
            foreach (var item in await this.repo.GetNombreCostasAsync())
            {
                SelectListItem costa = new SelectListItem();
                costa.Value = item.NombreProvincia;
                costa.Text = item.NombreProvincia;
                comboviviendas.Add(costa);

            }
            ViewBag.ComboCostas = comboviviendas;
            return View(new Clientes());
        }

        [HttpPost]
        public async Task<IActionResult> InsertarCliente(Clientes cl)
        {
          
            if (!ModelState.IsValid)
            {
                List<SelectListItem> comboviviendas = new List<SelectListItem>();
                foreach (var item in await this.repo.GetNombreCostasAsync())
                {
                    SelectListItem costa = new SelectListItem();
                    costa.Value = item.NombreProvincia;
                    costa.Text = item.NombreProvincia;
                    comboviviendas.Add(costa);

                }



                ViewBag.ComboCostas = comboviviendas;
                return View(cl);
            }
            await this.repo.InsertarClienteAsync(cl);
            return RedirectToAction("Clientes");
  }

        

          public async Task <IActionResult> Delete(int id)
        {
            Clientes cl= await this.repo.BuscarClientesAsync(id);
            return View (cl);
        }


        [HttpPost]
        public async Task<IActionResult>EliminarCliente(int IdCliente)
        {
            await this.repo.EliminarClienteAsync(IdCliente);
            return RedirectToAction("Clientes");

        }



     









        // public IActionResult Create()
        //  {
        //      List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //      foreach (var item in this.repo.GetNombreCostas())
        //      {
        //          SelectListItem costa = new SelectListItem();
        //          costa.Value = item.NombreProvincia;
        //          costa.Text = item.NombreProvincia;
        //          comboviviendas.Add(costa);

        //      }
        //      ViewBag.ComboCostas = comboviviendas;
        //      return View(new Clientes());
        //  }
        //  [HttpPost]
        //  public IActionResult Create(Clientes cl)
        //  {
        //      if (!ModelState.IsValid)
        //      {
        //          List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //          foreach (var item in this.repo.GetNombreCostas())
        //          {
        //              SelectListItem costa = new SelectListItem();
        //              costa.Value = item.NombreProvincia;
        //              costa.Text = item.NombreProvincia;
        //              comboviviendas.Add(costa);

        //          }



        //          ViewBag.ComboCostas = comboviviendas;
        //          return View(cl);
        //      }
        //      this.repo.InsertarClientes(cl);
        //      return RedirectToAction("Clientes");
        //  }


        //---------------------------------
        //   [AutorizacionUsuarios(Roles = "Director")]
        //  public IActionResult Edit(int id)
        //  {
        //      List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //      foreach (var item in this.repo.GetNombreCostas())
        //      {
        //          SelectListItem costa = new SelectListItem();
        //          costa.Value = item.NombreProvincia;
        //          costa.Text = item.NombreProvincia;
        //          comboviviendas.Add(costa);

        //      }
        //      ViewBag.ComboCostas = comboviviendas;
        //      return View(this.repo.BuscarClientes(id));
        //  }
        //  [HttpPost]

        //  public IActionResult Edit(Clientes c)
        //  {
        //      if (!ModelState.IsValid)
        //      {
        //          List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //          foreach (var item in this.repo.GetNombreCostas())
        //          {
        //              SelectListItem costa = new SelectListItem();
        //              costa.Value = item.NombreProvincia;
        //              costa.Text = item.NombreProvincia;
        //              comboviviendas.Add(costa);

        //          }
        //          ViewBag.ComboCostas = comboviviendas;
        //          return View(c);
        //      }
        //      this.repo.ModificarClientes(c);
        //      return RedirectToAction("Clientes");
        //  }

        //  //----------------------------
        //  //GET: CREATE

        // // [AutorizacionUsuarios(Roles = "Director")]
        //  public IActionResult Create()
        //  {
        //      List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //      foreach (var item in this.repo.GetNombreCostas())
        //      {
        //          SelectListItem costa = new SelectListItem();
        //          costa.Value = item.NombreProvincia;
        //          costa.Text = item.NombreProvincia;
        //          comboviviendas.Add(costa);

        //      }
        //      ViewBag.ComboCostas = comboviviendas;
        //      return View(new Clientes());
        //  }
        //  [HttpPost]
        //  public IActionResult Create(Clientes cl)
        //  {
        //      if (!ModelState.IsValid)
        //      {
        //          List<SelectListItem> comboviviendas = new List<SelectListItem>();
        //          foreach (var item in this.repo.GetNombreCostas())
        //          {
        //              SelectListItem costa = new SelectListItem();
        //              costa.Value = item.NombreProvincia;
        //              costa.Text = item.NombreProvincia;
        //              comboviviendas.Add(costa);

        //          }



        //          ViewBag.ComboCostas = comboviviendas;
        //          return View(cl);
        //      }
        //      this.repo.InsertarClientes(cl);
        //      return RedirectToAction("Clientes");
        //  }
        //  //------------------
        //  //-----------------------
        //  //DELETE
        ////  [AutorizacionUsuarios(Roles = "Director")]

        //  public IActionResult Delete(int id)
        //  {
        //      Clientes cl = this.repo.BuscarClientes(id);
        //      return View(cl);
        //  }

        //  //Delete
        //  public IActionResult EliminarClientes(int id)
        //  {
        //      this.repo.EliminarClientes(id);
        //      return RedirectToAction("Clientes");
        //  }
    }
}