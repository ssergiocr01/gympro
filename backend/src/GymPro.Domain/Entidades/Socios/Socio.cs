using GymPro.Domain.Comun;
using GymPro.Domain.Entidades.Seguridad;
using GymPro.Domain.Enums;

namespace GymPro.Domain.Entidades.Socios;

public class Socio : EntidadBase
{
    public string Identificacion { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string PrimerApellido { get; set; } = string.Empty;
    public string? SegundoApellido { get; set; }

    public DateOnly FechaNacimiento { get; set; }
    public Genero Genero { get; set; }

    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public string? Direccion { get; set; }

    public string? ContactoEmergenciaNombre { get; set; }
    public string? ContactoEmergenciaTelefono { get; set; }

    public DateOnly FechaIngreso { get; set; }
    public string? Observaciones { get; set; }

    /// <summary>
    /// Opcional: solo si el socio tiene acceso al sistema (rol Socio)
    /// para ver su rutina, plan alimenticio y progreso.
    /// </summary>
    public int? UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }

    public ICollection<Membresia> Membresias { get; set; } = [];
}