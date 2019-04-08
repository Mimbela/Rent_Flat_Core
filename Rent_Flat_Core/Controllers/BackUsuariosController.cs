using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;
using Rent_Flat_Core.Services;

namespace Rent_Flat_Core.Controllers
{
    public class BackUsuariosController : Controller
    {
      
     
            RepositoryApiRent repo;
            public BackUsuariosController(RepositoryApiRent repo)
            {
                this.repo = repo;
            }

        public async Task<IActionResult> Usuarios()
        {
            return View(await this.repo.GetUsuariosAsync());
        }

        //-----------

        public async Task<IActionResult> Edit(int id)
        {

            var usuario =await this.repo.BuscarUsuarioAsync(id);
            usuario.Password = string.Empty;

            return View(await this.repo.BuscarUsuarioAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Usuarios u, int id)
        {
            string token = HttpContext.Session.GetString("TOKEN");

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

            await this.repo.ModificarUsuarioAsync(u,id,token);
            return RedirectToAction("Usuarios");
        }

        //------------------------------------------
        public async Task<IActionResult> Create()
        {
            var listausuarios = await this.repo.GetUsuariosAsync();
            List<SelectListItem> listaPerfiles = new List<SelectListItem>();

            foreach (var item in listausuarios)
            {
                SelectListItem selList = new SelectListItem() { Value = item.DIR.ToString(), Text = item.Perfil };
                if (!listaPerfiles.Any(x => x.Value == selList.Value && x.Text == selList.Text))
                {
                    listaPerfiles.Add(selList);
                }
            }

            ViewBag.ListaPerfiles = listaPerfiles;
            return View(new Usuarios());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuarios cl)
        {
            EncodingService encodingService = new EncodingService();
            string token = HttpContext.Session.GetString("TOKEN");

            var listausuarios = await this.repo.GetUsuariosAsync();
            List<SelectListItem> listaPerfiles = new List<SelectListItem>();
            foreach (var item in listausuarios)
            {
                SelectListItem selList = new SelectListItem() { Value = item.DIR.ToString(), Text = item.Perfil };
                if (!listaPerfiles.Any(x => x.Value == selList.Value && x.Text == selList.Text))
                {
                    listaPerfiles.Add(selList);
                }
            }
            if (!ModelState.IsValid)
            {
                ViewBag.ListaPerfiles = listaPerfiles;
                return View(cl);
            }

            cl.Perfil = listaPerfiles.Any(x=>x.Value==cl.DIR.ToString()) ? listaPerfiles.Where(x=>x.Value == cl.DIR.ToString()).Select(x=>x.Text).FirstOrDefault() : null;
                cl.Password = encodingService.SHA256(cl.Password);

            await this.repo.InsertarUsuarioAsync(cl, token);


            return RedirectToAction("Usuarios");
        }

        //------------

        public async Task<IActionResult> Delete(int id)
        {
            Usuarios cl = await this.repo.BuscarUsuarioAsync(id);
            return View(cl);
        }


        [HttpPost]
        public async Task<IActionResult> EliminarUsuario(int Cod_usuario)
        {
            string token = HttpContext.Session.GetString("TOKEN");
            await this.repo.EliminarUsuarioAsync(Cod_usuario, token);
            return RedirectToAction("Usuarios");

        }

        ////------------------------------------------------------
        ////DELETE
        //public IActionResult Delete(int id)
        //{
        //    Usuarios usuarios = this.repo.BuscarUsuario(id);
        //    return View(usuarios);
        //}


        //public IActionResult EliminarUsuario(int id)
        //{
        //    this.repo.EliminarUsuario(id);
        //    return RedirectToAction("Usuarios");
        //}
    }
}