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
        public EventEaseAppContext(DbContextOptions<EventEaseAppContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venue { get; set; } = default!;
        public DbSet<Event> Event { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Seed Venues with Correct Image URLs
            modelBuilder.Entity<Venue>().HasData(
                new Venue { VenueId = 1, VenueName = "Grand Hall", Location = "New York, USA", Capacity = 500, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRN57LMlQjGAAO4dkv1yUjWMyxFPHvfkHKOSg&s" },
                new Venue { VenueId = 2, VenueName = "Sunset Arena", Location = "Los Angeles, USA", Capacity = 1000, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHaUFzC27bQO5Est2gNRpmULPBJTwHhgDQfQ&s" },
                new Venue { VenueId = 3, VenueName = "Skyline Pavilion", Location = "Chicago, USA", Capacity = 750, ImageUrl = "https://media.istockphoto.com/id/1467962890/photo/above-chicago.jpg?s=612x612&w=0&k=20&c=lZJbZiT10L_9-mjS07rEwCOT6wUigyUdKYJxrEbeuvY=" },
                new Venue { VenueId = 4, VenueName = "Crystal Conference Center", Location = "London, UK", Capacity = 1200, ImageUrl = "https://canvas-events-locations.imgix.net/ea7aaad0e8647fe5b9c77efdefb2b95a54215bd95f5c80.02567362/1/Crystal2.jpg?w=1200&fit=crop&mark=https://www.canvas-events.co.uk/images/canvas-yellow-watermark-v1.1.png&markw=150&markalign=top,left&markpad=50&dpr=2&q=20&usm=20&auto=format&h=675" },
                new Venue { VenueId = 5, VenueName = "Blue Wave Stadium", Location = "Miami, USA", Capacity = 2000, ImageUrl = "https://stadiumdb.com/img/news/2022/08/19978-thumbnail.jpg" }
            );

            // ✅ Seed Events with Different Dates
            modelBuilder.Entity<Event>().HasData(
                new Event { EventId = 1, EventName = "Tech Conference 2025", EventDate = new DateTime(2025, 5, 15), Description = "A global conference on emerging technologies." },
                new Event { EventId = 2, EventName = "Music Festival 2025", EventDate = new DateTime(2025, 6, 20), Description = "An electrifying music experience with top artists." },
                new Event { EventId = 3, EventName = "AI & Machine Learning Summit", EventDate = new DateTime(2025, 4, 10), Description = "Latest trends and innovations in AI and ML." },
                new Event { EventId = 4, EventName = "International Business Expo", EventDate = new DateTime(2025, 7, 5), Description = "Networking with top entrepreneurs worldwide." },
                new Event { EventId = 5, EventName = "Comic-Con 2025", EventDate = new DateTime(2025, 8, 12), Description = "A gathering for fans of comics, movies, and gaming." }
            );

            // ✅ Seed Bookings (Connecting Events & Venues)
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, EventId = 1, VenueId = 1, BookingDate = new DateTime(2025, 3, 20, 12, 0, 0) },
                new Booking { BookingId = 2, EventId = 2, VenueId = 2, BookingDate = new DateTime(2025, 3, 21, 14, 0, 0) },
                new Booking { BookingId = 3, EventId = 3, VenueId = 3, BookingDate = new DateTime(2025, 3, 22, 10, 30, 0) },
                new Booking { BookingId = 4, EventId = 4, VenueId = 4, BookingDate = new DateTime(2025, 3, 23, 15, 0, 0) },
                new Booking { BookingId = 5, EventId = 5, VenueId = 5, BookingDate = new DateTime(2025, 3, 24, 18, 0, 0) }
            );
        }
    }
}
