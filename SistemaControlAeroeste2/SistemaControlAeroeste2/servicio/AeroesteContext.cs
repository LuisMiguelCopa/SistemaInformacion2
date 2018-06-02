using SistemaControlAeroeste2.aeronave.aeronave;
using SistemaControlAeroeste2.aeronave.marca;
using SistemaControlAeroeste2.aeronave.marcamodelo;
using SistemaControlAeroeste2.aeronave.modelo;
using SistemaControlAeroeste2.aeronave.registro;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlAeroeste2.servicio
{
    public partial class AeroesteContext : DbContext
    {
        public AeroesteContext() : base("name = AeroesteContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CreateDatabaseIfNotExists<AeroesteContext>());
        }
       
        public virtual DbSet<PersistenciaMarca> marca { get; set; }
        public virtual DbSet<PersistenciaModelo> modelo { get; set; }
        public virtual DbSet<PersistenciaMarcaModelo> marcamodelo { get; set; }
        public virtual DbSet<PersistenciaMatricula> matricula { get; set; }
        public virtual DbSet<PersistenciaAeronave> aeronove { get; set; }
        /*
        public virtual DbSet<PersistenciaServicio> servicio { get; set; }
        */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AeroesteContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
