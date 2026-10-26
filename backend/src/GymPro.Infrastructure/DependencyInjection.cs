using GymPro.Infrastructure.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymPro.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AgregarInfraestructura(
        this IServiceCollection services, string cadenaConexion)
    {
        services.AddDbContext<GymProDbContext>(opciones =>
            opciones.UseSqlServer(cadenaConexion, sql =>
                sql.MigrationsAssembly(typeof(GymProDbContext).Assembly.FullName)));

        return services;
    }
}