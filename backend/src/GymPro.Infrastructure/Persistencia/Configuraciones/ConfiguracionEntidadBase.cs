using GymPro.Domain.Comun;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymPro.Infrastructure.Persistencia.Configuraciones;

public abstract class ConfiguracionEntidadBase<T> : IEntityTypeConfiguration<T>
    where T : EntidadBase
{
    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.FechaCreacion).IsRequired();
        builder.Property(e => e.CreadoPor).HasMaxLength(100);
        builder.Property(e => e.ModificadoPor).HasMaxLength(100);

        // Borrado lógico: por defecto las consultas solo traen registros activos
        builder.HasQueryFilter(FiltrosConsulta.SoloActivos, e => e.Activo);

        ConfigurarEntidad(builder);
    }

    protected abstract void ConfigurarEntidad(EntityTypeBuilder<T> builder);   
        
}
