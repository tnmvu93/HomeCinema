using HomeCinema.Api.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeCinema.Data;
using HomeCinema.Services.IRepository;
using AutoMapper;
using HomeCinema.Data.Entities;
using HomeCinema.Api.ViewModel;

namespace HomeCinema.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/genres")]
    public class GenreController : BaseApiController
    {
        #region properties
        private readonly IGenreRepository _genreRepository;

        public GenreController(HomeCinemaContext dbContext, IErrorRepository errorRepository, IGenreRepository genreRepository) 
            : base(dbContext, errorRepository)
        {
            _genreRepository = genreRepository;
        }
        #endregion

        [AllowAnonymous]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                var genres = _genreRepository.GetAll().ToList();

                var genresVm = Mapper.Map<IEnumerable<Genre>, IEnumerable<GenreViewModel>>(genres);
                response = request.CreateResponse(HttpStatusCode.OK, genresVm);

                return response;
            });
        }
    }
}
