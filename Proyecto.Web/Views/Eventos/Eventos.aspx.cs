using System;
using System.Collections.Generic;

namespace Proyecto.Web.Views.Eventos
{
    public partial class Eventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getEventosXML();
            }
        }

        public void getEventos()
        {
            try
            {
                Controllers.EventosController obEventosController = new Controllers.EventosController();
                List<Logica.Models.clsEventos> lstclsEventos = obEventosController.getEventosController();

                if (lstclsEventos.Count > 0) gvwDatos.DataSource = lstclsEventos;
                else gvwDatos.DataSource = null;

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error','" + ex.Message + "','error') </script>");
            }
        }

        public void getEventosXML()
        {
            try
            {
                Controllers.EventosController obEventosController = new Controllers.EventosController();
                var lstclsEventos = obEventosController.getEventosXMLController();

                if (lstclsEventos != null) gvwDatos.DataSource = lstclsEventos;
                else gvwDatos.DataSource = null;

                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error','" + ex.Message + "','error') </script>");
            }
        }
    }
}