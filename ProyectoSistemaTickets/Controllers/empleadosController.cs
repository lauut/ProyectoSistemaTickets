using Microsoft.AspNetCore.Mvc;
using ProyectoSistemaTickets.Models;

namespace ProyectoSistemaTickets.Controllers
{
    public class empleadosController : Controller
    {
        private readonly CompanyContext _CompanyContext;
        public empleadosController(CompanyContext CompanyContext)
        {
            _CompanyContext = CompanyContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Crearcuentaempleado(int idempleado, int Idcuenta, string nombre, string tel, string usuario, string contra)
        {
            var Empleado = _CompanyContext.empleados.FirstOrDefault(e =>e.idempleado ==idempleado);
            var Usuario = _CompanyContext.cuentas.FirstOrDefault(u => u.Idcuenta == Idcuenta);

            empleados nuevoemple = new empleados();
            nuevoemple.nombre = nombre;
            nuevoemple.tel = tel;
            _CompanyContext.Add(nuevoemple);
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
