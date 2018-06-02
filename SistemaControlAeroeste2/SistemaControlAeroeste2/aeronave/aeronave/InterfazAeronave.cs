using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class InterfazAeronave
    {
        ControladoraAeronave controladora = new ControladoraAeronave();
        public InterfazAeronave()
        {

        }
        public void agregarAeronave(ComboBox codigo, ComboBox marcamodelo, ComboBox matricula, TextBox serie, TextBox att, TextBox atc)
        {
            controladora.agregarAeronave(int.Parse(codigo.Text), int.Parse(marcamodelo.Text), int.Parse(matricula.Text), serie.Text, double.Parse(att.Text), int.Parse(atc.Text));
        }
        public void guardar()
        {
            controladora.guardar();
        }
        public void mostrar(DataGridView dato, ComboBox codigo, ComboBox marcamodelo, ComboBox matricula, TextBox serie, TextBox att, TextBox atc)
        {
            controladora.mostrar(dato, codigo, marcamodelo, matricula, serie, att, atc);
        }
    }
}
