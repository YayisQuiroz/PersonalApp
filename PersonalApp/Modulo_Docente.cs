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
    public partial class Modulo_Docente : Form
    {
        public Modulo_Docente()
        {
            InitializeComponent();
        }

        private void btnAggDct_Click(object sender, EventArgs e)
        {
            Informacion_General docente = new Informacion_General();
            docente.Show();
        }
    }
}
