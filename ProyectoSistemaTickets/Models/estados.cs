using System.ComponentModel.DataAnnotations;

namespace ProyectoSistemaTickets.Models
{
    public class estados
    {
        [Key]
        public int idestados { get; set; }
        public string nombre { get; set; }

    }
}
