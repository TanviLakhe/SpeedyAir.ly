using SpeedyAir.ly.Domain;

namespace SpeedyAir.ly.Repositories
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Get Orders
        /// </summary>
        /// <returns></returns>
        List<Order> GetOrders();
    }
}
