using System.Data.Entity.ModelConfiguration;
using Honduteck.Models;

namespace Honduteck._1._2_Infraestructure.Mapping
{
    public class PrestamoMap : EntityTypeConfiguration<Prestamo>
    {
        public PrestamoMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoPrestamo);

            // Properties
            this.Property(t => t.CodigoCliente)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Prestamo");
            this.Property(t => t.CodigoPrestamo).HasColumnName("CodigoPrestamo");
            this.Property(t => t.CodigoCliente).HasColumnName("CodigoCliente");
            this.Property(t => t.Monto).HasColumnName("Monto");
            this.Property(t => t.FechaSolicitud).HasColumnName("FechaSolicitud");
            this.Property(t => t.FechaAcreditacion).HasColumnName("FechaAcreditacion");
            this.Property(t => t.NoQuincenas).HasColumnName("NoQuincenas");
            this.Property(t => t.EstaAcreditado).HasColumnName("EstaAcreditado");
            this.Property(t => t.Activo).HasColumnName("Activo");
            this.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");

            // Relationships
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.Prestamoes)
                .HasForeignKey(d => d.CodigoCliente);

        }
    }
}
