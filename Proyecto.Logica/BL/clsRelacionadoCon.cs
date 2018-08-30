using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class clsRelacionadoCon
    {
        public List<Models.clsRelacionadoCon> getRelacionadoCon()
        {
            try
            {
                using (Entidades.bdGeneralEntities obDatos = new Entidades.bdGeneralEntities())
                {
                    List<Models.clsRelacionadoCon> lstclsRelacionadoCon = (from q in obDatos.tbRelacionadoCon
                                                                           select new Models.clsRelacionadoCon
                                                                           {
                                                                               CODIGO = q.recoCodigo,
                                                                               DESCRIPCION = q.recoDescripcion
                                                                           }).ToList();
                    return lstclsRelacionadoCon;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
