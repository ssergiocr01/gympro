using GymPro.Domain.Comun;

namespace GymPro.Domain.Entidades.Seguridad
{
    public class Rol : EntidadBase
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public ICollection<UsuarioRol> UsuarioRoles { get; set; } = [];
    }
}
