using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRenap" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRenap
    {
        [OperationContract]
        void TieneArraigo(string dpi);

        [OperationContract]
        void EsMayorDeEdad(string dpi);

        [OperationContract]
        void EstadoPersona(string dpi);

        [OperationContract]
        void VigenciaDeDPI(string dpi);
    }
}
