using GymPro.Domain.Comun;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymPro.Domain.Entidades.Seguridad
{
    public class Rol : EntidadBase
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public ICollection<UsuarioRol> UsuarioRoles { get; set; } = [];
    }
}
