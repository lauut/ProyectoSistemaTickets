using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProyectoSistemaTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                var datosUsuario = JsonSerializer.Deserialize<cuentas>(HttpContext.Session.GetString("user"));
                ViewBag.NombreUsuario = datosUsuario.Usuario;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
