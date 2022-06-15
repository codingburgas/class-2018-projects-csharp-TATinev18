using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public int UserID { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

    }
}
