using Microsoft.EntityFrameworkCore;

namespace AlexBusinessStudio.Data.Service
{
    public class PhotoService
    {
        DBContext _context;

        public PhotoService(DBContext aContext) { _context = aContext; }

        public async Task<List<Photo>> GetAll()
        {
            return await _context.Photo.ToListAsync();
        }

        public async Task<Photo> Get(int id)
        {
            return await _context.Photo.FindAsync(id);
        }

        public async Task<Photo> Post(Photo photo)
        {
            try
            {
                var photoExist = _context.Photo.FirstOrDefault(x => x.PhotoId == photo.PhotoId);
                if (photoExist == null)
                {
                    _context.Photo.Add(photo);
                    await _context.SaveChangesAsync();
                    return photo;
                }
                else
                {
                    return photoExist;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Photo> Update(Photo photo)
        {
            var toUpdate = _context.Photo.FirstOrDefault(x => x.PhotoId == photo.PhotoId);
            if(toUpdate != null)
            {
                _context.Photo.Update(photo);
                await _context.SaveChangesAsync();
            }
            return photo;
        }

        public async Task Delete(Photo photo)
        {
            _context.Photo.Remove(photo);
            await _context.SaveChangesAsync();
        }
    }
}
