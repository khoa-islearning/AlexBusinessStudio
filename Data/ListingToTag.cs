using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class ListingToTag
    {
        [Required]
        public int ListingId { get; set; }

        [Required]
        public string Tag { get; set; }
    }
}
