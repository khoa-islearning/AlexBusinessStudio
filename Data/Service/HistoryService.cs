using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace AlexBusinessStudio.Data.Service
{
    public class HistoryService
    {
        private DBContext _context;

        public HistoryService(DBContext aContext)
        {
            _context = aContext;
        }

        public async Task<ActionResult<List<History>>> GetAll()
        {
            return await _context.History.ToListAsync();
        }
        
        public async Task<ActionResult<History>> Get(int transId)
        {

            var history = await _context.History.FindAsync(transId);
            if (history == null)
            {
                return new NotFoundResult();
            }
            return history;
        }
    }
}
