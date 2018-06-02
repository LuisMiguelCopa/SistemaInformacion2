using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class ControladoraMarca
    {
        public void agregarMarca(int id, string nombre)
        {
            Marca marca = new Marca(id, nombre);
            SingletonMarca.get().Add(AdaptadorDBMarca.convertirNegocioDB(marca));
        }
        public void guardar()
        {
            SingletonMarca.get().Complete();
        }
        public List<Marca> mostrar()
        {
            List<Marca> listaMarca = new List<Marca>();
            listaMarca = AdaptadorDBMarca.convertirDBNegocioLista(SingletonMarca.get().GetAll().ToList());
            return listaMarca;
        }
        public void modificarMarca(int id, string nombre)
        {

            Marca marca = new Marca(id, nombre);
            var persistencia = SingletonMarca.get().Get(id);
            persistencia.nombre = nombre;
            SingletonMarca.get().Complete();

        }
        public void eliminarMarca(int id)
        {
            var x = SingletonMarca.get().Get(id);
            SingletonMarca.get().Remove(x);

        }
    }
}
