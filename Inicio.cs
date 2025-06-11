using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1_PAvanzada
{
    public partial class Inicio : Form
    {
        private readonly frmSuplidores _frmSuplidores;
        private readonly frmCategorias _frmCategorias;
        private readonly frmProductos _frmProductos;
        public Inicio(frmSuplidores frmSuplidores, frmCategorias frmCategorias, frmProductos frmProductos)
        {
            InitializeComponent();
            _frmSuplidores = frmSuplidores;
            _frmCategorias = frmCategorias;
            _frmProductos = frmProductos;
        }

        private void gestionarSuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmSuplidores.ShowDialog();
        }

        private void gestionarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmCategorias.ShowDialog();

        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmProductos.ShowDialog();
        }
    }
}
