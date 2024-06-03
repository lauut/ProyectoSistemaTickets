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

        public IActionResult ValidarUsuario(cuentas cuenta)
        {

            cuentas? usuario = (from user in _context.cuentas
                                where user.usuario == cuenta.usuario
                                && user.contra == cuenta.contra
                                select user).FirstOrDefault();

            if (usuario == null)
            {
                ViewBag.Mensaje = "Usuario o contraseña incorrectos :(";
                return View("Index");

                String datosUsuario = JsonSerializer.Serialize(usuario);
                HttpContext.Session.SetString("user", datosUsuario);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


    }
}



