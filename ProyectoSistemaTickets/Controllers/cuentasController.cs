using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProyectoSistemaTickets.Controllers
{
    public class cuentasController : Controller
    {
        private readonly CompanyContext _context;

        public cuentasController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }



    }
}



