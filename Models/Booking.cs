using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Booking
    {

        [Key]
        public int BookingId { get; set; }

        [Required]
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }

        [Required]
        public int VenueId { get; set; }

        [ForeignKey("VenueId")]
        public Venue Venue { get; set; }

        [Required]
        public DateTime BookingDate { get; set; } // Date when the booking was made

    }
}
