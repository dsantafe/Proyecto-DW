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
    }
}
