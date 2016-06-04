using System.Data.Entity.ModelConfiguration;
using Honduteck.Models;

namespace Honduteck._1._2_Infraestructure.Mapping
{
    public class TipoClienteMap : EntityTypeConfiguration<TipoCliente>
    {
        public TipoClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoTipo);

            // Properties
            this.Property(t => t.CodigoTipo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TipoCliente");
            this.Property(t => t.CodigoTipo).HasColumnName("CodigoTipo");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");
        }
    }
}
