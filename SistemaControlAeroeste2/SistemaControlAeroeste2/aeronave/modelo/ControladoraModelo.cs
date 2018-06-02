using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class ControladoraModelo
    {
        public void agregarModelo(int id, string nombre)
        {
            Modelo modelo = new Modelo(id, nombre);
            SingletonModelo.get().Add(AdaptadorDBModelo.convertirNegocioDB(modelo));
        }
        public void guardar()
        {
            SingletonModelo.get().Complete();
        }
        public List<Modelo> mostrar()
        {
            List<Modelo> listaModelo = new List<Modelo>();
            listaModelo = AdaptadorDBModelo.convertirDBNegocioLista(SingletonModelo.get().GetAll().ToList());
            return listaModelo;
        }
        public void modificarModelo(int id, string nombre)
        {

            Modelo modelo = new Modelo(id, nombre);
            var persistencia = SingletonModelo.get().Get(id);
            persistencia.nombre = nombre;
            SingletonModelo.get().Complete();

        }
        public void eliminarModelo(int id)
        {
            var x = SingletonModelo.get().Get(id);
            SingletonModelo.get().Remove(x);

        }
    }
}
