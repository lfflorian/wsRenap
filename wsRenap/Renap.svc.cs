﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wsRenap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Renap" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Renap.svc o Renap.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Renap : IRenap
    {
        public Renap()
        {
        }
        
        public void EsMayorDeEdad(string dpi)
        {
            throw new NotImplementedException();
        }
        
        public void EstadoPersona(string dpi)
        {
            throw new NotImplementedException();
        }
        
        public void TieneArraigo(string dpi)
        {
            throw new NotImplementedException();
        }
        
        public void VigenciaDeDPI(string dpi)
        {
            throw new NotImplementedException();
        }
    }
}
