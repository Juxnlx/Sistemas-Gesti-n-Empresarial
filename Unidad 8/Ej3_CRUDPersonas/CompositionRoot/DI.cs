using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRoot
{
    public class DI
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
