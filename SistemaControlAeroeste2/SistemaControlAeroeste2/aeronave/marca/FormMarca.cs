using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public partial class FormMarca : Form
    {
        InterfazMarca interfaz = new InterfazMarca();
        public FormMarca()
        {
            InitializeComponent();
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            interfaz.agregarMarca(comboBoxCodigo, comboBoxNombre);
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            interfaz.modificarMarca(comboBoxCodigo, comboBoxNombre);
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            interfaz.eliminarMarca(comboBoxCodigo);
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfaz.guardar();
            interfaz.mostrar(dataGridViewMarca, comboBoxNombre, comboBoxCodigo);
        }

        private void dataGridViewMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewMarca.Rows[index];
            comboBoxCodigo.Text = selectedRow.Cells[0].Value.ToString();
            comboBoxNombre.Text = selectedRow.Cells[1].Value.ToString();
        }
    }
}
