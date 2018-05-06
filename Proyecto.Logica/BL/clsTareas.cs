using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class clsTareas
    {
        /// <summary>
        /// ADICIONA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREAS</param>
        /// <returns></returns>
        public string addTareas(Models.clsTareas obclsTareas)
        {
            try
            {
                using (Entidades.bdGeneralEntities obbdGeneralEntities = new Entidades.bdGeneralEntities())
                {
                    Entidades.tbTareas obtbTareas = new Entidades.tbTareas
                    {
                        tareCodigo = obclsTareas.inCodigo,
                        tareTitular = obclsTareas.stTitular,
                        tareAsunto = obclsTareas.stAsunto,
                        tareFechaVencimiento = obclsTareas.stFechaVencimiento,
                        tareContacto = obclsTareas.stContacto,
                        tareCuenta = obclsTareas.stCuenta,
                        estaCodigo = obclsTareas.obclsEstadoTareas.inCodigo,
                        prioCodigo = obclsTareas.obclsPrioridad.inCodigo,
                        tareEnviarMensaje = obclsTareas.stEnviarMensaje,
                        tareRepetir = obclsTareas.stRepetir,
                        tareDescripcion = obclsTareas.stDescripcion
                    };

                    obbdGeneralEntities.tbTareas.Add(obtbTareas);
                    obbdGeneralEntities.SaveChanges();

                    return "Se realizo proceso con exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// MODIFICA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public string updateTareas(Models.clsTareas obclsTareas)
        {
            try
            {
                using (Entidades.bdGeneralEntities obbdGeneralEntities = new Entidades.bdGeneralEntities())
                {
                    Entidades.tbTareas obtbTareas = (from q in obbdGeneralEntities.tbTareas
                                                     where q.tareCodigo == obclsTareas.inCodigo
                                                     select q).FirstOrDefault();

                    obtbTareas.tareTitular = obclsTareas.stTitular;
                    obtbTareas.tareAsunto = obclsTareas.stAsunto;
                    obtbTareas.tareFechaVencimiento = obclsTareas.stFechaVencimiento;
                    obtbTareas.tareContacto = obclsTareas.stContacto;
                    obtbTareas.tareCuenta = obclsTareas.stCuenta;
                    obtbTareas.estaCodigo = obclsTareas.obclsEstadoTareas.inCodigo;
                    obtbTareas.prioCodigo = obclsTareas.obclsPrioridad.inCodigo;
                    obtbTareas.tareEnviarMensaje = obclsTareas.stEnviarMensaje;
                    obtbTareas.tareRepetir = obclsTareas.stRepetir;
                    obtbTareas.tareDescripcion = obclsTareas.stDescripcion;

                    obbdGeneralEntities.SaveChanges();

                    return "Se realizo proceso con exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// ELIMINA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public string deleteTareas(Models.clsTareas obclsTareas)
        {
            try
            {
                using (Entidades.bdGeneralEntities obbdGeneralEntities = new Entidades.bdGeneralEntities())
                {
                    Entidades.tbTareas obtbTareas = (from q in obbdGeneralEntities.tbTareas
                                                     where q.tareCodigo == obclsTareas.inCodigo
                                                     select q).FirstOrDefault();

                    obbdGeneralEntities.tbTareas.Remove(obtbTareas);
                    obbdGeneralEntities.SaveChanges();

                    return "Se realizo proceso con exito";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA TODAS LAS TAREAS
        /// </summary>
        /// <returns></returns>
        public List<Models.clsTareas> getTareas()
        {
            try
            {
                using (Entidades.bdGeneralEntities obbdGeneralEntities = new Entidades.bdGeneralEntities())
                {
                    return (from q in obbdGeneralEntities.tbTareas
                            join tbET in obbdGeneralEntities.tbEstadoTareas on q.estaCodigo equals tbET.estaCodigo
                            join tbP in obbdGeneralEntities.tbPrioridad on q.prioCodigo equals tbP.prioCodigo
                            select new Models.clsTareas
                            {
                                inCodigo = q.tareCodigo,
                                stTitular = q.tareTitular,
                                stAsunto = q.tareAsunto,
                                stFechaVencimiento = q.tareFechaVencimiento,
                                stContacto = q.tareContacto,
                                stCuenta = q.tareCuenta,
                                obclsEstadoTareas = new Models.clsEstadoTareas
                                {
                                    inCodigo = q.estaCodigo,
                                    stDescripcion = tbET.estaDescripcion
                                },
                                obclsPrioridad = new Models.clsPrioridad
                                {
                                    inCodigo = q.prioCodigo,
                                    stDescripcion = tbP.prioDescripcion
                                },
                                stEnviarMensaje = q.tareEnviarMensaje,
                                stRepetir = q.tareRepetir,
                                stDescripcion = q.tareDescripcion
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CONSULTA UNA TAREA
        /// </summary>
        /// <param name="obclsTareas">MODELO DE TAREA</param>
        /// <returns></returns>
        public List<Models.clsTareas> getTareas(Models.clsTareas obclsTareas)
        {
            try
            {
                using (Entidades.bdGeneralEntities obbdGeneralEntities = new Entidades.bdGeneralEntities())
                {
                    return (from q in obbdGeneralEntities.tbTareas
                            join tbET in obbdGeneralEntities.tbEstadoTareas on q.estaCodigo equals tbET.estaCodigo
                            join tbP in obbdGeneralEntities.tbPrioridad on q.prioCodigo equals tbP.prioCodigo
                            where q.tareCodigo == obclsTareas.inCodigo
                            select new Models.clsTareas
                            {
                                inCodigo = q.tareCodigo,
                                stTitular = q.tareTitular,
                                stAsunto = q.tareAsunto,
                                stFechaVencimiento = q.tareFechaVencimiento,
                                stContacto = q.tareContacto,
                                stCuenta = q.tareCuenta,
                                obclsEstadoTareas = new Models.clsEstadoTareas
                                {
                                    inCodigo = q.estaCodigo,
                                    stDescripcion = tbET.estaDescripcion
                                },
                                obclsPrioridad = new Models.clsPrioridad
                                {
                                    inCodigo = q.prioCodigo,
                                    stDescripcion = tbP.prioDescripcion
                                },
                                stEnviarMensaje = q.tareEnviarMensaje,
                                stRepetir = q.tareRepetir,
                                stDescripcion = q.tareDescripcion
                            }).ToList();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
