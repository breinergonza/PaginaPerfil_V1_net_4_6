using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using PaginaPerfil_V1_net_4_6.Modelo;
using PaginaPerfil_V1_net_4_6.Models;

namespace PaginaPerfil_V1_net_4_6.Controllers
{
    public class MapsController : Controller
    {
       
        // GET: Maps
        public IActionResult Index()
        {
            ViewData["Message"] = "Este es un mapa creado con la API de Google";
            return View();
        }

      
    }
}
