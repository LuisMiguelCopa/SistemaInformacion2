using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class InterfazModelo
    {
        ControladoraModelo controladora = new ControladoraModelo();

        public void mostrar(DataGridView grilla, ComboBox nombre, ComboBox codigo)
        {
            grilla.DataSource = null;
            grilla.DataSource = controladora.mostrar();
            nombre.DataSource = null;
            nombre.DataSource = controladora.mostrar();
            nombre.DisplayMember = "nombre";
            nombre.ValueMember = "nombre";
            codigo.DataSource = null;
            codigo.DataSource = controladora.mostrar();
            codigo.DisplayMember = "codigo";
            codigo.ValueMember = "codigo";
            grilla.Columns[0].HeaderCell.Value = "Codigo";
            grilla.Columns[1].HeaderCell.Value = "Modelo";
        }
        public void agregarModelo(ComboBox codigo, ComboBox nombre)
        {
            controladora.agregarModelo(int.Parse(codigo.Text), nombre.Text);
        }
        public void guardar()
        {
            controladora.guardar();
        }
        public void modificarModelo(ComboBox codigo, ComboBox nombre)
        {
            controladora.modificarModelo(int.Parse(codigo.Text), nombre.Text);
        }

        public void eliminarModelo(ComboBox codigo)
        {
            controladora.eliminarModelo(int.Parse(codigo.Text));
        }
    }
}
