using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEaseApp.Models;

namespace EventEaseApp.Data
{
    public class EventEaseAppContext : DbContext
    {
        public EventEaseAppContext (DbContextOptions<EventEaseAppContext> options)
            : base(options)
        {
        }

        public DbSet<EventEaseApp.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEaseApp.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEaseApp.Models.Booking> Booking { get; set; } = default!;
    }
}
