using Microsoft.AspNetCore.Mvc;

namespace ProyectoSistemaTickets.Controllers
{
    public class ticketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
