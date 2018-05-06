using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Tareas
{
    public partial class Tareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sessionEmail"] == null) Response.Redirect("../Login/Login.aspx");

                Controllers.TareasController obTareasController = new Controllers.TareasController();
                DataSet dsConsultaEstadoTareas = obTareasController.getConsultarEstadoTareasController();
                DataSet dsConsultaPrioridad = obTareasController.getConsultarPrioridadController();

                //asigno origen de datos
                ddlEstadoTarea.DataSource = dsConsultaEstadoTareas;
                ddlEstadoTarea.DataTextField = "estaDescripcion";//lo que se muestra
                ddlEstadoTarea.DataValueField = "estaCodigo";//lo que equivale
                ddlEstadoTarea.DataBind();//acepte los cambios

                //asigno origen de datos
                ddlPrioridad.DataSource = dsConsultaPrioridad;
                ddlPrioridad.DataTextField = "prioDescripcion";//lo que se muestra
                ddlPrioridad.DataValueField = "prioCodigo";//lo que equivale
                ddlPrioridad.DataBind();//acepte los cambios

                getTareas();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtCodigo.Text)) stMensaje += "Ingrese codigo";

                if (!stMensaje.Equals(string.Empty)) throw new Exception(stMensaje.TrimEnd(','));

                Logica.Models.clsTareas obclsTareas = new Logica.Models.clsTareas
                {
                    inCodigo = Convert.ToInt32(txtCodigo.Text),
                    stTitular = txtTitularTarea.Text,
                    stAsunto = txtAsunto.Text,
                    stFechaVencimiento = txtFechaVencimiento.Text,
                    stContacto = txtContacto.Text,
                    stCuenta = txtCuenta.Text,
                    obclsEstadoTareas = new Logica.Models.clsEstadoTareas
                    {
                        inCodigo = Convert.ToInt32(ddlEstadoTarea.SelectedValue)
                    },
                    obclsPrioridad = new Logica.Models.clsPrioridad
                    {
                        inCodigo = Convert.ToInt32(ddlPrioridad.SelectedValue)
                    },
                    stEnviarMensaje = chkEnviarMensaje.Checked ? "S" : "N",
                    stRepetir = chkRepetir.Checked ? "S" : "N",
                    stDescripcion = txtDescripcion.Text
                };

                Controllers.TareasController obTareasController = new Controllers.TareasController();

                if (string.IsNullOrEmpty(lblOpcion.Text))//adicionar
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obTareasController.addTareasController(obclsTareas) + "','success') </script>");
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obTareasController.updateTareasController(obclsTareas) + "','success') </script>");

                lblOpcion.Text = txtCodigo.Text = txtTitularTarea.Text = txtAsunto.Text = txtFechaVencimiento.Text = txtContacto.Text = txtCuenta.Text = txtDescripcion.Text = string.Empty;
                chkEnviarMensaje.Checked = chkRepetir.Checked = false;

                getTareas();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error','" + ex.Message + "','error') </script>");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblOpcion.Text = txtCodigo.Text = txtTitularTarea.Text = txtAsunto.Text = txtFechaVencimiento.Text = txtContacto.Text = txtCuenta.Text = txtDescripcion.Text = string.Empty;
            chkEnviarMensaje.Checked = chkRepetir.Checked = false;
        }

        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Modificar"))
                {
                    lblOpcion.Text = "M";

                    txtCodigo.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text;
                    txtTitularTarea.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtAsunto.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtFechaVencimiento.Text = gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtContacto.Text = gvwDatos.Rows[inIndice].Cells[4].Text;
                    txtCuenta.Text = gvwDatos.Rows[inIndice].Cells[5].Text;
                    ddlEstadoTarea.SelectedValue = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigoEstadoTarea")).Text;
                    ddlPrioridad.SelectedValue = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigoPrioridad")).Text;
                    chkEnviarMensaje.Checked = gvwDatos.Rows[inIndice].Cells[8].Text.Equals("S") ? true : false;
                    chkRepetir.Checked = gvwDatos.Rows[inIndice].Cells[9].Text.Equals("S") ? true : false;
                    txtDescripcion.Text = gvwDatos.Rows[inIndice].Cells[10].Text;
                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    Logica.Models.clsTareas obclsTareas = new Logica.Models.clsTareas
                    {
                        inCodigo = Convert.ToInt32(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text)
                    };

                    Controllers.TareasController obTareasController = new Controllers.TareasController();
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obTareasController.deleteTareasController(obclsTareas) + "','success') </script>");
                    getTareas();
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error','" + ex.Message + "','error') </script>");
            }
        }

        void getTareas()
        {
            try
            {
                Controllers.TareasController obTareasController = new Controllers.TareasController();
                List<Logica.Models.clsTareas> lstclsTareas = obTareasController.getTareasController();

                if (lstclsTareas.Count > 0) gvwDatos.DataSource = lstclsTareas;
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