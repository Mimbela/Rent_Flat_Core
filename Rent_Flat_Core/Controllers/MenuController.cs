using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rent_Flat_Core.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult MainMenu()
        {
            return PartialView();
        }

        //----------------------------------- MENÚ DEL BACK
        public IActionResult BackMainMenu()
        {
            return PartialView();
        }
    }
}