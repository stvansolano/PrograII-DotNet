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

            ventana.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventana = new FormularioClientes();
            ventana.MdiParent = this;

            ventana.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}