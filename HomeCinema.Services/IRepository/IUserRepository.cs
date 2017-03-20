using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;

namespace HomeCinema.Services.IRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserByUsername(string username);
    }
}
