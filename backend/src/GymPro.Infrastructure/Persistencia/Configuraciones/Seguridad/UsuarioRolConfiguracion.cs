using GymPro.Domain.Entidades.Seguridad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Seguridad
{
    public class UsuarioRolConfiguracion : ConfiguracionEntidadBase<UsuarioRol>
    {
        protected override void ConfigurarEntidad(EntityTypeBuilder<UsuarioRol> builder)
        {
            builder.ToTable("UsuarioRol");

            builder.HasOne(ur => ur.Usuario)
                .WithMany(u => u.UsuarioRoles)
                .HasForeignKey(ur => ur.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ur => ur.Rol)
                .WithMany(r => r.UsuarioRoles)
                .HasForeignKey(ur => ur.RolId)
                .OnDelete(DeleteBehavior.Restrict);

            // Un usuario no puede tener el mismo rol dos veces
            builder.HasIndex(ur => new { ur.UsuarioId, ur.RolId }).IsUnique();
        }
    }
}
