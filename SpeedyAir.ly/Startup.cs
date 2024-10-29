using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.ly.Repositories;
using SpeedyAir.ly.Services;

namespace SpeedyAir.ly
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IFlightService, FlightService>();
            services.AddSingleton<IOrderService, OrderService>();
                        
            services.AddTransient<IFlightRepository, FlightRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            
            return services;
        }
    }
}
