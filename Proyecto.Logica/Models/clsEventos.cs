namespace Proyecto.Logica.Models
{
    public class clsEventos
    {
        public int CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string UBICACION { get; set; }
        public string PARTICIPANTES { get; set; }
        public string TODO_DIA { get; set; }
        public string FECHA { get; set; }
        public clsRelacionadoCon RELACIONADO_CON { get; set; }
        public string DESCRIPCION { get; set; }
    }
}
