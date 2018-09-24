using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.MVC.BL
{
    public class clsEstadoIncidencia
    {
        /// <summary>
        /// OBTIENE LOS REGISTROS DE ESTADO INCIDENCIA
        /// </summary>
        /// <returns>LISTA DE MODELOS DE ESTADO INCIDENCIA</returns>
        public List<Models.EstadoIncidencia> GetEstadoIncidencia()
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    List<Models.EstadoIncidencia> estado_incidencia = new List<Models.EstadoIncidencia>();
                    estado_incidencia = (from q in obDatos.estado_incidencia
                                         select new Models.EstadoIncidencia
                                         {
                                             Id = q.id,
                                             Descripcion = q.descripcion
                                         }).ToList();

                    return estado_incidencia;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// OBTIENE LOS REGISTROS DE ESTADO INCIDENCIA
        /// </summary>
        /// <returns>LISTA DE MODELOS DE ESTADO INCIDENCIA</returns>
        public List<Models.EstadoIncidencia> GetEstadoIncidencia(Models.EstadoIncidencia obEstadoIncidencia)
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    List<Models.EstadoIncidencia> estado_incidencia = new List<Models.EstadoIncidencia>();
                    estado_incidencia = (from q in obDatos.estado_incidencia
                                         where q.id == obEstadoIncidencia.Id
                                         select new Models.EstadoIncidencia
                                         {
                                             Id = q.id,
                                             Descripcion = q.descripcion
                                         }).ToList();

                    return estado_incidencia;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// CREA REGISTRO DE ESTADO INCIDENCIA
        /// </summary>
        /// <param name="obEstadoIncidencia">MODELO DE ESTADO INCIDENCIA</param>
        public void CreateEstadoIncidencia(Models.EstadoIncidencia obEstadoIncidencia)
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    obDatos.estado_incidencia.Add(new DAL.estado_incidencia
                    {
                        descripcion = obEstadoIncidencia.Descripcion
                    });
                    obDatos.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// MODIFICAR REGISTRO DE ESTADO INCIDENCIA
        /// </summary>
        /// <param name="obEstadoIncidencia">MODELO DE ESTADO INCIDENCIA</param>
        public void UpdateEstadoIncidencia(Models.EstadoIncidencia obEstadoIncidencia)
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    DAL.estado_incidencia estado_incidencia = new DAL.estado_incidencia();
                    estado_incidencia = (from q in obDatos.estado_incidencia
                                         where q.id == obEstadoIncidencia.Id
                                         select q).FirstOrDefault();

                    estado_incidencia.descripcion = obEstadoIncidencia.Descripcion;

                    obDatos.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// ELIMINAR REGISTRO DE ESTADO INCIDENCIA
        /// </summary>
        /// <param name="obEstadoIncidencia">MODELO DE ESTADO INCIDENCIA</param>
        public void DeleteEstadoIncidencia(Models.EstadoIncidencia obEstadoIncidencia)
        {
            try
            {
                using (DAL.bdGeneralEntities obDatos = new DAL.bdGeneralEntities())
                {
                    DAL.estado_incidencia estado_incidencia = new DAL.estado_incidencia();
                    estado_incidencia = (from q in obDatos.estado_incidencia
                                         where q.id == obEstadoIncidencia.Id
                                         select q).FirstOrDefault();

                    obDatos.estado_incidencia.Remove(estado_incidencia);
                    obDatos.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}