using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.MVC.BL
{
    public class clsIncidencia
    {
        public List<Models.Incidencia> GetIncidencias()
        {
            try
            {
                using (var db = new DAL.bdGeneralEntities())
                {
                    var result = (from q in db.incidencia
                                  join tbEI in db.estado_incidencia on q.estado_incidencia_id equals tbEI.id
                                  join tbTI in db.tipo_incidencia on q.tipo_incidencia_id equals tbTI.id
                                  select new Models.Incidencia
                                  {
                                      Id = q.id,
                                      Identificacion = (long)q.identificacion,
                                      PrimerNombre = q.primer_nombre,
                                      SegundoNombre = q.segundo_nombre,
                                      PrimerApellido = q.primer_apellido,
                                      SegundoApellido = q.segundo_apellido,
                                      Direccion = q.direccion,
                                      Telefono = q.telefono,
                                      Correo = q.correo,
                                      EstadoIncidencia = new Models.EstadoIncidencia
                                      {
                                          Id = (int)q.estado_incidencia_id,
                                          Descripcion = tbEI.descripcion
                                      },
                                      TipoIncidencia = new Models.TipoIncidencia
                                      {
                                          Id = (int)q.tipo_incidencia_id,
                                          Descripcion = tbTI.descripcion
                                      }
                                  }).ToList();

                    return result;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Models.Incidencia> GetIncidencias(int Id)
        {
            try
            {
                using (var db = new DAL.bdGeneralEntities())
                {
                    var result = (from q in db.incidencia
                                  join tbEI in db.estado_incidencia on q.estado_incidencia_id equals tbEI.id
                                  join tbTI in db.tipo_incidencia on q.tipo_incidencia_id equals tbTI.id
                                  where q.id == Id
                                  select new Models.Incidencia
                                  {
                                      Id = q.id,
                                      Identificacion = (long)q.identificacion,
                                      PrimerNombre = q.primer_nombre,
                                      SegundoNombre = q.segundo_nombre,
                                      PrimerApellido = q.primer_apellido,
                                      SegundoApellido = q.segundo_apellido,
                                      Direccion = q.direccion,
                                      Telefono = q.telefono,
                                      Correo = q.correo,
                                      EstadoIncidencia = new Models.EstadoIncidencia
                                      {
                                          Id = (int)q.estado_incidencia_id,
                                          Descripcion = tbEI.descripcion
                                      },
                                      TipoIncidencia = new Models.TipoIncidencia
                                      {
                                          Id = (int)q.tipo_incidencia_id,
                                          Descripcion = tbTI.descripcion
                                      }
                                  }).ToList();

                    return result;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void CreateIncidencia(Models.Incidencia incidencia)
        {
            try
            {
                using (var db = new DAL.bdGeneralEntities())
                {
                    db.incidencia.Add(new DAL.incidencia
                    {
                        identificacion = incidencia.Identificacion,
                        primer_nombre = incidencia.PrimerNombre,
                        segundo_nombre = incidencia.SegundoNombre,
                        primer_apellido = incidencia.PrimerApellido,
                        segundo_apellido = incidencia.SegundoApellido,
                        direccion = incidencia.Direccion,
                        telefono = incidencia.Telefono,
                        correo = incidencia.Correo,
                        estado_incidencia_id = incidencia.EstadoIncidencia.Id,
                        tipo_incidencia_id = incidencia.TipoIncidencia.Id
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}