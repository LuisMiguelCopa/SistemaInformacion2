using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class ControladoraMarcaModelo
    {
        public void agregarMarcaModelo(int id, string marca, string modelo)
        {
            int idmarca = FachadaMarca.getSingletonMarca().SingleOrDefault(u => u.nombre == marca).id;
            int idmodelo = FachadaModelo.getSingletonModelo().SingleOrDefault(u => u.nombre == modelo).id;
            MarcaModelo marcamodelo = new MarcaModelo(id, idmarca, idmodelo);
            SingletonMarcaModelo.get().repositorioMarcaModelo.Add(AdaptadorDBMarcaModelo.convertirNegocioDB(marcamodelo));
        }

        public void guardar()
        {
            SingletonMarcaModelo.get().Complete();
        }

        public void mostrar(DataGridView datos, ComboBox codigo, ComboBox marca, ComboBox modelo)
        {

            var listaMarcaModelo = SingletonMarcaModelo.get().repositorioMarcaModelo.GetAll().ToList();

            if (listaMarcaModelo.Count() == 0)
            {
                datos.RowCount = 1;
            }
            else
            {
                datos.RowCount = listaMarcaModelo.Count();
            }
            for (int i = 0; i < listaMarcaModelo.Count(); i++)
            {
                datos.Rows[i].Cells[0].Value = listaMarcaModelo.ElementAt(i).id;
                datos.Rows[i].Cells[1].Value = FachadaMarca.getSingletonMarca().Get(listaMarcaModelo.ElementAt(i).idMarca).nombre;
                datos.Rows[i].Cells[2].Value = FachadaModelo.getSingletonModelo().Get(listaMarcaModelo.ElementAt(i).idModelo).nombre;
            }

            codigo.DataSource = null;
            codigo.DisplayMember = "id";
            codigo.ValueMember = "id";
            codigo.DataSource = SingletonMarcaModelo.get().GetAll().ToList();

            marca.DataSource = null;
            marca.DisplayMember = "nombre";
            marca.ValueMember = "nombre";
            marca.DataSource = FachadaMarca.getSingletonMarca().GetAll().ToList();

            modelo.DataSource = null;
            modelo.DisplayMember = "nombre";
            modelo.ValueMember = "nombre";
            modelo.DataSource = FachadaModelo.getSingletonModelo().GetAll().ToList();

        }
    }
}
