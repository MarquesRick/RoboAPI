using RoboAPI.Data.Repository;
using RoboAPI.Domain.Interfaces;
using RoboAPI.Domain.Repository;

namespace RoboAPI.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
