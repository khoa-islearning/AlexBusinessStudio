using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class BankInfoService
    {
        private DBContext _context;

        public BankInfoService(DBContext aContext)
        {
            _context = aContext;
        }

        public async Task<BankInfo> Get()
        {
            return await _context.BankInfo.FirstAsync<BankInfo>();
        }

        public async Task<BankInfo> Update(BankInfo bankInfo)
        {
            BankInfo newInfo = new BankInfo
            {
                Id = 1,
                BankId = bankInfo.BankId,
                BranchNumber = bankInfo.BranchNumber,
                AccountNumber = bankInfo.AccountNumber,
                AccountType = bankInfo.AccountType
            };
            _context.Update(newInfo);
            await _context.SaveChangesAsync();
            return newInfo;
        }
    }
}
