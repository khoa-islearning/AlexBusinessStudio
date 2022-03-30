using System.ComponentModel.DataAnnotations;

namespace AlexBusinessStudio.Data
{
    public class BankInfo
    {
        public enum BankAccountType
        {
            Chequing,
            Saving
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public int BankId { get; set; }
        [Required]
        public int BranchNumber { get; set; }
        [Required]
        public BankAccountType AccountType { get; set; }
    }
}
