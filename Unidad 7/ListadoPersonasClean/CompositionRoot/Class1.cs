using Data.Repositories;
using Domain.UseCases;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CompositionRoot
{
    public class Class1
    {

        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPeopleRepository, PeopleRepository>();

            services.AddScoped<IPeopleListUseCase, PeopleListUseCase>();

            return services;
        }

    }
}
