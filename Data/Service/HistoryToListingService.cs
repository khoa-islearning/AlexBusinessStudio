using Microsoft.EntityFrameworkCore;


namespace AlexBusinessStudio.Data.Service
{
    public class HistoryToListingService
    {
        DBContext _context;

        public HistoryToListingService(DBContext dBContext)
        {
            _context = dBContext;
        }

        public async Task<List<int>> GetListings(int transitId)
        {
            return await _context.HistoryToListing.Where(u => u.TransitId == transitId).Select(u => u.ListingId).ToListAsync();
        }
    }
}
