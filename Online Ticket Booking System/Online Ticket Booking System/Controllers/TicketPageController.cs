using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Ticket_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Ticket_Booking_System.Controllers
{
    public class TicketPageController : Controller
    {
        public IActionResult BuyTicket()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
