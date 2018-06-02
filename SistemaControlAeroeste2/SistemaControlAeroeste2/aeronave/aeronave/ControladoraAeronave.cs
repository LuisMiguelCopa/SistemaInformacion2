using SistemaControlAeroeste2.aeronave.marcamodelo;
using SistemaControlAeroeste2.aeronave.registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class ControladoraAeronave
    {
        public void agregarAeronave(int id, int marcamodelo, int matricula, string serie, double att, int atc)
        {
            /*
            Matricula matriculaaux = new Matricula(id, matricula);
            var x = AdaptadorDBMatricula.convertirNegocioDB(matriculaaux);
            FachadaMatricula.getSingletonMatricula().repositorioMatricula.Add(x);
            FachadaMatricula.getSingletonMatricula().Complete();
            */
            Aeronave aeronave = new Aeronave(id, marcamodelo, matricula, serie, att, atc);

            SingletonAeronave.get().repositorioAeronave.Add(AdaptadorDBAeronave.convertirNegocioDB(aeronave));
        }

        public void guardar()
        {
            SingletonAeronave.get().Complete();
        }

        public void mostrar(DataGridView datos, ComboBox codigo, ComboBox marcamodelo, ComboBox matricula, TextBox serie, TextBox att, TextBox atc)
        {
            datos.DataSource = null;
            datos.Rows.Clear();
            var listaAeronave = SingletonAeronave.get().repositorioAeronave.GetAll().ToList();
            if (listaAeronave.Count() == 0)
            {
                datos.RowCount = 1;
            }
            else
            {
                datos.RowCount = listaAeronave.Count();
            }
            for (int i = 0; i < listaAeronave.Count(); i++)
            {
                datos.Rows[i].Cells[0].Value = listaAeronave.ElementAt(i).id;
                datos.Rows[i].Cells[1].Value = FachadaMarcaModelo.getSingletonMarcaModelo().Get(listaAeronave.ElementAt(i).idMarcaModelo);
                datos.Rows[i].Cells[2].Value = FachadaMatricula.getSingletonMatricula().Get(listaAeronave.ElementAt(i).idMatricula);
                datos.Rows[i].Cells[3].Value = listaAeronave.ElementAt(i).serie;
                datos.Rows[i].Cells[4].Value = listaAeronave.ElementAt(i).att;
                datos.Rows[i].Cells[5].Value = listaAeronave.ElementAt(i).atc;

            }
            codigo.DataSource = null;
            codigo.DisplayMember = "id";
            codigo.ValueMember = "id";
            codigo.DataSource = SingletonAeronave.get().GetAll().ToList();

            marcamodelo.DataSource = null;
            //marcamodelo.DisplayMember = "marcamodelo";
            //marcamodelo.ValueMember = "marcamodelo";
            marcamodelo.DataSource = FachadaMarcaModelo.getSingletonMarcaModelo().GetAll().ToList();

            matricula.DataSource = null;
            //matricula.DisplayMember = "matricula";
            //matricula.ValueMember = "matricula";
            matricula.DataSource = FachadaMatricula.getSingletonMatricula().GetAll().ToList();
            /*
            matricula.DataSource = null;
            matricula.DisplayMember = "serie";
            matricula.ValueMember = "serie";
            matricula.DataSource = SingletonAeronave.get().GetAll().ToList();

            matricula.DataSource = null;
            matricula.DisplayMember = "att";
            matricula.ValueMember = "att";
            matricula.DataSource = SingletonAeronave.get().GetAll().ToList();

            matricula.DataSource = null;
            matricula.DisplayMember = "atc";
            matricula.ValueMember = "atc";
            matricula.DataSource = SingletonAeronave.get().GetAll().ToList();
            */
        }
    }
}
