using SpeedyAir.ly.Domain;

namespace SpeedyAir.ly.Repositories
{
    /// <summary>
    /// Flight Repository
    /// </summary>
    public class FlightRepository : IFlightRepository
    {
        /// <summary>
        /// <inheritdoc cref="IFlightRepository.GetFlightSchedule()"/> 
        /// </summary>
        /// <returns></returns>
        public List<Flight> GetFlightSchedule()
        {
            List<Flight> flights = [
                new Flight()
                {
                    Id = 1,
                    Departure = "YUL",
                    Arrival = "YYZ",
                    Day = 1
                },
                new Flight()
                {
                    Id = 2,
                    Departure = "YUL",
                    Arrival = "YYC",
                    Day = 1
                },
                new Flight(){
                    Id = 3,
                    Departure = "YUL",
                    Arrival = "YVR",
                    Day = 1
                },
                new Flight(){
                    Id = 4,
                    Departure = "YUL",
                    Arrival = "YYZ",
                    Day = 2
                 },
                new Flight(){
                    Id = 5,
                    Departure = "YUL",
                    Arrival = "YYC",
                    Day = 2
                 },
                new Flight(){
                    Id = 6,
                    Departure = "YUL",
                    Arrival = "YVR",
                    Day = 2
                 },

            ];
            return flights;
        }
    }
}
