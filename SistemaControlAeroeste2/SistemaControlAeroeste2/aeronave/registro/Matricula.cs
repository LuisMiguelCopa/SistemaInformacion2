using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class Matricula
    {
        public int codigo { get; set; }
        public string matricula { get; set; }

        public Matricula() { }

        public Matricula(int codigo, string matricula)
        {
            this.codigo = codigo;
            this.matricula = matricula;
        }
        /*
        public bool verificarMatricula(string matricula)
        {
            if (matricula.Contains("CP-") && matricula.Length < 8)
            {
                return true;
            }
            return false;
        }
        */
        public override string ToString()
        {
            return matricula;
        }
    }
}
