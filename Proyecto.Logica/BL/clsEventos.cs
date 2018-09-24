using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class clsEventos
    {
        public List<Models.clsEventos> getEventos()
        {
            try
            {
                using (Entidades.bdGeneralEntities obDatos = new Entidades.bdGeneralEntities())
                {
                    List<Models.clsEventos> lstclsEventos = (from q in obDatos.tbEventos
                                                             join tbRC in obDatos.tbRelacionadoCon on q.recoCodigo equals tbRC.recoCodigo
                                                             select new Models.clsEventos
                                                             {
                                                                 CODIGO = q.evenCodigo,
                                                                 DESCRIPCION = q.evenDescripcion,
                                                                 FECHA = q.evenFecha,
                                                                 NOMBRE = q.evenNombre,
                                                                 PARTICIPANTES = q.evenParticipantes,
                                                                 RELACIONADO_CON = new Models.clsRelacionadoCon
                                                                 {
                                                                     CODIGO = (int)q.recoCodigo,
                                                                     DESCRIPCION = tbRC.recoDescripcion
                                                                 },
                                                                 TODO_DIA = q.evenTodoDia.Equals("S") ? "SI" : "NO",
                                                                 UBICACION = q.evenUbicacion
                                                             }).ToList();
                    return lstclsEventos;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void createEventos(Models.clsEventos obclsEventos)
        {
            try
            {
                using (Entidades.bdGeneralEntities obDatos = new Entidades.bdGeneralEntities())
                {
                    obDatos.tbEventos.Add(new Entidades.tbEventos
                    {
                        evenDescripcion = obclsEventos.DESCRIPCION,
                        evenFecha = obclsEventos.FECHA,
                        evenNombre = obclsEventos.NOMBRE,
                        evenParticipantes = obclsEventos.PARTICIPANTES,
                        evenTodoDia = obclsEventos.TODO_DIA,
                        evenUbicacion = obclsEventos.UBICACION,
                        recoCodigo = obclsEventos.RELACIONADO_CON.CODIGO                        
                    });
                    obDatos.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
