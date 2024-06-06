using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;

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
