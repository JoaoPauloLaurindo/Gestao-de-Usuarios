using System.Collections.Generic;

namespace Domain.Entities
{
    public class Perfil : Entity
    {
        public string NomePerfil { get; set; }
        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}
