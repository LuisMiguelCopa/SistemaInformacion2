using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public partial class FormMarcaModelo : Form
    {
        InterfazMarcaModelo interfaz = new InterfazMarcaModelo();
        public FormMarcaModelo()
        {
            InitializeComponent();
            interfaz.mostrar(dataGridViewMarcaModelo, comboBoxCodigo, comboBoxMarca, comboBoxModelo);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            interfaz.agregarMarcaModelo(comboBoxCodigo, comboBoxMarca, comboBoxModelo);
            interfaz.mostrar(dataGridViewMarcaModelo, comboBoxCodigo, comboBoxMarca, comboBoxModelo);
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
            interfaz.mostrar(dataGridViewMarcaModelo, comboBoxCodigo, comboBoxMarca, comboBoxModelo);
        }
    }
}
