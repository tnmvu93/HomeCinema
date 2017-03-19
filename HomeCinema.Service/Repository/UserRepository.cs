using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;


namespace HomeCinema.Service.Repository
{
    public class UserRepository : BaseRepository<User>
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
