using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public partial class FormAeronave : Form
    {
        InterfazAeronave interfaz = new InterfazAeronave();
        public FormAeronave()
        {
            InitializeComponent();
            interfaz.mostrar(dataGridViewAeronave, comboBoxCodigo, comboBoxMarcaModelo, comboBoxMatricula, textBoxSerie, textBoxAtt, textBoxAtc);
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            interfaz.agregarAeronave(comboBoxCodigo, comboBoxMarcaModelo, comboBoxMatricula, textBoxSerie, textBoxAtt, textBoxAtc);
            interfaz.mostrar(dataGridViewAeronave, comboBoxCodigo, comboBoxMarcaModelo, comboBoxMatricula, textBoxSerie, textBoxAtt, textBoxAtc);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            interfaz.guardar();
            interfaz.mostrar(dataGridViewAeronave, comboBoxCodigo, comboBoxMarcaModelo, comboBoxMatricula, textBoxSerie, textBoxAtt, textBoxAtc);
        }
    }
}
