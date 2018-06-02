using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class SingletonModelo
    {
        private static FactoriaModelo factoria = new FactoriaModelo(new AeroesteContext());


        public static FactoriaModelo get()
        {
            if (factoria == null)
            {
                factoria = new FactoriaModelo(new AeroesteContext());
            }
            return factoria;
        }
    }
}
