using Data.Context;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repository
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(SqlDbContext dbContext) : base(dbContext) { }
    }
}
