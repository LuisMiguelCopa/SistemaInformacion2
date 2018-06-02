using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class FachadaMarca
    {
        public static FactoriaMarca getSingletonMarca()
        {
            return SingletonMarca.get();
        }
        public static PersistenciaMarca convertirNegocioDB(Marca u)
        {
            return AdaptadorDBMarca.convertirNegocioDB(u);
        }
        public static Marca convertirDBNegocio(PersistenciaMarca p)
        {
            return AdaptadorDBMarca.convertirDBNegocio(p);
        }
    }
}
