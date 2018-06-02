using SistemaControlAeroeste2.servicio;
using SistemaControlAeroeste2.servicio.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class RepositorioMatricula : Repositorio<PersistenciaMatricula>
    {
        public RepositorioMatricula(AeroesteContext context) : base(context)
        {

        }

        public AeroesteContext aeronaveContext
        {
            get { return Context as AeroesteContext; }
        }
    }
}
