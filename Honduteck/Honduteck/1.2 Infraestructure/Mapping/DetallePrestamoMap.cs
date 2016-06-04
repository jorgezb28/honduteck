using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Honduteck.Models;

namespace Honduteck._1._2_Infraestructure.Mapping
{
    public class DetallePrestamoMap : EntityTypeConfiguration<PrestamoDetalle>
    {
        public DetallePrestamoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CodigoPrestamo, t.PeriodoId });

            // Properties
            this.Property(t => t.CodigoPrestamo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PeriodoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PrestamoDetalle");
            this.Property(t => t.CodigoPrestamo).HasColumnName("CodigoPrestamo");
            this.Property(t => t.PeriodoId).HasColumnName("PeriodoId");
            this.Property(t => t.CuotaPeriodo).HasColumnName("CuotaPeriodo");
            this.Property(t => t.SaldoPendiente).HasColumnName("SaldoPendiente");
            this.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");

            // Relationships
            this.HasRequired(t => t.Prestamo)
                .WithMany(t => t.DetallePrestamoes)
                .HasForeignKey(d => d.CodigoPrestamo);

        }
    }
}
