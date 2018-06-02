using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class AdaptadorDBMatricula
    {
        public static Matricula convertirDBNegocio(PersistenciaMatricula dato)
        {
            return new Matricula(dato.id, dato.matricula);
        }

        public static List<Matricula> convertirDBNegocioLista(List<PersistenciaMatricula> datos)
        {
            List<Matricula> lista = new List<Matricula>();
            foreach (var item in datos)
            {
                lista.Add(convertirDBNegocio(item));
            }
            return lista;
        }
        public static PersistenciaMatricula convertirNegocioDB(Matricula negocio)
        {
            return new PersistenciaMatricula(negocio.codigo, negocio.matricula);
        }

        public static List<PersistenciaMatricula> convertirNegocioDBLista(List<Matricula> negocio)
        {
            List<PersistenciaMatricula> lista = new List<PersistenciaMatricula>();
            foreach (var item in negocio)
            {
                lista.Add(convertirNegocioDB(item));
            }
            return lista;
        }
    }
}
