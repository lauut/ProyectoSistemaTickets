using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;

namespace ProyectoSistemaTickets.Controllers
{
    public class clientesController : Controller
    {
        private readonly CompanyContext _CompanyContext;
        public clientesController(CompanyContext CompanyContext)
        {
            _CompanyContext = CompanyContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CrearcuentaCliente(int idcliente, int Idcuenta, string nombre, string correo, string direc, string tel, string usuario, string contra)
        {
            var Cliente = _CompanyContext.clientes.FirstOrDefault(c => c.idcliente == idcliente);
            var Usuario = _CompanyContext.cuentas.FirstOrDefault(u => u.Idcuenta == Idcuenta);

            clientes nuevocliente = new clientes();
            nuevocliente.nombre = nombre;
            nuevocliente.correo = correo;
            nuevocliente.direc = direc;
            nuevocliente.tel = tel;

            _CompanyContext.Add(nuevocliente);
            _CompanyContext.SaveChanges();

            cuentas nuevouser = new cuentas();
            nuevouser.usuario = usuario;
            nuevouser.contra = contra;
            _CompanyContext.Add(nuevouser);
            _CompanyContext.SaveChanges();





            return RedirectToAction("Index");
        }
    }
}
