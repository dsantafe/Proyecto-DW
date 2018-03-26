using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsRecuperarPassword
    {
        SqlConnection _SqlConnection = null;//me permite establecer comunicacion con BBDD
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar conjunto de datos SQL
        string stConexion = string.Empty;//cadena de conexion

        SqlParameter _SqlParameter = null;

        public clsRecuperarPassword()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// CONSULTA PASSWORD
        /// </summary>
        /// <returns>REGISTROS USUARIO</returns>
        public DataSet getConsultaPassword(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarPassword", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cLogin", obclsUsuarios.stLogin));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
