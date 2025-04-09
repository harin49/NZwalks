using NZwalks.Models;
using System.Globalization;

namespace NZwalks.Repositories
{
    public interface IWalksRepository
    {

        public Task<List<Walks>> GetAllWalksAsync(int pageNumber, int pageSize, String? key = null, String? value = null, string? sortBy=null, bool? orderAsc=true);

        public Task<Walks?> GetWalksByIdAsync(Guid id);

        public Task<Walks> CreateWalkAsync(Walks walkRequest);

        public Task<bool> DeleteWalkAsync(Guid id);

        public Task<Walks?> UpdateWalkAsync(Guid id, Walks walkRequest);
    }
}
