using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp
{
    internal class PAdministrativo:Persona
    {
        private string cedula;
        public PAdministrativo() : base()
        {
            cedula = string.Empty;
            this.nombre = string.Empty;
            this.app = string.Empty;
            this.apm = string.Empty;
            this.curp = string.Empty;
            this.rfc = string.Empty;
            this.telefono = string.Empty;
            this.email = string.Empty;
            this.calle = string.Empty;
            this.colonia = string.Empty;
            this.ciudad = string.Empty;
            this.estado = string.Empty;
        }

        public string Cedula { get => cedula; set => cedula = value; }
    }
}
