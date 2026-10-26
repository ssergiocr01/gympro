using GymPro.Domain.Comun;

namespace GymPro.Domain.Entidades.Seguridad;

public class Usuario : EntidadBase
{
    public string NombreUsuario { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;

    /// <summary>Nunca se guarda la contraseña, solo su hash (Paso 08).</summary>
    public string ContrasenaHash { get; set; } = string.Empty;

    public DateTime? UltimoAcceso { get; set; }

    // Protección Contra Fuerza Bruta
    public int IntentosFallidos { get; set; }
    public DateTime? BloqueadoHasta { get; set; }

    public ICollection<UsuarioRol> UsuarioRoles { get; set; } = [];
}
