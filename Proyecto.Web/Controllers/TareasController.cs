using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

namespace Proyecto.Web.Controllers
{
    public class TareasController
    {
        /// <summary>
        /// OBTIENE REGISTROS ESTADO TAREAS
        /// </summary>
        /// <returns>DATA ESTADO TAREAS</returns>
        public DataSet getConsultarEstadoTareasController()
        {
            try
            {
                Logica.BL.clsEstadoTarea obclsEstadoTarea = new Logica.BL.clsEstadoTarea();
                return obclsEstadoTarea.getConsultarEstadoTareas();
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// OBTIENE REGISTROS PRIORIDAD
        /// </summary>
        /// <returns>DATA PRIORIDAD</returns>
        public DataSet getConsultarPrioridadController()
        {
            try
            {
                Logica.BL.clsPrioridad obclsPrioridad = new Logica.BL.clsPrioridad();
                return obclsPrioridad.getConsultarPrioridad();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}