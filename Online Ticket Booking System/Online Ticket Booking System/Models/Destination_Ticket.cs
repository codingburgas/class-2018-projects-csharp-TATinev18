using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Destination_Ticket
    {
        [Key]
        public int ID { get; set; }
        public int DestinationID { get; set; }
        public int TicketID { get; set; }
    }
}
