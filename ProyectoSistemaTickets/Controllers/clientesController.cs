using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class clientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
