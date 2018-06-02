using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class AdaptadorDBModelo
    {
        public static Modelo convertirDBNegocio(PersistenciaModelo dato)
        {
            return new Modelo(dato.id, dato.nombre);
        }


        public static List<Modelo> convertirDBNegocioLista(List<PersistenciaModelo> datos)
        {
            List<Modelo> lista = new List<Modelo>();
            foreach (var item in datos)
            {
                lista.Add(convertirDBNegocio(item));
            }
            return lista;
        }


        public static PersistenciaModelo convertirNegocioDB(Modelo negocio)
        {
            return new PersistenciaModelo(negocio.codigo, negocio.nombre);
        }

        public static List<PersistenciaModelo> convertirNegocioDBLista(List<Modelo> negocio)
        {
            List<PersistenciaModelo> lista = new List<PersistenciaModelo>();
            foreach (var item in negocio)
            {
                lista.Add(convertirNegocioDB(item));
            }
            return lista;
        }
    }
}
