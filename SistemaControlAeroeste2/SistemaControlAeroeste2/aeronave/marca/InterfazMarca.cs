using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class InterfazMarca
    {
        ControladoraMarca controladora = new ControladoraMarca();

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
            grilla.Columns[1].HeaderCell.Value = "Marca";
        }
        public void agregarMarca(ComboBox codigo, ComboBox nombre)
        {
            controladora.agregarMarca(int.Parse(codigo.Text), nombre.Text);
        }
        public void guardar()
        {
            controladora.guardar();
        }
        public void modificarMarca(ComboBox codigo, ComboBox nombre)
        {
            controladora.modificarMarca(int.Parse(codigo.Text), nombre.Text);
        }

        public void eliminarMarca(ComboBox codigo)
        {
            controladora.eliminarMarca(int.Parse(codigo.Text));
        }
    }
}
