using HomeCinema.Service.Abstract;
using System.Net.Http;

namespace HomeCinema.Api.Infrastructure.Extensions
{
    public static class RequestMessageExtensions
    {
        internal static IMembershipService GetMembershipService(this HttpRequestMessage request)
        {
            return request.GetService<IMembershipService>();
        }

        private static TService GetService<TService>(this HttpRequestMessage request)
        {
            var dependencyScope = request.GetDependencyScope();
            var service = (TService)dependencyScope.GetService(typeof(TService));

            return service;
        }
    }
}