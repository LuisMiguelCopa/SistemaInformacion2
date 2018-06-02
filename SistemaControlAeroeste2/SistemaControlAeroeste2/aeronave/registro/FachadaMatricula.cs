using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class FachadaMatricula
    {
        public FachadaMatricula()
        {

        }
        public static Matricula convertirDBNegocio(PersistenciaMatricula dato)
        {
            return AdaptadorDBMatricula.convertirDBNegocio(dato);
        }

        public static PersistenciaMatricula convertirNegocioDB(Matricula negocio)
        {
            return AdaptadorDBMatricula.convertirNegocioDB(negocio);
        }

        public static FactoriaMatricula getSingletonMatricula()
        {
            return SingletonMatricula.get();
        }
    }
}
