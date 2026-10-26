using GymPro.Domain.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Seguridad
{
    public class UsuarioConfiguracion : ConfiguracionEntidadBase<Usuario>
    {
        protected override void ConfigurarEntidad(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(u => u.NombreUsuario).HasMaxLength(50);
            builder.Property(u => u.Correo).HasMaxLength(150);
            builder.Property(u => u.ContrasenaHash).HasMaxLength(500);

            builder.HasIndex(u => u.NombreUsuario).IsUnique();
            builder.HasIndex(u => u.Correo).IsUnique();
        }
    }
}
