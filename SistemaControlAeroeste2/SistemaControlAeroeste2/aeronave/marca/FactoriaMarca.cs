using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marca
{
    public class FactoriaMarca : RepositorioMarca
    {
        private readonly AeroesteContext _context;
        public FactoriaMarca(AeroesteContext context) : base(context)
        {
            _context = context;
            repositorioMarca = new RepositorioMarca(_context);

        }
        public RepositorioMarca repositorioMarca { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
