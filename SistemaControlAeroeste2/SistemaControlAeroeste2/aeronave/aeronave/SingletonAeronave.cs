using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class SingletonAeronave
    {
        private static FactoriaAeronave factoria = new FactoriaAeronave(new AeroesteContext());


        public static FactoriaAeronave get()
        {
            if (factoria == null)
            {
                factoria = new FactoriaAeronave(new AeroesteContext());
            }
            return factoria;
        }
    }
}
