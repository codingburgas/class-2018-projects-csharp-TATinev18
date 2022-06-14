using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Online_Ticket_Booking_System.Areas.Identity.Data;

namespace Online_Ticket_Booking_System.Data
{
    public class Online_Ticket_Booking_SystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public Online_Ticket_Booking_SystemDbContext(DbContextOptions<Online_Ticket_Booking_SystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
