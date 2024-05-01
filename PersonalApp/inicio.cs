using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalApp
{
    public partial class inicio : Form
    {
        public static int identificador = 0;
        public inicio()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            identificador = 1;
            Modulo_Alumnos alumno = new Modulo_Alumnos();
            alumno.Show();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            identificador = 2;
            Modulo_Docente docente = new Modulo_Docente();
            docente.Show();
        }

        private void btnSecretarios_Click(object sender, EventArgs e)
        {
            identificador = 3;

        }

        private void btnPAdministrativo_Click(object sender, EventArgs e)
        {
            identificador = 4;

        }

        private void btnJardineros_Click(object sender, EventArgs e)
        {
            identificador = 5;

        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            identificador = 6;

        }
    }
}
