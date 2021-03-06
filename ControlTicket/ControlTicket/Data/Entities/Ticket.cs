using System.ComponentModel.DataAnnotations;

namespace ControlTicket.Data.Entities
{
    public class Ticket
    {
        [Display(Name = "Documento del usuario")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Document { get; set; }

        [Display(Name = "Fecha Y hora del ingreso")]
        public DateTime? Date { get; set; }

        [Display(Name = "Entrada")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Entrance? Entrance { get; set; }
        public int Id { get; set; }

        [Display(Name = "Nombres y Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String? Name { get; set; }

        public bool WasUsed { get; set; }
    }
}
