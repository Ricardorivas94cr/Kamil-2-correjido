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
    public partial class Formulario_Empleados : Form
    {
        public Formulario_Empleados()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void Formulario_Empleados_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            dtGRIDviewEmpleados.DataSource = Index();
        }

        public DataTable Index()
        {

            Conexion.conectar();
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM  Empleados";
            SqlCommand cmd = new SqlCommand(sql, Conexion.conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dataTable);
            return dataTable;




        }
    }
}
