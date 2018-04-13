using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.CrearCuenta
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Controllers.CrearCuentaController obCrearCuentaController = new Controllers.CrearCuentaController();

                //VALIDAMOS LA SELECCION DE UNA IMAGEN
                if (fuImagen.HasFile)
                {
                    if (!Path.GetExtension(fuImagen.FileName).Equals(".jpg"))
                        throw new Exception("Solo se admiten formatos .JPG");

                    string stRuta = Server.MapPath(@"~\tmp\") + fuImagen.FileName;//RUTA TEMPORAL
                    fuImagen.PostedFile.SaveAs(stRuta);//GUARDANDO EL ARCHIVO DENTRO DEL PROYECTO

                    string stRutaDestino = Server.MapPath(@"~\Images\") + txtLogin.Text + Path.GetExtension(fuImagen.FileName);//RUTA DESTINO

                    if (File.Exists(stRutaDestino))
                    {
                        File.SetAttributes(stRutaDestino, FileAttributes.Normal);
                        File.Delete(stRutaDestino);
                    }

                    File.Copy(stRuta, stRutaDestino);
                    File.SetAttributes(stRuta, FileAttributes.Normal);
                    File.Delete(stRuta);

                    Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                    {
                        stLogin = txtLogin.Text,
                        stPassword = txtPassword.Text,
                        stImagen = stRutaDestino
                    };

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obCrearCuentaController.setCrearCuentaController(obclsUsuarios, 1) + "!', 'success') </script>");                    
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}