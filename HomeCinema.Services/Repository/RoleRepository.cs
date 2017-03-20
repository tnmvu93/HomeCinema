using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Services.IRepository;

namespace HomeCinema.Services.Repository
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(HomeCinemaContext dbContext) : base(dbContext) { }
    }
}
