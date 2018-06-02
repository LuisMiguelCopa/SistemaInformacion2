using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public partial class FormMatricula : Form
    {
        InterfazMatricula interfaz = new InterfazMatricula();
        public FormMatricula()
        {
            InitializeComponent();
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            interfaz.agregarMatricula(comboBoxCodigo, comboBoxNombre);
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfaz.guardar();
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }
    }
}
