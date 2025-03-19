using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        [StringLength(100)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; } // Placeholder for now

        // Navigation Property: A venue can have multiple bookings
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
