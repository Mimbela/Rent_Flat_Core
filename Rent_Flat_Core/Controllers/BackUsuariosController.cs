using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;
using Rent_Flat_Core.Services;

namespace Rent_Flat_Core.Controllers
{
    public class BackUsuariosController : Controller
    {
      
     
            IRepository repo;
            public BackUsuariosController(IRepository repo)
            {
                this.repo = repo;
            }

            // GET: BackUsuarios
            public IActionResult Usuarios()
            {

                return View(this.repo.GetUsuarios());
            }

            //GET:EDIT
            public IActionResult Edit(int id)
            {
                var usuario = this.repo.BuscarUsuario(id);
                usuario.Password = string.Empty;


                return View(this.repo.BuscarUsuario(id));

            }
            [HttpPost]
            public IActionResult Edit(Usuarios u)
            {
                if (!ModelState.IsValid)
                {
                    return View(u);
                }
                var encodingService = new EncodingService();

                if (String.IsNullOrEmpty(u.Password))
                {
                    return View(u);
                }
                u.Password = encodingService.SHA256(u.Password);

                this.repo.ModificarUsuario(u);
                return RedirectToAction("Usuarios");
            }
            //----------------------------
            //GET: CREATE
            public IActionResult Create()
            {
                var algo = this.repo.ComboRolUsuario();
                List<SelectListItem> listaDePerfiles = new List<SelectListItem>();
                foreach (var item in algo)
                {
                    SelectListItem Perfil = new SelectListItem()
                    {
                        Value = item.Key.ToString(),
                        Text = item.Value
                    };
                    listaDePerfiles.Add(Perfil);

                }

                ViewBag.ListaPerfiles = listaDePerfiles;

                return View(new Usuarios());
            }
            [HttpPost]
            public IActionResult Create(Usuarios u)
            {
                var algo = this.repo.ComboRolUsuario();
                var encodingService = new EncodingService();


                if (!ModelState.IsValid)
                {
                    List<SelectListItem> listaDePerfiles = new List<SelectListItem>();
                    foreach (var item in algo)
                    {
                        SelectListItem Perfil = new SelectListItem()
                        {
                            Value = item.Key.ToString(),
                            Text = item.Value
                        };
                        listaDePerfiles.Add(Perfil);
                    }
                    ViewBag.ListaPerfiles = new List<SelectListItem>();
                    ViewBag.ListaPerfiles = listaDePerfiles;
                    return View(u);
                }
                u.Perfil = algo.ContainsKey(u.DIR) ? algo[u.DIR] : null;
                u.Password = encodingService.SHA256(u.Password);

                this.repo.InsertarUsuarios(u);
                return RedirectToAction("Usuarios");
            }
            //------------------------------------------------------
            //DELETE
            public IActionResult Delete(int id)
            {
                Usuarios usuarios = this.repo.BuscarUsuario(id);
                return View(usuarios);
            }


            public IActionResult EliminarUsuario(int id)
            {
                this.repo.EliminarUsuario(id);
                return RedirectToAction("Usuarios");
            }
        }
}