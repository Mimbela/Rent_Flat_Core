using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_Flat_Core.Models;
using Rent_Flat_Core.Repositories;
using Rent_Flat_Core.Services;

namespace Rent_Flat_Core.Controllers
{
    public class ValidacionController : Controller
    {
        RepositoryApiRent repo;
        public ValidacionController()
        {
            this.repo = new RepositoryApiRent();


        }

        //------------------------
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(String usuario, String password)
        {
            EncodingService encoding = new EncodingService();
            //BUSCAMOS EL TOKEN PARA COMPROBAR LAS CREDENCIALES
            //DEL EMPLEADO
            String token = await this.repo.GetToken(usuario, encoding.SHA256(password));
            //SI EL TOKEN ES NULL, NO TIENE CREDENCIALES
            if (token != null)
            {
                HttpContext.Session.SetString("TOKEN", token);//esta es la linea importante de acceso con la api
                //SI TENEMOS TOKEN, TENEMOS EMPLEADO
                //POR LO QUE PODEMOS RECUPERARLO DEL METODO PERFILEMPLEADO
                Usuarios empleado = await
                    this.repo.PerfilEmpleado(token);
                //CREAMOS AL USUARIO PARA EL ENTORNO MVC DE CORE
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                //ALMACENAMOS EL ID DE EMPLEADO
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier
                    , empleado.Login));
                identity.AddClaim(new Claim(ClaimTypes.Name, empleado.Apellido+", "+empleado.Nombre));
                //GUARDAMOS TAMBIEN EL ROLE DEL EMPLEADO
                identity.AddClaim(new Claim(ClaimTypes.Role, empleado.Perfil));
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme, principal
                    , new AuthenticationProperties
                    {
                        IsPersistent = true
                    ,//DEBERIAMOS DAR EL MISMO TIEMPO DE SESSION QUE TOKEN
                        ExpiresUtc = DateTime.Now.AddMinutes(60)
                    });
                //UNA VEZ QUE TENEMOS A NUESTRO EMPLEADO ALMACENADO
                //DEBEMOS ALMACENAR EL TOKEN EN SESSION PARA PODER REUTILIZARLO
                //EN OTROS METODOS DE LA APP

                //REDIRECCIONAMOS A UNA PAGINA DE INICIO PROTEGIDA
                return RedirectToAction("Index", "BackHome");
            }
            else
            {
                ViewBag.Mensaje = "Usuario/Password incorrectos";
                return View();
            }
        }


        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync
            (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}