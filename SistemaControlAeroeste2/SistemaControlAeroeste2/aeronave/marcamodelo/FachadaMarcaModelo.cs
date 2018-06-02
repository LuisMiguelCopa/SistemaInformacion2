using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class FachadaMarcaModelo
    {
        public FachadaMarcaModelo()
        {

        }

        public static MarcaModelo convertirDBNegocio(PersistenciaMarcaModelo dato)
        {
            return AdaptadorDBMarcaModelo.convertirDBNegocio(dato);
        }

        public static PersistenciaMarcaModelo convertirNegocioDB(MarcaModelo negocio)
        {
            return AdaptadorDBMarcaModelo.convertirNegocioDB(negocio);
        }

        public static FactoriaMarcaModelo getSingletonMarcaModelo()
        {
            return SingletonMarcaModelo.get();
        }
        // no se si sirve
        public string getMarcaModelo(PersistenciaMarcaModelo dato)
        {
            string marca = FachadaMarca.getSingletonMarca().Get(dato.idMarca).nombre;
            string modelo = FachadaModelo.getSingletonModelo().Get(dato.idModelo).nombre;
            string aux;
            aux = marca + "-" + modelo;
            return aux;
        }
    }
}
