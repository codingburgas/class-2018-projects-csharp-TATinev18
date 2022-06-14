using Microsoft.EntityFrameworkCore;
using Online_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicles>Vehicles { get; set; }

        public DbSet<TransportCompany> TransportCompanies { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
