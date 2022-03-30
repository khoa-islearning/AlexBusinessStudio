using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class PhotoToTag
    {
        [Required]
        public int PhotoId { get; set; }

        [Required]
        public string Tag { get; set; }
    }
}
