using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AgroSys.Infrastructure.Contracts;
using AgroSys.Infrastructure.Services;
using AgroSys.Repository.AnimalRepo;
using AgroSys.Repository.CattleManRepo;
using AgroSys.Repository.CattlemanRepo;

namespace AgroSys.Infrastructure
{
    public static class ServicesExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<ICattlemanService, CattlemanService>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<ICattlemanRepository, CattlemanRepository>();
        }
    }
}
