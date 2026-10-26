using GymPro.Domain.Entidades.Socios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones.Socios;

public class SocioConfiguracion : ConfiguracionEntidadBase<Socio>
{
    protected override void ConfigurarEntidad(EntityTypeBuilder<Socio> builder)
    {
        builder.ToTable("Socio");

        // Datos personales
        builder.Property(s => s.Identificacion).HasMaxLength(20);
        builder.Property(s => s.Nombre).HasMaxLength(100);
        builder.Property(s => s.PrimerApellido).HasMaxLength(100);
        builder.Property(s => s.SegundoApellido).HasMaxLength(100);

        // Contacto
        builder.Property(s => s.Telefono).HasMaxLength(20);
        builder.Property(s => s.Correo).HasMaxLength(150);
        builder.Property(s => s.Direccion).HasMaxLength(300);

        builder.Property(s => s.ContactoEmergenciaNombre).HasMaxLength(150);
        builder.Property(s => s.ContactoEmergenciaTelefono).HasMaxLength(20);

        builder.Property(s => s.Observaciones).HasMaxLength(1000);

        builder.HasIndex(s => s.Identificacion).IsUnique();

        // Búsquedas por apellido en el listado de socios
        builder.HasIndex(s => new { s.PrimerApellido, s.SegundoApellido, s.Nombre });

        // Acceso opcional al portal: un socio puede tener un usuario (o ninguno)
        builder.HasOne(s => s.Usuario)
               .WithMany()
               .HasForeignKey(s => s.UsuarioId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Restrict);

        // Un usuario solo puede estar ligado a un socio
        builder.HasIndex(s => s.UsuarioId)
               .IsUnique()
               .HasFilter("[UsuarioId] IS NOT NULL");
    }
}