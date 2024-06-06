using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;

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
