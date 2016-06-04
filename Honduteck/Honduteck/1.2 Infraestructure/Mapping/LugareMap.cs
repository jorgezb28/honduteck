using System.Data.Entity.ModelConfiguration;
using Honduteck.Models;

namespace Honduteck._1._2_Infraestructure.Mapping
{
    public class LugareMap : EntityTypeConfiguration<Lugares>
    {
        public LugareMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoLugar);

            // Properties
            this.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.OficialEncargado)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Lugares");
            this.Property(t => t.CodigoLugar).HasColumnName("CodigoLugar");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.OficialEncargado).HasColumnName("OficialEncargado");
            this.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");
        }
    }
}
