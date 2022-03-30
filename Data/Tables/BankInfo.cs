using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public enum BankAccountType
    {
        Chequing,
        Saving
    }

    public class BankInfo
    {

        [Required]
        public int Id { get; set; } 
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        public int BankId { get; set; }
        [Required]
        public int BranchNumber { get; set; }
        [Required]
        public BankAccountType AccountType { get; set; }
    }
}
