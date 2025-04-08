using NZwalks.DTO;
using NZwalks.Models;

namespace NZwalks.Repositories
{
    public interface IRegionRepository
    {
        public Task<List<Region>> GetRegionsAsync();

        public Task<Region?> GetRegionByIdAsync(Guid id);

        public Task<Region> CreateRegionAsync(Region region);

        public Task<Region?> UpdateRegionAsync(RegionsUpdateRequestDTO regionRequest, Guid id);

        public Task<Region?> DeleteRegionAsync(Guid id);
    }
}
