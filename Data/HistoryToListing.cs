using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class HistoryToListing
    {
        [Required]
        public int TransitId { get; set; }
        [Required]
        public int ListingId { get; set; }
    }
}
