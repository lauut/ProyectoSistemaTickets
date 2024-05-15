using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class HomeadminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
