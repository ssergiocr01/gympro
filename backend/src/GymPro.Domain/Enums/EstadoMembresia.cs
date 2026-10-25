namespace GymPro.Domain.Enums;

/// <summary>
/// Estado administrativo de la membresía. "Vencida" NO es un estado guardado:
/// se calcula comparando FechaFin con la fecha actual (ver Membresia.EstaVigente).
/// </summary>

public enum EstadoMembresia
{
    Activa = 1,
    Congelada = 2,
    Cancelada = 3
}
