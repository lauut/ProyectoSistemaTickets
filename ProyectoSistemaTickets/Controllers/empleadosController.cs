using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class empleadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
