using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace PaginaPerfil_V1_net_4_6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Descripcion 'Acerca de'.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Descricpion 'Contact'.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
