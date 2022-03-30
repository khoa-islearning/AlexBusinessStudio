using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class ListingToTagService
    {
        private DBContext _context;

        public ListingToTagService(DBContext aContext)
        {
                _context = aContext;
        }

        public Task<List<int>> GetListingIdList(String tagName)
        {
            return _context.ListingToTag.Where(x => x.Tag == tagName).Select(x => x.ListingId).ToListAsync();
        }

        public Task<List<String>> GetTagList(int listId)
        {
            return _context.ListingToTag.Where(x=> x.ListingId == listId).Select(x => x.Tag).ToListAsync();
        }
    }
}
