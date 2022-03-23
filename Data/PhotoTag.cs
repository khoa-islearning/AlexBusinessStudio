using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    
    public class PhotoTag
    {
        [Required, Key]
        public String Tag { get; set; }
    }
}
