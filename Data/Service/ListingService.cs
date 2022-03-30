using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace AlexBusinessStudio.Data.Service
{
    public class ListingService
    {
        private DBContext _context;
        public ListingService(DBContext aContext) { _context = aContext; }

        public async Task<List<Listing>> GetAll()
        {
            return await _context.Listing.ToListAsync();
        }

        public async Task<Listing> Post(Listing listing)
        {
            try
            {
                var listingExist = _context.Listing.FirstOrDefault(x => x.ListingId == listing.ListingId);
                if (listingExist == null)
                {
                    _context.Listing.Add(listing);
                    await _context.SaveChangesAsync();
                    return listing;
                }
                else
                {
                    return listingExist;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Listing> Get(int id)
        {
            try
            {
                var listing = await _context.Listing.FindAsync(id);
                if (listing != null)
                {
                    return listing;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Listing> Update(Listing listing)
        {
            try
            {
                var listingExist = _context.Listing.FirstOrDefault(x => x.ListingId == listing.ListingId);
                if(listingExist != null)
                {
                    _context.Listing.Update(listing);
                    await _context.SaveChangesAsync();
                }
            }catch (Exception ex)
            {
                throw;
            }
            return listing;
        }

        public async void Delete(Listing listing)
        {
            try
            {
                _context.Listing.Remove(listing);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
