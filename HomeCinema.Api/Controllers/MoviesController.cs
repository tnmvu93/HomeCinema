using HomeCinema.Api.Infrastructure.Core;
using HomeCinema.Data;
using HomeCinema.Services.IRepository;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using System.Collections.Generic;
using HomeCinema.Data.Entities;
using HomeCinema.Api.ViewModel;
using System.Net;

namespace HomeCinema.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/movies")]
    public class MoviesController : BaseApiController
    {
        #region properties
        private readonly IMovieRepository _movieRepository;

        public MoviesController(HomeCinemaContext dbContext, IErrorRepository errorRepository, IMovieRepository movieRepository) 
            : base(dbContext, errorRepository)
        {
            _movieRepository = movieRepository;
        }
        #endregion

        [AllowAnonymous]
        [Route("latest")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var movies = _movieRepository.GetAll().OrderByDescending(x => x.ReleaseDate).Take(6).ToList();

                var moviesViewModel = Mapper.Map<IEnumerable<Movie>, IEnumerable<MovieViewModel>>(movies);
                response = request.CreateResponse(HttpStatusCode.OK, moviesViewModel);

                return response;
            });
        }
    }
}
