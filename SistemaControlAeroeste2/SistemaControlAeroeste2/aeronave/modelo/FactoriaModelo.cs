using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.modelo
{
    public class FactoriaModelo : RepositorioModelo
    {
        private readonly AeroesteContext _context;
        public FactoriaModelo(AeroesteContext context) : base(context)
        {
            _context = context;
            repositorioModelo = new RepositorioModelo(_context);

        }
        public RepositorioModelo repositorioModelo { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
