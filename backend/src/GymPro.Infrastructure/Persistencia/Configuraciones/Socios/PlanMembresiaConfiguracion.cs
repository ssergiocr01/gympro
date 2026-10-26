using GymPro.Domain.Entidades.Socios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Socios;

public class PlanMembresiaConfiguracion : ConfiguracionEntidadBase<PlanMembresia>
{
    protected override void ConfigurarEntidad(EntityTypeBuilder<PlanMembresia> builder)
    {
        builder.ToTable("PlanMembresia");

        builder.Property(p => p.Nombre).HasMaxLength(100);
        builder.Property(p => p.Descripcion).HasMaxLength(500);

        builder.HasIndex(p => p.Nombre).IsUnique();
    }
}