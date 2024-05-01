using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp
{
    internal class BaseDatos
    {
        private static Alumno[] alumno;

        internal static Alumno[] Alumno1 { get => alumno; set => alumno = value; }

        public static void inicializarBD()
        {
            alumno = new Alumno[100];

        }
    }
}
