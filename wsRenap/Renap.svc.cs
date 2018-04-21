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

        public Persona BuscarPersona(string dpi)
        {
            Persona persona = new Persona();
            Documento documento = new Documento();

            try
            {
                using (dbContext)
                {
                    documento = dbContext.Documentoes.First(d => d.numeroDPI == dpi);
                    persona = dbContext.Personas.First(i => i.IdDocumento == documento.IdDocumento);
                }
            }
            catch (Exception es)
            {
                //return "No encontrado";
            }

            return persona;
        }

        public string EsMayorDeEdad(string dpi)
        {
            Persona persona = BuscarPersona(dpi);

            var fechaResultado = DateTime.Now - persona.FechaNacimiento;
            var edad = fechaResultado.Value.Days / 365;
            var mayordeEdad = (edad >= 18) ? "si" : "no";

            XElement Respuesta = new XElement("Respuesta",
                    new XElement("Nombre", persona.Nombre),
                    new XElement("FechaNacimiento", persona.FechaNacimiento),
                    new XElement("Edad", edad.ToString()),
                    new XElement("MayordeEdad", mayordeEdad)
                );

            return Respuesta.ToString();
        }

        public string EstadoPersona(string dpi)
        {
            Persona persona = BuscarPersona(dpi);
            if (persona.FechaDeceso != null)
            {
                return "Esta muerto";
            } else
            {
                return "Esta Vivo";
            }
        }

        public string TieneArraigo(string dpi)
        {
            Persona persona = BuscarPersona(dpi);

            if (persona.PensiónAlimenticia == null)
            {
                return "No tiene pension";
            } else
            {
                return "Tiene pension";
            }
        }

        public string VigenciaDeDPI(string dpi)
        {
            Documento documento = new Documento();
            documento = dbContext.Documentoes.First(d => d.numeroDPI == dpi);

            if (documento.fechaVencimiento < DateTime.Now)
            {
                return "Vencido";
            } else
            {
                return "Vigente";
            }
        }
    }
}
