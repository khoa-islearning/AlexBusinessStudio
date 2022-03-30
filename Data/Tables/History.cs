using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class History
    {
        [Required, Key]
        public int TransId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string PayMethod { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
