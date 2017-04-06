using System.Web.Http;

namespace HomeCinema.Api.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacWebApiConfig.Initialize(GlobalConfiguration.Configuration);
            AutoMapperConfiguration.Configure();
        }
    }
}