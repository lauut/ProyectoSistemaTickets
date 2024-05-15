using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class cuentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
