namespace GymPro.Domain.Comun;

/// <summary>
/// Clase base de todas las entidades. Los campos de auditoría los llena
/// automáticamente el interceptor de bitácora (Paso 05), no el código de negocio.
/// </summary>
public abstract class EntidadBase
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }
    public string? CreadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }
    public string? ModificadoPor { get; set; }

    /// <sumary>Borrado Lógico: false = "eliminado"</sumary>
    public bool Activo { get; set; } = true;
}
