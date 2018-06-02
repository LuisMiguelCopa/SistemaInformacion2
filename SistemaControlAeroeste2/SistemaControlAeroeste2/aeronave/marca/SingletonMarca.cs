using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class SingletonMarca
    {
        private static FactoriaMarca factoria = new FactoriaMarca(new AeroesteContext());


        public static FactoriaMarca get()
        {
            if (factoria == null)
            {
                factoria = new FactoriaMarca(new AeroesteContext());
            }
            return factoria;
        }
    }
}
