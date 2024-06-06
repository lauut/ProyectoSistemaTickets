using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;

namespace ProyectoSistemaTickets.Controllers
{
    public class detalle_ticketController : Controller
    {
        private readonly CompanyContext _CompanyContext;
        public detalle_ticketController(CompanyContext CompanyContext)
        {
            _CompanyContext = CompanyContext;
        }

        public IActionResult Index()
        {
            var detalleticket = (from t in _CompanyContext.ticket
                          join p in _CompanyContext.prioridad on t.idpriori equals p.idpriori
                          join dt in _CompanyContext.detalle_ticket on t.idticket equals dt.idticket
                          join e in _CompanyContext.estados on dt.idestado equals e.idestados
                          select new
                          {
                              t.nombre,
                              descrip = t.descripcion,
                              nombrepriori = p.nombre,
                              //t.contacto crear campo contacto en ticket maybe;(
                              estado = e.nombre,
                              fecha = t.fechacrear




                          }).ToList();

            ViewData["ticket"] = detalleticket;



            return View();
        }

       
    }
}
