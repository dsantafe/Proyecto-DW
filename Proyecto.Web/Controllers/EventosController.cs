using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Proyecto.Web.Controllers
{
    public class EventosController
    {
        public List<Logica.Models.clsEventos> getEventosController()
        {
            try
            {
                wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();
                string json = obwsServicios.getEventosWS();

                List<Logica.Models.clsEventos> lstclsEventos =
                    JsonConvert.DeserializeObject<List<Logica.Models.clsEventos>>(json);

                return lstclsEventos;
            }
            catch (Exception ex) { throw ex; }
        }

        public object getEventosXMLController()
        {
            try
            {
                wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();
                var lstclsEventos = obwsServicios.getEventosWS_XML();

                return lstclsEventos;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}