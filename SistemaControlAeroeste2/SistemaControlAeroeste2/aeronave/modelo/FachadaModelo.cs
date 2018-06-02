using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class FachadaModelo
    {
        public static FactoriaModelo getSingletonModelo()
        {
            return SingletonModelo.get();
        }
        public static PersistenciaModelo convertirNegocioDB(Modelo u)
        {
            return AdaptadorDBModelo.convertirNegocioDB(u);
        }
        public static Modelo convertirDBNegocio(PersistenciaModelo p)
        {
            return AdaptadorDBModelo.convertirDBNegocio(p);
        }
    }
}
