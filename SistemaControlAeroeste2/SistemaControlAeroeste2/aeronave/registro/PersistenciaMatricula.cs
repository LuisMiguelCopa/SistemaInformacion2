using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    [Table("Matricula")]
    public class PersistenciaMatricula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string matricula { get; set; }

        public PersistenciaMatricula() { }

        public PersistenciaMatricula(int id, string matricula)
        {
            this.id = id;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return matricula;
        }
    }
}
