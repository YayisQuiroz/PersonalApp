using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp
{
    internal class Persona
    {
        protected string nombre, app, apm, curp, rfc, telefono, email, calle, colonia, ciudad, estado;
        private bool genero;
        private DateTime fechaNacimiento;
        public Persona()
        {
            nombre = string.Empty;
            app = string.Empty;
            apm = string.Empty;
            curp = string.Empty;
            rfc = string.Empty;
            telefono = string.Empty;
            email = string.Empty;
            calle = string.Empty;
            colonia = string.Empty;
            ciudad = string.Empty;
            estado = string.Empty;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string App { get => app; set => app = value; }
        public string Apm { get => apm; set => apm = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Genero { get => genero; set => genero = value; }
        public DateTime FechaNcacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
