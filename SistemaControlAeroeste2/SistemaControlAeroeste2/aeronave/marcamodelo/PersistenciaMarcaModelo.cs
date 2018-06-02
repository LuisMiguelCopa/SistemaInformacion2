using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    [Table("MarcaModelo")]
    public class PersistenciaMarcaModelo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }

        public PersistenciaMarcaModelo() { }

        public PersistenciaMarcaModelo(int id, int idMarca, int idModelo)
        {
            this.id = id;
            this.idMarca = idMarca;
            this.idModelo = idModelo;
        }

        public override string ToString()
        {
            return FachadaMarca.getSingletonMarca().Get(idMarca).nombre + "-" + FachadaModelo.getSingletonModelo().Get(idModelo).nombre;
        }
    }
}
