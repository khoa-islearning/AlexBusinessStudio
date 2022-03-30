using Microsoft.EntityFrameworkCore;


namespace AlexBusinessStudio.Data
{
    public class DBContext : DbContext
    {
        public DbSet<BankInfo> BankInfo { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<HistoryToListing> HistoryToListing { get; set; }
        public DbSet<Listing> Listing{ get; set; }
        public DbSet<ListingTag> ListingTag{ get; set; }
        public DbSet<ListingToTag> ListingToTag { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<PhotoTag> PhotoTag{ get; set; }
        public DbSet<PhotoToTag> PhotoToTag { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public List<BankInfo> MockBankInfo()
        {
            return new List<BankInfo>
            {
                new BankInfo
                {
                    Id = 1,
                    AccountNumber = 6002012,
                    BankId = 1,
                    BranchNumber = 12345,
                    AccountType = BankAccountType.Chequing
                }
            };
        }

    }
}
