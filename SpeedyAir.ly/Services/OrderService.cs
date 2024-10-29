using SpeedyAir.ly.Domain;
using SpeedyAir.ly.Repositories;

namespace SpeedyAir.ly.Services
{
    /// <summary>
    /// Order Service
    /// </summary>
    /// <param name="orderRepository"></param>
    /// <param name="flightRepository"></param>
    public class OrderService(IOrderRepository orderRepository, IFlightRepository flightRepository) : IOrderService
    {
        private readonly IOrderRepository _orderRepository = orderRepository;
        private readonly IFlightRepository _flightRepository = flightRepository;

        public void LoadOrders()
        {
            var orders = _orderRepository.GetOrders();
            var flights = _flightRepository.GetFlightSchedule();

            var groupedOrders = orders.GroupBy(x => x.Destination).ToList();
            var groupedFights = flights.GroupBy(x => x.Arrival).ToList();

            foreach (var flightGroup in groupedFights)
            {
                var orderGroup = groupedOrders.Where(x => x.Key == flightGroup.Key).ToList();
                foreach (var flight in flightGroup)
                {
                    var unAssignedOrders = orderGroup[0].Where(x => !x.FlightId.HasValue).ToList();
                    if (unAssignedOrders.Count == 0)
                    {
                        break;
                    }
                    int flightCapacity = flight.OrderCapacity;
                    AssignFlightToOrders(unAssignedOrders.Take(Math.Min(flightCapacity, unAssignedOrders.Count)).ToList(), flight);
                }
            }

            var scheduledOrders = orders.Where(f => f.FlightId.HasValue).ToList();
            var unscheduledOrders = orders.Where(f =>  !f.FlightId.HasValue).ToList();

            foreach (var order in scheduledOrders)
            {
                Console.WriteLine($"order: {order.Name}, flightNumber: {order.FlightId}, departure: {order.Flight?.Departure}, arrival: {order.Flight?.Arrival}, day: {order.Flight?.Day}");
            }

            foreach (var order in unscheduledOrders)
            {
                Console.WriteLine($"order: {order.Name}, flightNumber: not scheduled");
            }

        }

        /// <summary>
        /// Assign flight to orders
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="flight"></param>
        private static void AssignFlightToOrders(List<Order> orders, Flight flight)
        {
            foreach (var order in orders)
            {
                order.FlightId = flight.Id;
                order.Flight = flight;
            }

        }
    }
}
