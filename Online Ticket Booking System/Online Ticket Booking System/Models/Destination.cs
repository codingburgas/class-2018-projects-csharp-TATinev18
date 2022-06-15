using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Destination
    {
        [Column(TypeName = "nvarchar(450)")]
        public string DestinationID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string DestinationName { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ArriveAt { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string TCID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string VehicleID { get; set; }
    }
}
