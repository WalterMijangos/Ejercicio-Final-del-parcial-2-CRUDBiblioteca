using System.ComponentModel.DataAnnotations;

namespace CRUDBiblioteca.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre debe de ser Obligatorio")]
        [StringLength(100, ErrorMessage ="El nombre no debe de tener más de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El precio es Obligatorio")]
        [Range(0.01, 999.99, ErrorMessage ="El precio debe de estar entre el 0.01 y 999.99")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La cantidad es Obligatoria")]
        [Range(0.01, 999.99, ErrorMessage = "La cantidad debe de estar entre el 0.01 y 999.99")]
        public int Cantidad { get; set; }
    }
}
