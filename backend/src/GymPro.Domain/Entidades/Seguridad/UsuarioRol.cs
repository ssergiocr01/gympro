using GymPro.Domain.Comun;

namespace GymPro.Domain.Entidades.Seguridad;
/// <summary>
/// Relación muchos a muchos Usuario ↔ Rol. Es entidad explícita (no la tabla
/// "invisible" de EF) para que herede auditoría y quede registrada en bitácora
/// quién le asignó qué rol a quién.
/// </summary>
public class UsuarioRol : EntidadBase
{
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; } = null!;

    public int RolId { get; set; }
    public Rol Rol { get; set; } = null!;
}
