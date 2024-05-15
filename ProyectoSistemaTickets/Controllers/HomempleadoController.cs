using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class HomempleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
