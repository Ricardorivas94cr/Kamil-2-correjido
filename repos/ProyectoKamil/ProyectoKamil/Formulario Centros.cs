using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoKamil
{
    public partial class Formulario_Centros : Form
    {
        public Formulario_Centros()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void Formulario_Centros_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            dtGRIDviewCentros.DataSource = Index();
        }

        public DataTable Index()
        {

            Conexion.conectar();
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM  CentroTrabajo";
            SqlCommand cmd = new SqlCommand(sql, Conexion.conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dataTable);
            return dataTable;




        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            Conexion.conectar();
            string actualizar = "UPDATE CentroTrabajo SET noCentro=@noCentro, nombreCentro=@nombreCentro, ciudad=@ciudad WHERE noCentro=@noCentro";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.conectar());

            cmd2.Parameters.AddWithValue("@noCentro", txtboxnumero.Text);
            cmd2.Parameters.AddWithValue("@nombreCentro", txtboxnombre.Text);
            cmd2.Parameters.AddWithValue("@noCentro", txtboxciudad.Text);

        

            MessageBox.Show("Los datos Fueron Modificados con Exito");
       
        }
    }
}
