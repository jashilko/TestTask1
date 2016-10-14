using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test_Task.Models
{
    public class TicketContext: DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
    }
}