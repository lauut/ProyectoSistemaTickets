using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoSistemaTickets.Models;

namespace ProyectoSistemaTickets.Controllers
{
    public class detalle_admiController : Controller
    {
        private readonly CompanyContext _context;

        public detalle_admiController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listaDePrioridad = (from p in _context.prioridad
                                    select p).ToList();
            ViewData["listadoDePrioridad"] = new SelectList(listaDePrioridad, "idpriori", "nombre");

            var listaDeEstados = (from es in _context.estados
                                  select es).ToList();
            ViewData["listadoDeEstados"] = new SelectList(listaDeEstados, "idestado", "nombre");

            return View();
        }
    }
}
