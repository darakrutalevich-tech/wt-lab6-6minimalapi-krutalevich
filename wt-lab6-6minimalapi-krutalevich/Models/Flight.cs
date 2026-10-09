using System.ComponentModel.DataAnnotations;

namespace wt_lab6_6minimalapi_krutalevich.Models
{
    public class Flight
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FlightNumber { get; set; } = "";

        [Required]
        public string Departure { get; set; } = "";

        [Required]
        public string Arrival { get; set; } = "";

        [Range(1, 1000000)]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
