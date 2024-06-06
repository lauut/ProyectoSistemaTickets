using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoSistemaTickets.Models;
using System.Net.Sockets;

namespace ProyectoSistemaTickets.Controllers
{
    public class detalle_ticketController : Controller
    {
        private readonly CompanyContext _context;
      

        public detalle_ticketController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var detalleticket = (from t in _context.ticket
                                 join p in _context.prioridad on t.idpriori equals p.idpriori
                                 join dt in _context.detalle_ticket on t.idticket equals dt.idticket
                                 join e in _context.estados on dt.idestado equals e.idestado
                                 select new
                                 {
                                     t.nombre,
                                     descrip = t.descripcion,
                                     nombrepriori = p.nombre,
                                     //t.contacto crear campo contacto en ticket maybe;(
                                     estado = e.nombre,
                                     fecha = t.fechacrear


                                 }).ToList();

            return View(detalleticket);
        }

     

    }
}
