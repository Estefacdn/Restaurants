using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restaurants.Models;
using Restaurants.Models.ViewModels;

namespace Restaurants.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
      
        public ActionResult Menu()
        {
            ViewBag.mostrar = "Menu";
            return View();
        }
    }
}