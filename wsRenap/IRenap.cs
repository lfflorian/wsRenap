using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRenap" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRenap
    {
        [OperationContract]
        string TieneArraigo(string dpi);

        [OperationContract]
        string EsMayorDeEdad(string dpi);

        [OperationContract]
        string EstadoPersona(string dpi);

        [OperationContract]
        string VigenciaDeDPI(string dpi);
    }
}
