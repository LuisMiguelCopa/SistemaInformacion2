using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class Marca
    {
        public int codigo { get; set; }
        public string nombre { get; set; }

        public Marca() { }

        public Marca(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
