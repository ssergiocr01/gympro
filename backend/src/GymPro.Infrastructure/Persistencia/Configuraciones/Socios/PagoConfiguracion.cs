using GymPro.Domain.Entidades.Socios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Socios;

public class PagoConfiguracion : ConfiguracionEntidadBase<Pago>
{
    protected override void ConfigurarEntidad(EntityTypeBuilder<Pago> builder)
    {
        builder.ToTable("Pago");

        builder.Property(p => p.Referencia).HasMaxLength(100);
        builder.Property(p => p.Observaciones).HasMaxLength(500);

        builder.HasOne(p => p.Membresia)
               .WithMany(m => m.Pagos)
               .HasForeignKey(p => p.MembresiaId)
               .OnDelete(DeleteBehavior.Restrict);

        // Reportes de ingresos por rango de fechas
        builder.HasIndex(p => p.FechaPago);
    }
}