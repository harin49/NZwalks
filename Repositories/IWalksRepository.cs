using NZwalks.Models;

namespace NZwalks.Repositories
{
    public interface IWalksRepository
    {

        public Task<List<Walks>> GetAllWalksAsync();

        public Task<Walks?> GetWalksByIdAsync(Guid id);

        public Task<Walks> CreateWalkAsync(Walks walkRequest);

        public Task<bool> DeleteWalkAsync(Guid id);

        public Task<Walks?> UpdateWalkAsync(Guid id, Walks walkRequest);
    }
}
