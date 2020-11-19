using System;
using System.Collections.Generic;
using System.Text;

namespace NETCOREM1_Consola
{
    public class Persona
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }

        public Persona()
        {

        }

        public Persona(string perDNI, string perNombre, int perTelefono)
        {
            this.DNI = perDNI;
            this.Nombre = perNombre;
            this.Telefono = perTelefono;
        }

    }
}
