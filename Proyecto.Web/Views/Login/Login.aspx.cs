using System;
using System.Web;

namespace Proyecto.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //la primera vez que carga la pagina
            if (!IsPostBack)
            {
                if (Request.Cookies["cookieEmail"] != null)
                    txtEmail.Text = Request.Cookies["cookieEmail"].Value.ToString();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese password,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //defino objeto con propiedades
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text,
                    stPassword = txtPassword.Text
                };

                //instancio controlador
                Controllers.LoginController obLoginController = new Controllers.LoginController();
                bool blBandera = obLoginController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                {
                    Session["sessionEmail"] = txtEmail.Text;

                    if (chkRecordar.Checked)
                    {
                        //creo un objeto cookie
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        //adiciono el tiempo de vida
                        cookie.Expires = DateTime.Now.AddDays(2);
                        //agrego a la coleccion de cookies
                        Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        //expira el dia de ayer
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }

                    Response.Redirect("../Index/Index.aspx?stEmail=" + txtEmail.Text);//redirecciono
                }
                else
                    throw new Exception("Usuario o password incorrectos");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}