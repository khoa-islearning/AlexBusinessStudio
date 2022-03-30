using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class ListingTagService
    {
        private DBContext _context;
        public ListingTagService(DBContext aContext) { _context = aContext; }

        public async Task<List<ListingTag>> GetAll()
        {
            return await _context.ListingTag.ToListAsync();
        }

        public async Task<ListingTag> Get(String tagName)
        {
            return await _context.ListingTag.FindAsync(tagName);
        }

    }
}
