using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Proyecto.Test
{
    [TestClass]
    public class clsEventos
    {
        [TestMethod]
        public void createEventosTest()
        {
            //ARRANGE
            wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();

            //ACT
            Logica.Models.clsEventos obclsEventos = new Logica.Models.clsEventos
            {
                DESCRIPCION = "Primer semestre",
                PARTICIPANTES = "David Santafe",
                FECHA = "2018-09-02",
                NOMBRE = "Inducción",
                RELACIONADO_CON = new Logica.Models.clsRelacionadoCon
                {
                    CODIGO = 1
                },
                TODO_DIA = "S",
                UBICACION = "UTAP"
            };

            string json = JsonConvert.SerializeObject(obclsEventos);

            //ASSERT
            obwsServicios.createEventosWS(json);
        }
    }
}
