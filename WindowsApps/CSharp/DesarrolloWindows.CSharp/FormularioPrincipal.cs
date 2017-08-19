using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesarrolloWindows.CSharp
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
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