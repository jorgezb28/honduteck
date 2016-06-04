using System.Data.Entity.ModelConfiguration;
using Honduteck.Models;

namespace Honduteck._1._2_Infraestructure.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoCliente);

            // Properties
            this.Property(t => t.CodigoCliente)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.NombreCliente)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CuentaBarcaria)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TipoCliente)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Banco)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Clientes");
            this.Property(t => t.CodigoCliente).HasColumnName("CodigoCliente");
            this.Property(t => t.NombreCliente).HasColumnName("NombreCliente");
            this.Property(t => t.CuentaBarcaria).HasColumnName("CuentaBarcaria");
            this.Property(t => t.Lugar).HasColumnName("Lugar");
            this.Property(t => t.TipoCliente).HasColumnName("TipoCliente");
            this.Property(t => t.Banco).HasColumnName("Banco");
            this.Property(t => t.FechaTransaccion).HasColumnName("FechaTransaccion");

            // Relationships
            this.HasRequired(t => t.Lugares)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.Lugar);
            this.HasRequired(t => t.TipoCliente1)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.TipoCliente);

        }
    }
}
