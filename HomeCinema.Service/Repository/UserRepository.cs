using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Service.IRepository;

namespace HomeCinema.Service.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region properties
        public UserRepository(HomeCinemaContext dbContext) : base(dbContext)
        {
        }
        #endregion

        #region methods
        #endregion

    }
}
