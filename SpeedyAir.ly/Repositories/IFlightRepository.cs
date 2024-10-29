using SpeedyAir.ly.Domain;

namespace SpeedyAir.ly.Repositories
{
    public interface IFlightRepository
    {
        /// <summary>
        /// Get Flight schedule
        /// </summary>
        /// <returns></returns>
        List<Flight>GetFlightSchedule();
    }
}
