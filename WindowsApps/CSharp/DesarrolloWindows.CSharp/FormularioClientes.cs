using CapaDatos;
using CapaNegocio;
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

namespace DesarrolloWindows.CSharp
{
    public partial class FormularioClientes : Form
    {
        private DataTable _dataTable;
        
        public FormularioClientes()
        {
            InitializeComponent();
        }

        public void ConectarBaseDeDatos()
        {
            var cadena = ContextoDatos.CADENA_CONEXION;
            
            var conexion = new SqlConnection(cadena);
            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT Nombre, PrimerApellido, SegundoApellido, Telefono FROM Clientes";

            //Abrir la conexion
            conexion.Open();

            var adaptador = new SqlDataAdapter(comando);

            // Llenado offline con DataTable para uso posterior en 1 sola llamada
            _dataTable = new DataTable();
            adaptador.Fill(_dataTable);

            conexion.Close();
        }

        private void CargarInterfazGrafica()
        {
            // ListBoxDatos.DataSource = _dataTable;

            dataGridView1.DataSource = Cliente.ObtenerClientes(_dataTable);
        }
        
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            ConectarBaseDeDatos();
            CargarInterfazGrafica();
        }
        
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            GuardarRegistro();

            ConectarBaseDeDatos();
            CargarInterfazGrafica();
        }

        private void GuardarRegistro()
        {
            var sql = "INSERT INTO Clientes (Nombre, PrimerApellido, SegundoApellido, Telefono) VALUES ";
            sql += "('" + textBoxNombre.Text + "',";
            sql += "'" + textBoxPrimerApellido.Text + "',";
            sql += "'" + textBoxSegundoApellido.Text + "',";
            sql += "'" + textBoxTelefono.Text + "')";

            var cadena = ContextoDatos.CADENA_CONEXION;
            var conexion = new SqlConnection(cadena);
            var comando = conexion.CreateCommand();

            comando.CommandText = sql;

            conexion.Open();

            comando.ExecuteScalar();
            conexion.Close();
        }
    }
}
