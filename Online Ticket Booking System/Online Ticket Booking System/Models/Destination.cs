using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ArriveAt { get; set; }
        public int TCID { get; set; }
        public int VehicleID { get; set; }
    }
}
