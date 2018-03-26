namespace Proyecto.Logica.Models
{
    public class clsCorreo
    {
        public string stServidor { get; set; }
        public string stUsuario { get; set; }
        public string stPassword { get; set; }
        public bool blConexionSegura { get; set; }
        public bool blAutenticacion { get; set; }
        public string stFrom { get; set; }
        public string stTo { get; set; }
        public string stAsunto { get; set; }
        public string stMensaje { get; set; }
        public int inTipo { get; set; }
        public int inPrioridad { get; set; }
        public string stPuerto { get; set; }
        public string stImagen { get; set; }
        public string stIdImagen { get; set; }
    }
}
