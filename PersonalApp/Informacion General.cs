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
    public partial class Informacion_General : Form
    {
        private Persona persona;
        private string datosCSV;
        public string datosJSON;

        public Informacion_General()
        {
            InitializeComponent();
            persona = new Persona();

        }
        public Informacion_General(string matricula)
        {
            InitializeComponent();
            Alumno alumno = new Alumno();
            datosJSON = BaseDatos.Alumno1[0].BuscarPorMatricula(matricula);
            alumno = jsonConvert.DeserializeObject<Alumno>(datosJSON);
            txtnombre.Text = alumno.Nombre;
            txtapp.Text = alumno.App;
            txtapm.Text = alumno.Apm;


        }

        public string DatosCSV { get => datosCSV; set => datosCSV = value; }
        public string DatosJSON { get => datosJSON; set => datosJSON = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            datosJSON = "{";
            datosJSON += "\"nombre\":\"" + txtnombre.Text + "\",";
            datosJSON += "\"apellidopaterno\":\"" + txtapp.Text + "\","; 
            datosJSON += "\"apellidomaterno\":\"" + txtapm.Text + "\",";
            datosJSON += "\"estado\":\"" + txtestado.Text + "\",";
            datosJSON += "\"Telefono\":\"" + txttelefono.Text + "\",";
            datosJSON += "\"calle\":\"" + txtcalle.Text + "\",";
            datosJSON += "\"colonia\":\"" + txtcolonia.Text + "\",";
            datosJSON += "\"ciudad\":\"" + txtciudad.Text + "\",";
            datosJSON += "}";
            MessageBox.Show("la informacion se guardo correctamente");


        }
    }
}
