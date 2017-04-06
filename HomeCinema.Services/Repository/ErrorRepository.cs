using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Services.IRepository;

namespace HomeCinema.Services.Repository
{
    public class ErrorRepository : BaseRepository<Error>, IErrorRepository
    {
        #region properties
        public ErrorRepository(HomeCinemaContext dbContext) : base(dbContext)
        {
        }
        #endregion
    }
}
