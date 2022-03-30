using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class PhotoToTagService
    {
        private DBContext _context;

        public PhotoToTagService(DBContext aContext)
        {
            _context = aContext;
        }

        public Task<List<int>> GetPhotoIdList(String tagName)
        {
            return _context.PhotoToTag.Where(x => x.Tag == tagName).Select(x => x.PhotoId).ToListAsync();
        }

        public Task<List<String>> GetTagList(int PhotoId)
        {
            return _context.PhotoToTag.Where(x => x.PhotoId == PhotoId).Select(x => x.Tag).ToListAsync();
        }
    }
}
