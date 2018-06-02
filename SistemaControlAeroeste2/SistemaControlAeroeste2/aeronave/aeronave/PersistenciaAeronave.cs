using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    [Table("Aeronave")]
    public class PersistenciaAeronave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public int idMarcaModelo { get; set; }
        public int idMatricula { get; set; }
        public string serie { get; set; }
        public double att { get; set; }
        public int atc { get; set; }

        public PersistenciaAeronave() { }

        public PersistenciaAeronave(int codigo, int idMarcaModelo, int idMatricula, string serie, double att, int atc)
        {
            this.id = codigo;
            this.idMarcaModelo = idMarcaModelo;
            this.idMatricula = idMatricula;
            this.serie = serie;
            this.att = att;
            this.atc = atc;
        }
    }
}
