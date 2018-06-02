using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class MarcaModelo
    {
        public int codigo { get; set; }
        public int marca { get; set; }
        public int modelo { get; set; }

        public MarcaModelo() { }

        public MarcaModelo(int codigo, int marca, int modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
        }

        public override string ToString()
        {
            return FachadaMarca.getSingletonMarca().Get(marca).nombre + "-" + FachadaModelo.getSingletonModelo().Get(modelo).nombre;
        }
    }
}
