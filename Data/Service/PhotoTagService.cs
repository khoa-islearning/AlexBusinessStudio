using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class PhotoTagService
    {
        private DBContext _context;
        public PhotoTagService(DBContext aContext) { _context = aContext; }

        public async Task<List<PhotoTag>> GetAll()
        {
            return await _context.PhotoTag.ToListAsync();
        }

        public async Task<PhotoTag> Get(String tagName)
        {
            return await _context.PhotoTag.FindAsync(tagName);
        }
    }
}
