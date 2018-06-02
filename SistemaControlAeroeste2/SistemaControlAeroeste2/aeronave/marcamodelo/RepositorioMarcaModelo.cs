using SistemaControlAeroeste2.servicio;
using SistemaControlAeroeste2.servicio.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class RepositorioMarcaModelo : Repositorio<PersistenciaMarcaModelo>
    {
        public RepositorioMarcaModelo(AeroesteContext context) : base(context)
        {

        }

        public AeroesteContext aeroesteContext
        {
            get { return Context as AeroesteContext; }
        }

    }
}
