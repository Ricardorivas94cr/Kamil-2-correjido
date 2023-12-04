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

namespace ProyectoKamil
{
    public partial class Formulario_Directivos : Form
    {
        public Formulario_Directivos()
        {
            InitializeComponent();
        }

        private void Formulario_Directivos_Load(object sender, EventArgs e)
        {
            Conexion.conectar();
            dtGRIDViewDirectivos.DataSource = Index();
        }

        public DataTable Index()
        {

            Conexion.conectar();
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM  Directivos";
            SqlCommand cmd = new SqlCommand(sql, Conexion.conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dataTable);
            return dataTable;




        }

    }
}
