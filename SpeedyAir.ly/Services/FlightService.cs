using SpeedyAir.ly.Repositories;

namespace SpeedyAir.ly.Services
{
    /// <summary>
    /// FlightService
    /// </summary>
    /// <param name="flightRepository"></param>
    public class FlightService(IFlightRepository flightRepository) : IFlightService
    {
        private readonly IFlightRepository _flightRepository = flightRepository;

        public void LoadFlightSchedule()
        {
            var flights = _flightRepository.GetFlightSchedule();

            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight: {flight.Id}, departure: {flight.Departure}, arrival: {flight.Arrival}, day: {flight.Day} ");
            }
        }
    }
}
