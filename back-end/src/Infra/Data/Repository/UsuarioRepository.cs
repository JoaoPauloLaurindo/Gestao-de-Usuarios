using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SqlDbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<Usuario>> ObterUsuariosPerfil()
        {
            var user = await Db.Usuarios.AsNoTracking()
                .Include(x => x.Perfil)
                .ToListAsync();

            return user;
        }

        public async Task<Usuario> ObterUsuariosPerfilPorId(Guid id)
        {
            var user = await Db.Usuarios.AsNoTracking()
                .Include(x => x.Perfil)
                .FirstOrDefaultAsync(x => x.Id == id);

            return user;
        }
    }
}
