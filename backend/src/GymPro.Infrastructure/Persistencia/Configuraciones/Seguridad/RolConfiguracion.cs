using GymPro.Domain.Constantes;
using GymPro.Domain.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Seguridad;

public class RolConfiguracion : ConfiguracionEntidadBase<Rol>
{
    // Fecha fija: si se usara DateTime.UtcNow, cada migración nueva
    // detectaría un "cambio" en los datos sembrados.
    private static readonly DateTime FechaSemilla = new(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    protected override void ConfigurarEntidad(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol");

        builder.Property(r => r.Nombre).HasMaxLength(50);
        builder.HasIndex(r => r.Nombre).IsUnique();

        builder.HasData(NombresRoles.Todos.Select((nombre, indice) => new Rol
        {
            Id = indice + 1,
            Nombre = nombre,
            FechaCreacion = FechaSemilla,
            CreadoPor = "Sistema",
            Activo = true
        }));
    }
}