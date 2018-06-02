using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public partial class FormModelo : Form
    {
        InterfazModelo interfaz = new InterfazModelo();
        public FormModelo()
        {
            InitializeComponent();
            interfaz.mostrar(dataGridViewModelo, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            interfaz.agregarModelo(comboBoxCodigo, comboBoxNombre);
            interfaz.mostrar(dataGridViewModelo, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            interfaz.modificarModelo(comboBoxCodigo, comboBoxNombre);
            interfaz.mostrar(dataGridViewModelo, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            interfaz.eliminarModelo(comboBoxCodigo);
            interfaz.mostrar(dataGridViewModelo, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfaz.guardar();
            interfaz.mostrar(dataGridViewModelo, comboBoxNombre, comboBoxCodigo);
        }
    }
}
