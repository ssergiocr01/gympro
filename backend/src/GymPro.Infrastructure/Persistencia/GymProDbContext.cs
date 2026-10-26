using GymPro.Domain.Entidades.Seguridad;
using GymPro.Domain.Entidades.Socios;
using Microsoft.EntityFrameworkCore;

namespace GymPro.Infrastructure.Persistencia;

public class GymProDbContext(DbContextOptions<GymProDbContext> options) : DbContext(options)
{
    // Seguridad
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Rol> Roles => Set<Rol>();
    public DbSet<UsuarioRol> UsuariosRoles => Set<UsuarioRol>();

    // Socios
    public DbSet<Socio> Socios => Set<Socio>();
    public DbSet<PlanMembresia> PlanesMembresia => Set<PlanMembresia>();
    public DbSet<Membresia> Membresias => Set<Membresia>();
    public DbSet<Pago> Pagos => Set<Pago>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Busca todas las clases IEntityTypeConfiguration<T> no abstractas de este proyecto
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymProDbContext).Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        // Todos los decimal del modelo quedan como decimal(10,2)
        configurationBuilder.Properties<decimal>().HavePrecision(10, 2);

        // Si decidís guardar los enums como texto, descomentá esta línea:
        // configurationBuilder.Properties<Enum>().HaveConversion<string>().HaveMaxLength(30);
    }
}
