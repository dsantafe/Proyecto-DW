using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Services;

namespace Proyecto.WS.Servicios
{
    /// <summary>
    /// Descripción breve de wsServicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsServicios : System.Web.Services.WebService
    {

        [WebMethod]
        public string getEventosWS()
        {
            Logica.BL.clsEventos obclsEventos = new Logica.BL.clsEventos();
            return JsonConvert.SerializeObject(obclsEventos.getEventos());
        }

        [WebMethod]
        public List<Logica.Models.clsEventos> getEventosWS_XML()
        {
            Logica.BL.clsEventos obclsEventos = new Logica.BL.clsEventos();
            return obclsEventos.getEventos();
        }
    }
}
