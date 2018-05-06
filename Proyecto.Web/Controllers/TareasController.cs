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

        /// <summary>
        /// ADICIONA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREAS</param>
        /// <returns></returns>
        public string addTareasController(Logica.Models.clsTareas obclsTareasModel)
        {
            try
            {
                Logica.BL.clsTareas obclsTareas = new Logica.BL.clsTareas();
                return obclsTareas.addTareas(obclsTareasModel);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// MODIFICA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREAS</param>
        /// <returns></returns>
        public string updateTareasController(Logica.Models.clsTareas obclsTareasModel)
        {
            try
            {
                Logica.BL.clsTareas obclsTareas = new Logica.BL.clsTareas();
                return obclsTareas.updateTareas(obclsTareasModel);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// ELIMINA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREAS</param>
        /// <returns></returns>
        public string deleteTareasController(Logica.Models.clsTareas obclsTareasModel)
        {
            try
            {
                Logica.BL.clsTareas obclsTareas = new Logica.BL.clsTareas();
                return obclsTareas.deleteTareas(obclsTareasModel);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREAS</param>
        /// <returns></returns>
        public List<Logica.Models.clsTareas> getTareasController(Logica.Models.clsTareas obclsTareasModel)
        {
            try
            {
                Logica.BL.clsTareas obclsTareas = new Logica.BL.clsTareas();
                return obclsTareas.getTareas(obclsTareasModel);
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA TAREAS
        /// </summary>
        /// <returns></returns>
        public List<Logica.Models.clsTareas> getTareasController()
        {
            try
            {
                Logica.BL.clsTareas obclsTareas = new Logica.BL.clsTareas();
                return obclsTareas.getTareas();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}