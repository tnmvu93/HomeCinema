using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Services.IRepository;

namespace HomeCinema.Services.Repository
{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        #region properties
        public GenreRepository(HomeCinemaContext dbContext) : base(dbContext)
        {
        }
        #endregion
    }
}
