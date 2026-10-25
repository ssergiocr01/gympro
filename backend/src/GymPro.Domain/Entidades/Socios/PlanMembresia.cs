using GymPro.Domain.Comun;

namespace GymPro.Domain.Entidades.Socios;

public class PlanMembresia : EntidadBase
{
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int DuracionDias { get; set; }
    public decimal Precio { get; set; }

    public ICollection<Membresia> Membresias { get; set; } = [];
}
