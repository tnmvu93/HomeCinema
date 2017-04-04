using HomeCinema.Data;
using HomeCinema.Data.BaseRepository;
using HomeCinema.Data.Entities;
using System;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeCinema.Api.Infrastructure.Core
{
    public class BaseApiController : ApiController
    {
        protected readonly HomeCinemaContext _dbContext;
        protected readonly IBaseRepository<Error> _errorRepository;

        public BaseApiController(HomeCinemaContext dbContext, IBaseRepository<Error> errorRepository)
        {
            this._dbContext = dbContext;
            this._errorRepository = errorRepository;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage request, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;

            try
            {
                response = function.Invoke();
            }
            catch(DbUpdateException ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch(Exception ex)
            {
                LogError(ex);
                response = request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

        private void LogError(Exception ex)
        {
            try
            {
                var error = new Error
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    DateCreated = DateTime.Now
                };

                _errorRepository.Add(error);
                _dbContext.SaveChanges();
            }
            catch
            {
            }
        }
    }
}
