using GymPro.Domain.Comun;
using GymPro.Domain.Enums;

namespace GymPro.Domain.Entidades.Socios;

public class Pago : EntidadBase
{
    public int MembresiaId { get; set; }
    public Membresia Membresia { get; set; } = null!;

    public DateTime FechaPago { get; set; }
    public decimal Monto { get; set; }
    public MetodoPago MetodoPago { get; set; }

    /// <summary>Número de comprobante SINPE, voucher, transferencia, etc.</summary>
    public string? Referencia { get; set; }
    public string? Observaciones { get; set; }
}