using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class SingletonMarcaModelo
    {
        private static FactoriaMarcaModelo factoria = new FactoriaMarcaModelo(new AeroesteContext());

        public static FactoriaMarcaModelo get()
        {
            if (factoria == null)
            {
                factoria = new FactoriaMarcaModelo(new AeroesteContext());
            }
            return factoria;
        }

    }
}
