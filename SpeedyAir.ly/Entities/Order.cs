namespace SpeedyAir.ly.Domain
{
    public  class Order
    {
        /// <summary>
        /// Flight Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flight Id
        /// </summary>
        public int? FlightId { get; set; }

        /// <summary>
        /// Order Destination
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Flight
        /// </summary>
        public virtual Flight Flight { get; set; }
    }
}
