using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Data.Repositories;
using Domain.UseCases;
using Domain.Interfaces.UseCases;
using Domain.Interfaces.Repositories;

namespace CompositionRoot
{
    public static class DI
    {
        //hay que instalar los paquetes nugget
        //addcomposition root 
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            //registra esos repositorios con su clase
            services.AddScoped<IPersonaRepository, PersonasRepositoryAzure>();
            services.AddScoped<IPersonaRepositoryUseCase, PersonaRepositoryUseCase>();

            return services;
        }
    }
}
