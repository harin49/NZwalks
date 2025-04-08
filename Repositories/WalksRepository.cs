using Microsoft.EntityFrameworkCore;
using NZwalks.Data;
using NZwalks.Models;

namespace NZwalks.Repositories
{
    public class WalksRepository(NZwalksDbContext dbcontext ) : IWalksRepository
    {

        private readonly NZwalksDbContext _dbcontext = dbcontext;
        public async Task<Walks> CreateWalkAsync(Walks walkRequest)
        {
            await _dbcontext.Walks.AddAsync(walkRequest);
            await  _dbcontext.SaveChangesAsync();

            var walkRegion = await _dbcontext.Regions.FirstOrDefaultAsync(x => x.Id == walkRequest.RegionId);

            if (walkRegion != null) { 
                walkRequest.Region = walkRegion;
            }

            var walkDifficulty = await _dbcontext.Difficulties.FirstOrDefaultAsync(x => x.Id == walkRequest.DifficultyId);

            if (walkDifficulty != null)
            {
                walkRequest.Difficulty = walkDifficulty;
            }

            return walkRequest;
        }

        public async Task<bool> DeleteWalkAsync(Guid id)
        {
            var walkToBeDeleted = await _dbcontext.Walks.FirstOrDefaultAsync(x => x.Id == id);


            if (walkToBeDeleted != null) {
                 _dbcontext.Walks.Remove(walkToBeDeleted);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<List<Walks>> GetAllWalksAsync()
        {
            return await _dbcontext.Walks.Include("Region").Include("Difficulty").ToListAsync(); ;
        }

        public async Task<Walks?> GetWalksByIdAsync(Guid id)
        {

            return await _dbcontext.Walks.Include("Region").Include("Difficulty").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Walks?> UpdateWalkAsync(Guid id, Walks walkRequest)
        {
           
            var walkToBeUpdated = await _dbcontext.Walks.Include("Region").Include("Difficulty").FirstOrDefaultAsync(x => x.Id == id);

            if (walkToBeUpdated != null) { 
                
                walkToBeUpdated.Name = walkRequest.Name;
                walkToBeUpdated.Description = walkRequest.Description;  
                walkToBeUpdated.DifficultyId = walkRequest.DifficultyId;
                walkToBeUpdated.RegionId = walkRequest.RegionId;
                walkToBeUpdated.LengthInKm = walkRequest.LengthInKm;
                walkToBeUpdated.WalkImageUrl = walkRequest.WalkImageUrl;

                await _dbcontext.SaveChangesAsync();
            }

            return walkToBeUpdated;
        }
    }
}
