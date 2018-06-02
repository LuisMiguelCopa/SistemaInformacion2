using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class AdaptadorDBAeronave
    {
        public static Aeronave convertirDBNegocio(PersistenciaAeronave dato)
        {
            return new Aeronave(dato.id, dato.idMarcaModelo, dato.idMatricula, dato.serie, dato.att, dato.atc);
        }

        public static List<Aeronave> convertirDBNegocioLista(List<PersistenciaAeronave> datos)
        {
            List<Aeronave> lista = new List<Aeronave>();
            foreach (var item in datos)
            {
                lista.Add(convertirDBNegocio(item));
            }
            return lista;
        }
        public static PersistenciaAeronave convertirNegocioDB(Aeronave negocio)
        {
            return new PersistenciaAeronave(negocio.codigo, negocio.marcamodelo, negocio.matricula, negocio.serie, negocio.att, negocio.atc);
        }

        public static List<PersistenciaAeronave> convertirNegocioDBLista(List<Aeronave> negocio)
        {
            List<PersistenciaAeronave> lista = new List<PersistenciaAeronave>();
            foreach (var item in negocio)
            {
                lista.Add(convertirNegocioDB(item));
            }
            return lista;
        }
    }
}
