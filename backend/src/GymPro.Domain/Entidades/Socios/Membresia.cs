using GymPro.Domain.Comun;
using GymPro.Domain.Enums;

namespace GymPro.Domain.Entidades.Socios;

public class Membresia : EntidadBase
{
    public int SocioId { get; set; }
    public Socio Socio { get; set; } = null!;

    public int PlanMembresiaId { get; set; }
    public PlanMembresia PlanMembresia { get; set; } = null!;

    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }

    /// <summary>
    /// Copia del precio al momento de contratar: si el plan sube de precio
    /// después, las membresías viejas conservan lo que realmente se cobró.
    /// </summary>
    public decimal PrecioPactado { get; set; }

    public EstadoMembresia Estado { get; set; } = EstadoMembresia.Activa;

    public ICollection<Pago> Pagos { get; set; } = [];

    /// <summary>Regla de negocio del dominio: vigente = activa y dentro del rango de fechas.</summary>
    public bool EstadoVigente(DateOnly hoy) =>
        Estado == EstadoMembresia.Activa && hoy >= FechaInicio && hoy <= FechaFin;
}