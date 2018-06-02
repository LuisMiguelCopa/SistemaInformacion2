using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class AdaptadorDBMarcaModelo
    {
        public static MarcaModelo convertirDBNegocio(PersistenciaMarcaModelo dato)
        {
            return new MarcaModelo(dato.id, dato.idMarca, dato.idModelo);
        }

        public static List<MarcaModelo> convertirDBNegocioLista(List<PersistenciaMarcaModelo> datos)
        {
            List<MarcaModelo> lista = new List<MarcaModelo>();
            foreach (var item in datos)
            {
                lista.Add(convertirDBNegocio(item));
            }
            return lista;
        }

        public static PersistenciaMarcaModelo convertirNegocioDB(MarcaModelo negocio)
        {
            return new PersistenciaMarcaModelo(negocio.codigo, negocio.marca, negocio.modelo);
        }

        public static List<PersistenciaMarcaModelo> convertirNegocioDBLista(List<MarcaModelo> negocio)
        {
            List<PersistenciaMarcaModelo> lista = new List<PersistenciaMarcaModelo>();
            foreach (var item in negocio)
            {
                lista.Add(convertirNegocioDB(item));
            }
            return lista;
        }
    }
}
