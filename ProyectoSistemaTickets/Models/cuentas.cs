using System.ComponentModel.DataAnnotations;

namespace ProyectoSistemaTickets.Models
{
    public class cuentas
    {
        [Key]
        public int Idcuenta { get; set; }
        public string usuario { get; set; }
        public string contra { get; set; }
        public int tipo_usuario { get; set; }

        
    }
}
