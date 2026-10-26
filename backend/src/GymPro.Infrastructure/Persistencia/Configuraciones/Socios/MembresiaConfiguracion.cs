using GymPro.Domain.Entidades.Socios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Socios;

public class MembresiaConfiguracion : ConfiguracionEntidadBase<Membresia>
{
    protected override void ConfigurarEntidad(EntityTypeBuilder<Membresia> builder)
    {
        builder.ToTable("Membresia");

        builder.HasOne(m => m.Socio)
               .WithMany(s => s.Membresias)
               .HasForeignKey(m => m.SocioId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(m => m.PlanMembresia)
               .WithMany()
               .HasForeignKey(m => m.PlanMembresiaId)
               .OnDelete(DeleteBehavior.Restrict);

        // Consulta frecuente: membresías de un socio ordenadas por vencimiento
        builder.HasIndex(m => new { m.SocioId, m.FechaFin });
    }
}