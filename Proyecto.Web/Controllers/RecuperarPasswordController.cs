using System;

using System.Data;

namespace Proyecto.Web.Controllers
{
    public class RecuperarPasswordController
    {
        public DataSet getConsultaPasswordController(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.clsRecuperarPassword obclsRecuperarPassword = new Logica.BL.clsRecuperarPassword();
                return obclsRecuperarPassword.getConsultaPassword(obclsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }

        public void setEmailController(Logica.Models.clsCorreo obclsCorreo)
        {
            try
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                obclsGeneral.setEmail(obclsCorreo);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}