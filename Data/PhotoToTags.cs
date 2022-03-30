using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class PhotoToTags
    {
        [Required]
        public int PhotoId { get; set; }

        [Required]
        public string Tag { get; set; }
    }
}
