using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class InterfazMarcaModelo
    {
        ControladoraMarcaModelo controladora = new ControladoraMarcaModelo();
        public InterfazMarcaModelo() { }
        public void agregarMarcaModelo(ComboBox codigo, ComboBox marca, ComboBox modelo)
        {
            controladora.agregarMarcaModelo(int.Parse(codigo.Text), marca.Text, modelo.Text);
        }

        public void guardar()
        {
            controladora.guardar();
        }

        public void mostrar(DataGridView dato, ComboBox codigo, ComboBox marca, ComboBox modelo)
        {
            controladora.mostrar(dato, codigo, marca, modelo);
        }
    }
}
