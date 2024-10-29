using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.ly;
using SpeedyAir.ly.Services;
public class Program
{
    private static void Main(string[] args)
    {
        var services = Startup.ConfigureServices();
        var serviceProvider = services.BuildServiceProvider();

        //User Story 1
        Console.WriteLine("Flight Schedule");
        var flightService = serviceProvider.GetRequiredService<IFlightService>();
        flightService.LoadFlightSchedule();

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Order Details");

        //User Story 2
        var orderService = serviceProvider.GetRequiredService<IOrderService>();
        orderService.LoadOrders();
    }
}