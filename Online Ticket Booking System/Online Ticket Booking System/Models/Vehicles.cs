using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Vehicles
    {
        [Key]
        [Column(TypeName = "nvarchar(450)")]
        public string VechilesID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string TCID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Type { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Size { get; set; }
    }
}
