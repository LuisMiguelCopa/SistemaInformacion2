using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    [Table("Modelo")]
    public class PersistenciaModelo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }

        public PersistenciaModelo() { }
        public PersistenciaModelo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
