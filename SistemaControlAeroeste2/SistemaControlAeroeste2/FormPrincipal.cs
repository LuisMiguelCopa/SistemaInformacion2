using SistemaControlAeroeste2.aeronave.aeronave;
using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.marcamodelo;
using SistemaControlAeroeste2.aeronave.modelo;
using SistemaControlAeroeste2.aeronave.registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormMarca();
            f.Show();
        }

        private void gestionarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormModelo();
            f.Show();
        }

        private void gestionarMarcaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormMarcaModelo();
            f.Show();
        }

        private void gestionarRegistroAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormMatricula();
            f.Show();
        }

        private void gestionarAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAeronave();
            f.Show();
        }
    }
}
