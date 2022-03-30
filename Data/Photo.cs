using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        [Required]
        [StringLength(100)]
        public  String Name { get; set; }
        [Required]
        public  String Size { get; set; }
        [Required]
        public String Note { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
