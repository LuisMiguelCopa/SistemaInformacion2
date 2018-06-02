using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class SingletonMatricula
    {
        private static FactoriaMatricula factoria = new FactoriaMatricula(new AeroesteContext());


        public static FactoriaMatricula get()
        {
            if (factoria == null)
            {
                factoria = new FactoriaMatricula(new AeroesteContext());
            }
            return factoria;
        }
    }
}
