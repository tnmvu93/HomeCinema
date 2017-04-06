using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using HomeCinema.Services.IRepository;

namespace HomeCinema.Services.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        #region properties
        public MovieRepository(HomeCinemaContext dbContext) : base(dbContext)
        {
        }
        #endregion


    }
}
