using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class AdaptadorDBMarca
    {

        public static Marca convertirDBNegocio(PersistenciaMarca dato)
        {
            return new Marca(dato.id, dato.nombre);
        }

        public static List<Marca> convertirDBNegocioLista(List<PersistenciaMarca> datos)
        {
            List<Marca> lista = new List<Marca>();
            foreach (var item in datos)
            {
                lista.Add(convertirDBNegocio(item));
            }
            return lista;
        }

        public static PersistenciaMarca convertirNegocioDB(Marca negocio)
        {
            return new PersistenciaMarca(negocio.codigo, negocio.nombre);
        }

        public static List<PersistenciaMarca> convertirNegocioDBLista(List<Marca> negocio)
        {
            List<PersistenciaMarca> lista = new List<PersistenciaMarca>();
            foreach (var item in negocio)
            {
                lista.Add(convertirNegocioDB(item));
            }
            return lista;
        }
    }
}
