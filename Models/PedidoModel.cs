using System.ComponentModel.DataAnnotations;

namespace CRUDBiblioteca.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha de pedido es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de pedido no es válida.")]
        public string FechaPedido { get; set; }
	}
}
