using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Renap" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Renap.svc o Renap.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Renap : IRenap
    {
        RenapEntities1 dbContext;
        public Renap()
        {
            dbContext = new RenapEntities1();
        }

        public string EsMayorDeEdad(string dpi)
        {
            int iDpi = Int32.Parse(dpi);
            Persona hola = new Persona();
            RenapEntities1 ren = new RenapEntities1();

            try
            {
                using (ren)
                {
                    hola = ren.Personas.First(i => i.IdDocumento == iDpi);
                }
            }
            catch (Exception)
            {

                return "No encontrado";
            }
            
            var fechaResultado = DateTime.Now - hola.FechaNacimiento;
            var edad = fechaResultado.Value.Days / 365;
            var mayordeEdad = (edad >= 18) ? "si" : "no";

            XElement Respuesta = new XElement("Respuesta",
                    new XElement("Nombre", hola.Nombre),
                    new XElement("FechaNacimiento", hola.FechaNacimiento),
                    new XElement("Edad", edad.ToString()),
                    new XElement("MayordeEdad", mayordeEdad)
                );

            return Respuesta.ToString();
        }

        public string EstadoPersona(string dpi)
        {
            throw new NotImplementedException();
        }

        public string TieneArraigo(string dpi)
        {
            throw new NotImplementedException();
        }

        public string VigenciaDeDPI(string dpi)
        {
            throw new NotImplementedException();
        }
    }
}
