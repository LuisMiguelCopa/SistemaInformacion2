using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.aeronave
{
    public class FactoriaAeronave : RepositorioAeronave
    {
        private readonly AeroesteContext _context;
        public FactoriaAeronave(AeroesteContext context) : base(context)
        {
            _context = context;
            repositorioAeronave = new RepositorioAeronave(_context);

        }
        public RepositorioAeronave repositorioAeronave { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
