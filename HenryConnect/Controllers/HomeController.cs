using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HenryConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List", "Book");
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A MVC connection page. Database is housed on Azure";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Lee M. Cottrell lee@leecottrell.com";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Book()
        {
            return RedirectToAction("List", "Book");
                                //object, controller
        }
    }
}
