using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuPOO2023.Datos
{
    public class ManejadorArchivoXml : IArchivo
    {
        private readonly string _archivo = "Billetera.xml";
        private readonly string _ruta = AppDomain.CurrentDomain.BaseDirectory;

        private readonly string _rutaArchivo;
        public ManejadorArchivoXml()
        {
            _rutaArchivo = Path.Combine(_ruta, _archivo);
        }


        public void GuardarMonedas(List<Moneda> monedas)
        {
            try
            {
                XmlSeñalizador señal = new XmlSeñalizador(typeof(List<Moneda>));
                using (StreamWriter sw = new StreamWriter(_rutaArchivo))
                {
                    señal.Señalizadpr(sw, monedas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar en el archivo: {ex.Message}");
            }


        }
    }
}
