using Data.PersonaRepository;
using Domain.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extension.DependencyInjection;
using ListadoPersonasCA.Domain.Repositories;

namespace CompositionRoot
{
    public static class Containers
    {
        public static IServiceCollection CompositionRoot(this IServiceCollection service, IConfiguration configuration);
        {
            services.AddScoped<IPersonaRepository, Data.Repositories.PersonaRepository>();
            services.AddScoped<IPersonaRepositoryUseCase, Domain.UseCases.PersonaRepositoryUseCase>();
        }
    }
}
