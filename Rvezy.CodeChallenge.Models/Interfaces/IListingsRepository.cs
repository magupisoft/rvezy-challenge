using Rvezy.CodeChallenge.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rvezy.CodeChallenge.Models.Interfaces
{
    public interface IListingsRepository
    {
        public PagedResult<ListingModel> GetPagedListings(int page, int pageSize);

        public Task<ListingModel> GetListingByIdAsync(int id);

        public Task<IList<ListingModel>> GetByPropertyType(string propertyType);

        public Task<int> Add(ListingModel listing);
        public Task<bool> Update(ListingModel listing);
        public Task<bool> Remove(int id);
    }
}
