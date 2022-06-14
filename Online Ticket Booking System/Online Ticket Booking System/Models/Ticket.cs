using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        public int UserID { get; set; }

        public int DestID { get; set; }

        [Column(TypeName = "decimal)")]
        public decimal Price { get; set; }

        public bool IsRoundTicket { get; set; }

        public DateTime Date { get; set; }
    }
}
