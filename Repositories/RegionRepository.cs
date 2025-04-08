using Azure.Core;
using Microsoft.EntityFrameworkCore;
using NZwalks.Data;
using NZwalks.DTO;
using NZwalks.Models;

namespace NZwalks.Repositories
{
    public class RegionRepository(NZwalksDbContext db) : IRegionRepository
    {
        private readonly NZwalksDbContext dbContext = db;

        public async Task<Region> CreateRegionAsync(Region region)
        {
            await dbContext.Regions.AddAsync(region);
            await dbContext.SaveChangesAsync();

            return region;
        }

        public async Task<Region?> DeleteRegionAsync(Guid id)
        {
            Region? regionToBeDeleted = await GetRegionByIdAsync(id);
            if (regionToBeDeleted != null)
            {
                dbContext.Regions.Remove(regionToBeDeleted);
                await dbContext.SaveChangesAsync();
                return regionToBeDeleted;
            }
            else
            {
                return null;
            }
        }

        public async Task<Region?> GetRegionByIdAsync(Guid id)
        {
            return await dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Region>> GetRegionsAsync()
        {
            return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> UpdateRegionAsync(RegionsUpdateRequestDTO regionRequest, Guid id)
        {
            Region? regionToBeUpdated = await GetRegionByIdAsync(id);

            if (regionToBeUpdated != null) {
                regionToBeUpdated.Code = regionRequest.Code;
                regionToBeUpdated.Name = regionRequest.Name;

                if(!String.IsNullOrEmpty(regionRequest.RegionsImageUrl)) { 
                 regionToBeUpdated.RegionImageUrl = regionRequest.RegionsImageUrl;
                }
                await dbContext.SaveChangesAsync();
                return regionToBeUpdated;
            }else
            {
                return null;
            }
        }
    }
}
