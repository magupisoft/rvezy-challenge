using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rvezy.CodeChallenge.DataContext;
using Rvezy.CodeChallenge.Models;
using Rvezy.CodeChallenge.Models.DTOs;
using Rvezy.CodeChallenge.Models.Extensions;
using Rvezy.CodeChallenge.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rvezy.CodeChallenge.Repository
{
    public class ListingRepository : IListingsRepository
    {
        private readonly RvezyDataContext _db;
        ILogger<ListingRepository> _logger;

        public ListingRepository(RvezyDataContext db, ILogger<ListingRepository> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task<int> Add(ListingModel listing)
        {
            _db.Listing.Add(listing);
            var id = await _db.SaveChangesAsync();
            return id;
        }

        public async Task<IList<ListingModel>> GetByPropertyType(string propertyType)
        {
            return await _db.Listing.Where(s => s.PropertyType == propertyType).ToListAsync();
        }

        public async Task<ListingModel> GetListingByIdAsync(int id)
        {
            return await _db.Listing.FindAsync(id);
        }

        public PagedResult<ListingModel> GetPagedListings(int page, int pageSize)
        {
            return _db.Listing.GetPaged(page, pageSize);
        }

        public async Task<bool> Remove(int id)
        {
            var entity = await _db.Listing.FindAsync(id);
            if (entity == null) return false;

            _db.Listing.Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(ListingModel listing)
        {
            var entity = await _db.Listing.FindAsync(listing.Id);
            if (entity == null) return false;

            _db.Entry(entity).CurrentValues.SetValues(listing);

            await _db.SaveChangesAsync();
            return true;
        }
    }
}
