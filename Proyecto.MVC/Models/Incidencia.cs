using System.Collections.Generic;

namespace Proyecto.MVC.Models
{
    public class Incidencia
    {
        public class IndexLoad
        {
            public List<Incidencia> Incidencias { get; set; }
            public List<EstadoIncidencia> EstadoIncidencias { get; set; }
            public List<TipoIncidencia> TipoIncidencias { get; set; }
        }

        public int Id { get; set; }
        public long Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public EstadoIncidencia EstadoIncidencia { get; set; }
        public TipoIncidencia TipoIncidencia { get; set; }
    }
}