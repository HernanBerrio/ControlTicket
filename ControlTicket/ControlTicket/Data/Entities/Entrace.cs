using System.ComponentModel.DataAnnotations;

namespace ControlTicket.Data.Entities
{
    public class Entrace
    {
        public int Id { get; set; }

        [Display(Name = "Entrada")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Description { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }
}
