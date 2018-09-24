using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Proyecto.MVC.Models
{
    public class EstadoIncidencia
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
    }
}