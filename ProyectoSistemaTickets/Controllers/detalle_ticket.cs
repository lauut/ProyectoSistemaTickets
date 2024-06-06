using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using ProyectoSistemaTickets.Models;
=======
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoSistemaTickets.Models;
using System.Net.Sockets;
>>>>>>> 8792cfd5b48e14a2095c078b24c0cdb571bc891a

namespace ProyectoSistemaTickets.Controllers
{
    public class detalle_ticket : Controller
    {
<<<<<<< HEAD
        

        public IActionResult Index()
        {
            



            return View();
        }

       
=======
        private readonly CompanyContext _context;
      

        public detalle_ticketController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listaDeEmpleados = (from e in _context.empleados
                                    select e).ToList();
            ViewData["listadoDeEmpleados"] = new SelectList(listaDeEmpleados, "idempleado", "nombre");


            var listaDePrioridad = (from p in _context.prioridad
                                    select p).ToList();
            ViewData["listadoDePrioridad"] = new SelectList(listaDePrioridad, "idpriori", "nombre");

            var listaDeEstados = (from es in _context.estados
                                    select es).ToList();
            ViewData["listadoDeEstados"] = new SelectList(listaDeEstados, "idestado", "nombre");

            return View();

        }

        public class CreateViewModel
        {
            public ticket Ticket { get; set; }
            public empleados Empleado { get; set; }
            public clientes Cliente { get; set; }
        }

        public ActionResult Create()
        {
            ViewBag.listadoDePrioridad = new SelectList(_context.prioridad, "idpriori", "nombre");
            ViewBag.listadoDeEmpleados = new SelectList(_context.empleados, "idempleado", "nombre");
            ViewBag.listadoDeEstados = new SelectList(_context.estados, "idestado", "nombre");
            return View();
        }



>>>>>>> 8792cfd5b48e14a2095c078b24c0cdb571bc891a
    }
}
