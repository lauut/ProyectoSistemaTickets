using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class HomeClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
