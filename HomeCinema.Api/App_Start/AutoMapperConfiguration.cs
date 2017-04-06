using AutoMapper;
using HomeCinema.Api.Infrastructure.Mappings;

namespace HomeCinema.Api.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntityToViewModelMappingProfile>();
            });
        }
    }
}