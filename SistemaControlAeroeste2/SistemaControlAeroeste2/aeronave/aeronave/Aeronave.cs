using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class Aeronave
    {
        public int codigo { get; set; }
        public int marcamodelo { get; set; }
        public int matricula { get; set; }
        public string serie { get; set; }
        public double att { get; set; }
        public int atc { get; set; }

        public Aeronave() { }

        public Aeronave(int codigo, int marcamodelo, int matricula, string serie, double att, int atc)
        {
            this.codigo = codigo;
            this.marcamodelo = marcamodelo;
            this.matricula = matricula;
            this.serie = serie;
            this.att = att;
            this.atc = atc;
        }
    }
}
