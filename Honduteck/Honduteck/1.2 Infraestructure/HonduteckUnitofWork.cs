using System.Data.Entity;
using Honduteck.Models;
using Honduteck._1._2_Infraestructure.Mapping;

namespace Honduteck._1._2_Infraestructure
{
    public partial class HonduteckUnitofWork : DbContext
    {
        static HonduteckUnitofWork()
        {
            Database.SetInitializer<HonduteckUnitofWork>(null);
        }

        public HonduteckUnitofWork()
            : base("Name=HONDUTECKContext")
        {
        }

        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<PrestamoDetalle> DetallePrestamoes { get; set; }
        public IDbSet<Lugares> Lugares { get; set; }
        public IDbSet<Prestamo> Prestamoes { get; set; }
        public IDbSet<TipoCliente> TipoClientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new DetallePrestamoMap());
            modelBuilder.Configurations.Add(new LugareMap());
            modelBuilder.Configurations.Add(new PrestamoMap());
            modelBuilder.Configurations.Add(new TipoClienteMap());
        }

        public virtual void Commit()
        {
            SaveChanges();
        }

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
