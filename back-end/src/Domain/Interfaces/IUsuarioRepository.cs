using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> ObterUsuariosPerfil();
        Task<Usuario> ObterUsuariosPerfilPorId(Guid id);
    }
}
