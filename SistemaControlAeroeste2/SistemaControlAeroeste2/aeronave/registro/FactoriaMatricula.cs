using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.registro
{
    public class FactoriaMatricula : RepositorioMatricula
    {
        private readonly AeroesteContext _context;
        public FactoriaMatricula(AeroesteContext context) : base(context)
        {
            _context = context;
            repositorioMatricula = new RepositorioMatricula(_context);

        }
        public RepositorioMatricula repositorioMatricula { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
