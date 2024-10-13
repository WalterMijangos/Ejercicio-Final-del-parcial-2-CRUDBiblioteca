using System.ComponentModel.DataAnnotations;

namespace CRUDBiblioteca.Models
{
    public class Cliente
    {
		public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El número de teléfono debe tener 8 dígitos.")]
        public int Numero { get; set; }

	}
}
