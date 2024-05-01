using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonalApp
{
    internal class Alumno:Persona
    {
        #region varibles
        private string matricula; 
        private string[] actividadAprendizaje, cargaAcademica;
        private double[] promedio, evaluacion, calificacion;
        private int semestre;
        private string carrera;
        #endregion
        #region propiedades

        public Alumno() : base()
        {
            matricula = string.Empty;
            carrera = string.Empty;
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
        public string Matricula1 { get => matricula; set => matricula = value; }
        public string[] ActividadAprendizaje { get => actividadAprendizaje; set => actividadAprendizaje = value; }
        public string[] CargaAcademica { get => cargaAcademica; set => cargaAcademica = value; }
        public double[] Promedio { get => promedio; set => promedio = value; }
        public double[] Evaluacion { get => evaluacion; set => evaluacion = value; }
        public double[] Calificacion { get => calificacion; set => calificacion = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        #endregion
        #region metodos
        public string BuscarPorMatricula(string matricula)
        {
            string resultado = " ";
            foreach(Alumno alumno in BaseDatos.Alumno1)
            {
                if(alumno != null)
                {
                    if (alumno.matricula == matricula)
                    {
                        resultado = jsonConvert.s
                    }
                }
            }
            return resultado
        }

        #endregion
    }
}
