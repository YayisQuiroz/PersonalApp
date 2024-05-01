using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PersonalApp
{
    public partial class Modulo_Alumnos : Form
    {
     
        public Modulo_Alumnos()
        {
            InitializeComponent();
            lstAlumno.View = View.Details;
            lstAlumno.Columns.Add("matricula");
            lstAlumno.Columns.Add("nombre");
            lstAlumno.Columns.Add("Ap Paterno");
            lstAlumno.Columns.Add("Ap Materno");
            lstAlumno.Columns.Add("Carrera");

        }



        private void btnAggAlmn_Click(object sender, EventArgs e)
        {
            Informacion_General alumno = new Informacion_General();
            alumno.Show();
        }

        private void Modulo_Alumnos_Load(object sender, EventArgs e)
        {
            poblarListView();
        }

        private void btnAggAlmn_Click_1(object sender, EventArgs e)
        {
            Informacion_General infogeneral = new Informacion_General();

            if (infogeneral.ShowDialog() == DialogResult.OK)
            {
                string informacion = infogeneral.DatosJSON.ToString();
                int I = 0;
                I = Funcionescomunes.ObtieneSiguiente(BaseDatos.Alumno1);
                BaseDatos.Alumno1[I] = new Alumno();
                BaseDatos.Alumno1[I] = (Alumno)JsonConvert.DeserializeObject<Alumno>(informacion);
                Funcionescomunes.CalcularCurp(BaseDatos.Alumno1[I]);
                aggalumno alumno = new aggalumno();
                alumno.ShowDialog();
                poblarListView();
                MessageBox.Show("la informacion se guardo correctamente");

                //frmaggalumno alumno = new frmaggalumno();
            }
        }
        public void poblarListView()
        {
            lstAlumno.Items.Clear();
            foreach(Alumno alumno in BaseDatos.Alumno1)
            {
                if(alumno != null)
                {
                    ListViewItem item = new ListViewItem(alumno.Matricula1.ToString());
                    item.SubItems.Add(alumno.Nombre);
                    item.SubItems.Add(alumno.App);
                    item.SubItems.Add(alumno.Apm);
                    item.SubItems.Add(alumno.Carrera);
                    lstAlumno.Items.Add(item);
                }
            }
        }

        private void btnMdfAlmn_Click(object sender, EventArgs e)
        {
            string matricula = lstAlumno.SelectedItems[0].SubItems[0].Text;
            Informacion_General general = new Informacion_General(matricula);
            if (general.ShowDialog() == DialogResult.OK)
            {

            }
            MessageBox.Show(matricula);

        }

    }
}
