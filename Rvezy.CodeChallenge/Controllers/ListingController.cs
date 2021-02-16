using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rvezy.CodeChallenge.Models;
using Rvezy.CodeChallenge.Models.DTOs;
using Rvezy.CodeChallenge.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rvezy.CodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingController : ControllerBase
    {
        private readonly IListingsService _listings;
        public ListingController(IListingsService listings)
        {
            _listings = listings;
        }

        /// <summary>
        /// Get Listings by page and page size
        /// </summary>
        /// <returns></returns>
        [HttpGet("{page}/{pageSize}")]
        [ProducesResponseType(typeof(PagedResult<ListingModel>), (int)StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PagedResult<ListingModel>> GetPagedListings([FromRoute] int page, [FromRoute] int pageSize)
        {
            try
            {
                var results = _listings.GetPagedListings(page, pageSize);
                if(results == null)
                {
                    return NotFound();
                }
                return results;
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get Listing by id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ListingModel), (int)StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ListingModel>> GetListingById([FromRoute] int id)
        {
            try
            {
                var result = await _listings.GetListingByIdAsync(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get Listing by Property Type
        /// </summary>
        /// <returns></returns>
        [HttpGet("property-type/{propertyType}")]
        [ProducesResponseType(typeof(IList<ListingModel>), (int)StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ListingModel>>> GetListingByPropertyType([FromRoute] string propertyType)
        {
            try
            {
                var result = await _listings.GetByPropertyType(propertyType);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Add a new Listing
        /// </summary>
        /// <param name="listing"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Post([FromBody]ListingModel listing)
        {
            try
            {
                var result = await _listings.Add(listing);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Updates a listing
        /// </summary>
        /// <param name="listing"></param>
        [HttpPut()]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Put([FromBody]ListingModel listing)
        {
            try
            {
                var result = await _listings.Update(listing);
                return Accepted(result);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Removes a listing by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var result = await _listings.Remove(id);
                return Accepted(result);
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
