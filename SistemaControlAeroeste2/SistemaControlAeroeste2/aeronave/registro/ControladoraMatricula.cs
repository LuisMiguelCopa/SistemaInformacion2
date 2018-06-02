using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class ControladoraMatricula
    {
        public void agregarMatricula(int id, string nombre)
        {
            Matricula matricula = new Matricula(id, nombre);
            SingletonMatricula.get().Add(AdaptadorDBMatricula.convertirNegocioDB(matricula));
        }
        public void guardar()
        {
            SingletonMatricula.get().Complete();
        }
        public List<Matricula> mostrar()
        {
            List<Matricula> listaMatricula = new List<Matricula>();
            listaMatricula = AdaptadorDBMatricula.convertirDBNegocioLista(SingletonMatricula.get().GetAll().ToList());
            return listaMatricula;
        }
        public void modificarMatricula(int id, string nombre)
        {

            Matricula matricula = new Matricula(id, nombre);
            var persistencia = SingletonMatricula.get().Get(id);
            persistencia.matricula = nombre;
            SingletonMatricula.get().Complete();

        }
        public void eliminarMatricula(int id)
        {
            var x = SingletonMatricula.get().Get(id);
            SingletonMatricula.get().Remove(x);

        }
    }
}
