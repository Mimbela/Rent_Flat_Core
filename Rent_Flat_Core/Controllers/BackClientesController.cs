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
        IRepository repo;
        public BackClientesController(IRepository repo)
        {
            this.repo = repo;
        }

        //--------
        //public ActionResult Clientes()
        //{
        //    return View(this.repo.GetClientes());
        //}

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