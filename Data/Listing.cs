using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class Listing
    {
        [Required, Key]
        public int ListingId { get; set; }
        [Required]
        public int PhotoId { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }

    }
}
