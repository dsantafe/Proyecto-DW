using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.MVC.BL
{
    public class clsTipoIncidencia
    {
        /// <summary>
        /// OBTIENE LOS REGISTROS DE TIPO INCIDENCIA
        /// </summary>
        /// <returns>LISTA DE MODELOS DE TIPO INCIDENCIA</returns>
        public List<Models.TipoIncidencia> GetTipoIncidencia()
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    List<Models.TipoIncidencia> tipo_incidencia = new List<Models.TipoIncidencia>();
                    tipo_incidencia = (from q in obDatos.tipo_incidencia
                                       select new Models.TipoIncidencia
                                       {
                                           Id = q.id,
                                           Descripcion = q.descripcion
                                       }).ToList();

                    return tipo_incidencia;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}