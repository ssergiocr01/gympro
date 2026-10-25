namespace GymPro.Domain.Constantes
{
    public abstract class NombresRoles
    {
        public const string Administrador = "Administrador";
        public const string Entrenador = "Entrenador";
        public const string Nutricionista = "Nutricionista";
        public const string Recepcion = "Recepcion";
        public const string Socio = "Socio";

        public static readonly string[] Todos =
            [Administrador, Entrenador, Nutricionista, Recepcion, Socio];
    }
}
