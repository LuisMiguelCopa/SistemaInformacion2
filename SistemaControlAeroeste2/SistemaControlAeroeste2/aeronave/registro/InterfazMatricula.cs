using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class InterfazMatricula
    {
        ControladoraMatricula controladora = new ControladoraMatricula();

        public void mostrar(DataGridView grilla, ComboBox nombre, ComboBox codigo)
        {
            grilla.DataSource = null;
            grilla.DataSource = controladora.mostrar();
            nombre.DataSource = null;
            nombre.DataSource = controladora.mostrar();
            nombre.DisplayMember = "matricula";
            nombre.ValueMember = "matricula";
            codigo.DataSource = null;
            codigo.DataSource = controladora.mostrar();
            codigo.DisplayMember = "codigo";
            codigo.ValueMember = "codigo";
            grilla.Columns[0].HeaderCell.Value = "Codigo";
            grilla.Columns[1].HeaderCell.Value = "Matricula";
        }
        public void agregarMatricula(ComboBox codigo, ComboBox nombre)
        {
            controladora.agregarMatricula(int.Parse(codigo.Text), nombre.Text);
        }
        public void guardar()
        {
            controladora.guardar();
        }
        public void modificarMatricula(ComboBox codigo, ComboBox nombre)
        {
            controladora.modificarMatricula(int.Parse(codigo.Text), nombre.Text);
        }

        public void eliminarMatricula(ComboBox codigo)
        {
            controladora.eliminarMatricula(int.Parse(codigo.Text));
        }
    }
}
