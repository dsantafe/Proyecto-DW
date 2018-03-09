using System;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsPosiblesClientes
    {
        SqlConnection _SqlConnection = null;//me permite establecer comunicacion con BBDD
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar conjunto de datos SQL
        string stConexion = string.Empty;//cadena de conexion

        SqlParameter _SqlParameter = null;

        public clsPosiblesClientes()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// CONSULTA POSIBLES CLIENTES
        /// </summary>
        /// <returns>REGISTROS POSIBLES CLIENTES</returns>
        public DataSet getConsultarPosiblesClientes()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarPosiblesClientes", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;                

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }

        /// <summary>
        /// ADMINISTRAR POSIBLES CLIENTES
        /// </summary>
        /// <param name="obclsPosiblesClientes">OBJETO</param>
        /// <param name="inOpcion">OPCION DE EJECUCION</param>
        /// <returns>MENSAJE DE OPERACION</returns>
        public string setAdministrarPosiblesClientes(Models.clsPosiblesClientes obclsPosiblesClientes, int inOpcion)
        {
            try
            {
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spAdministrarPosiblesClientes", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", obclsPosiblesClientes.lnIdentificacion));
                _SqlCommand.Parameters.Add(new SqlParameter("@cEmpresa", obclsPosiblesClientes.stEmpresa));
                _SqlCommand.Parameters.Add(new SqlParameter("@cPrimerNombre", obclsPosiblesClientes.stPrimerNombre));
                _SqlCommand.Parameters.Add(new SqlParameter("@cSegundoNombre", obclsPosiblesClientes.stSegundoNombre));
                _SqlCommand.Parameters.Add(new SqlParameter("@cPrimerApellido", obclsPosiblesClientes.stPrimerApellido));
                _SqlCommand.Parameters.Add(new SqlParameter("@cSegundoApellido", obclsPosiblesClientes.stSegundoApellido));
                _SqlCommand.Parameters.Add(new SqlParameter("@cDireccion", obclsPosiblesClientes.stDireccion));
                _SqlCommand.Parameters.Add(new SqlParameter("@cTelefono", obclsPosiblesClientes.stTelefono));
                _SqlCommand.Parameters.Add(new SqlParameter("@cCorreo", obclsPosiblesClientes.stCorreo));
                _SqlCommand.Parameters.Add(new SqlParameter("@nOpcion", inOpcion));               

                _SqlParameter = new SqlParameter();
                _SqlParameter.ParameterName = "@cMensaje";
                _SqlParameter.Direction = ParameterDirection.Output;
                _SqlParameter.SqlDbType = SqlDbType.VarChar;
                _SqlParameter.Size = 50;

                _SqlCommand.Parameters.Add(_SqlParameter);
                _SqlCommand.ExecuteNonQuery();

                return _SqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
