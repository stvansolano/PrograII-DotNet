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
using CapaNegocio;

namespace DesarrolloWindows.CSharp
{
    public partial class FormularioPrincipal : Form
    {
        private DataTable _dataTable;

        public void ConectarBaseDeDatos()
        {
            //var cadena = "Server=tcp:sqlprogra2azure.database.windows.net,1433;Initial Catalog=SQLprogra2Azure;Persist Security Info=False;User ID=sqladmin;Password=12345abC;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            var cadena = "Data Source=PANTALLA;Database=CafeteriaProgra2;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

            var conexion = new SqlConnection(cadena);

            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT Nombre, PrimerApellido, Telefono FROM Clientes";

            //Abrir la conexion
            conexion.Open();

            var adaptador = new SqlDataAdapter(comando);

            // Llenado offline con DataTable para uso posterior en 1 sola llamada
            _dataTable = new DataTable();
            adaptador.Fill(_dataTable);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var resultado = lector.GetString(0) + " " + lector.GetString(1);

                Console.WriteLine(resultado);
            }

            lector.Close();
            conexion.Close();
        }

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void CargarInterfazGrafica()
        {
            ListBoxDatos.DisplayMember = "Telefono";
            // ListBoxDatos.DataSource = _dataTable;
            ListBoxDatos.DataSource = CapaNegocio.Cliente.ObtenerClientes(_dataTable);
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void botonConectar_Click(object sender, EventArgs e)
        {
            ConectarBaseDeDatos();

            CargarInterfazGrafica();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventana = new FormularioProductos();

            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;
            ventana.Location = new Point(300, 0);

            ventana.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventana = new FormularioClientes();

            ventana.Location = new Point(0, 300);
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            ventana.Show();
        }
    }
}
