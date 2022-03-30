using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class ListingTag
    {
        [Required, Key]
        public String Tag { get; set; }
    }
}
