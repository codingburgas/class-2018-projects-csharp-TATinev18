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
        [Column(TypeName = "nvarchar(450)")]
        public string TicketID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string UserID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string DestID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool isRoundTicket { get; set; }
        public DateTime Date { get; set; }



    }
}
