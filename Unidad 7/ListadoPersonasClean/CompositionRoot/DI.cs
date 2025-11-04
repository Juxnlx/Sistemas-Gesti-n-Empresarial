using DATA.Repositories;
using DOMAIN.UseCases;
using Domain.UseCases.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRoot
{
    public static class DI
    {
        //Instalar el paquete NuGet Microsoft.Extensions.Configuration.Abstractions 
        //y el paquete Microsoft.Extensions.DependencyInjection.Abstractions
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            // Registrar repositorios concretos
            services.AddScoped<IPersonaRepository, PersonaRepository100>();

            // Registrar casos de uso
            services.AddScoped<IPersonaListUseCase, PersonaListUseCase>();

            return services;
        }
    }
}


