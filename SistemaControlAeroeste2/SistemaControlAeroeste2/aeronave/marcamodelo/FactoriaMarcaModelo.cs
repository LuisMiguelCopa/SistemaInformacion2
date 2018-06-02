using SistemaControlAeroeste2.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.aeronave.marcamodelo
{
    public class FactoriaMarcaModelo : RepositorioMarcaModelo
    {
        private readonly AeroesteContext _context;
        public FactoriaMarcaModelo(AeroesteContext context) : base(context)
        {
            _context = context;
            repositorioMarcaModelo = new RepositorioMarcaModelo(_context);
        }
        public RepositorioMarcaModelo repositorioMarcaModelo { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
