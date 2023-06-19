using RoboAPI.Domain.Interfaces.Services;
using RoboAPI.Service.Services;

namespace RoboAPI.CrossCutting.DependencyInjection
{
    public class ConfigureServices
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAcaoService, AcaoService>();
            serviceCollection.AddTransient<IRoboService, RoboService>();
        }
    }
}
