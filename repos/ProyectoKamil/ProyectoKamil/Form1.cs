using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnagregaremp_Click(object sender, EventArgs e)
        {
            Form alta_empleados = new Formulario_Empleados();
            alta_empleados.Show();
        }

        private void btnagregardirectivos_Click(object sender, EventArgs e)
        {
            Form alta_directivos = new Formulario_Directivos();
            alta_directivos.Show();
        }

        private void btnagregarcentros_Click(object sender, EventArgs e)
        {
            Form alta_centros = new Formulario_Centros();
            alta_centros.Show();
        }
    }
}
