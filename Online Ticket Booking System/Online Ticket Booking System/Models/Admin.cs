﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Models
{
    public class Admin
    {
        [Key]
        [Column(TypeName = "nvarchar(450)")]
        public string AdminID { get; set; }
        [Column(TypeName = "nvarchar(450)")]
        public string UserID { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

    }
}
