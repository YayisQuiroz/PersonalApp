using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApp
{
    public partial class aggalumno : Form
    {
        int i = 0;
        public aggalumno()
        {
            InitializeComponent();
        }

        private void btnagregaralmno_Click(object sender, EventArgs e)
        {
            BaseDatos.Alumno1[i].Matricula1 = txtmatricula.Text;
            BaseDatos.Alumno1[i].Carrera = txtcarrera.Text;
            BaseDatos.Alumno1[i].CargaAcademica = txtcargaacademica.Text.Split(".");

        }

        private void aggalumno_Load(object sender, EventArgs e)
        {
            i = Funcionescomunes.ObtieneSiguiente(BaseDatos.Alumno1) - 1;
            lb1Nombre.Text = BaseDatos.Alumno1[i].Nombre + "" + BaseDatos.Alumno1[i].App+""+ BaseDatos.Alumno1[i].Apm + "";

        }
    }
}
