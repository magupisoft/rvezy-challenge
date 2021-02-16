using Microsoft.Extensions.Logging;
using Rvezy.CodeChallenge.Models;
using Rvezy.CodeChallenge.Models.DTOs;
using Rvezy.CodeChallenge.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rvezy.CodeChallenge.Service
{
    public class ListingsService : IListingsService
    {
        private readonly IListingsRepository _repo;
        private readonly ILogger<ListingsService> _logger;
        public ListingsService(IListingsRepository repo, ILogger<ListingsService> logger)
        {
            _repo = repo;
            _logger = logger;
        }
        public Task<int> Add(ListingModel listing)
        {
            return _repo.Add(listing);
        }

        public Task<IList<ListingModel>> GetByPropertyType(string propertyType)
        {
            return _repo.GetByPropertyType(propertyType);
        }

        public Task<ListingModel> GetListingByIdAsync(int id)
        {
            return _repo.GetListingByIdAsync(id);
        }

        public PagedResult<ListingModel> GetPagedListings(int page, int pageSize)
        {
            return _repo.GetPagedListings(page, pageSize);
        }

        public Task<bool> Remove(int id)
        {
            return _repo.Remove(id);
        }

        public Task<bool> Update(ListingModel listing)
        {
            return _repo.Update(listing);
        }
    }
}
