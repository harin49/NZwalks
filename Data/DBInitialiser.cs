using Microsoft.EntityFrameworkCore;

namespace NZwalks.Data
{
    public class DBInitialiser
    {

        private NZwalksDbContext _context;

        public DBInitialiser(NZwalksDbContext Context)
        {
            _context = Context;
        }


        public void Run()
        {
            try
            {
                if (!_context.Walks.Any() && !_context.Regions.Any() && !_context.Difficulties.Any())
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception)
            {
                _context.Database.Migrate();
            }
             
        }
    }
}
