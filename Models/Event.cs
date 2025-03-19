using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Event
    {

        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(150)]
        public string EventName { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        // Navigation Property: An event can have multiple bookings
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
