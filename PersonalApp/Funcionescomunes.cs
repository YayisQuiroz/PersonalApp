using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp
{
    public static class Funcionescomunes
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
        public static int ObtieneSiguiente(object[] arreglo)
        {
            int I = 0;

            for (I = 0; I < arreglo.Length; I++)
            {
                if (arreglo[I] == null)
                    break;
            }
            return I;
        }
        public static void CalcularCurp(Persona persona)
        {
            persona.Curp = "";
            persona.Curp = persona.App.Substring(0,2);
            persona.Curp += persona.Apm.Substring(0, 1);
            persona.Curp += persona.Nombre.Substring(0, 1);


        }

    }
}
