using Newtonsoft.Json;
using SpeedyAir.ly.Domain;

namespace SpeedyAir.ly.Repositories
{
    /// <summary>
    /// Order OrderRepository
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// <inheritdoc cref="IOrderRepository.GetOrders()"/> 
        /// </summary>
        /// <returns></returns>
        List<Order> IOrderRepository.GetOrders()
        {
            string ordersJson = File.ReadAllText(@"JsonFiles\coding-assigment-orders.json");
            var orderList = JsonConvert.DeserializeObject<Dictionary<string, Order>>(ordersJson);

            List<Order> orders = [];

            if (orderList != null && orderList.Count != 0)
            {
                foreach (var order in orderList)
                {
                    orders.Add(new Order()
                    {
                        Name = order.Key,
                        Destination = order.Value.Destination,
                    });
                }
            }

            return orders;
        }
    }
}
