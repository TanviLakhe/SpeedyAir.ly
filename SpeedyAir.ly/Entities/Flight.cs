using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.ly.Domain
{
    public class Flight
    {
        public int Id { get; set; }
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public int Day { get; set; }

        public int OrderCapacity = 20;
        public List<Order> Orders { get; set; }
    }
}
