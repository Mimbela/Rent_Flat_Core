using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rent_Flat_Core.Controllers
{
    public class PaginasSecundariasController : Controller
    {
        public IActionResult AcercaDeNosotros()
        {
            return View();
        }


        //---------------------------------------CONTACTO
        public IActionResult Contacto()
        {
            return View();
        }

        //------------------------------------PISOS EN ALQUILER
        public IActionResult Alquiler()
        {
            return View();
        }
    }
}