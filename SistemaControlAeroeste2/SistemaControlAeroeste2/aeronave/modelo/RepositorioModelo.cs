using SistemaControlAeroeste2.servicio;
using SistemaControlAeroeste2.servicio.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class RepositorioModelo : Repositorio<PersistenciaModelo>
    {
        public RepositorioModelo(AeroesteContext context) : base(context)
        {


        }

        public AeroesteContext aeroesteContext
        {
            get { return Context as AeroesteContext; }
        }
    }
}
