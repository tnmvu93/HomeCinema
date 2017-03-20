using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Services.IRepository;
using System.Linq;

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
        public User GetUserByUsername(string username)
        {
            return this.GetAll().FirstOrDefault(x => x.Username == username);
        }
        #endregion

    }
}
