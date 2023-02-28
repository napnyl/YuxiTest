using Microsoft.EntityFrameworkCore;
using System;
using YuxiTest.Data;
using YuxiTest.Models;

namespace YuxiTest.Repository
{
    public class LocationRepository : ILocationRepository
    {
        LocationContext context;
        public LocationRepository(LocationContext _context)
        {
            context = _context;
        }

        /// <summary>
        /// Gets all the locations
        /// </summary>
        /// <returns>List of locations</returns>
        public async Task<IEnumerable<Location>> GetAll()
        {
            return await context.Location.Include(x => x.City).Include(x => x.City.Country).ToArrayAsync();
        }

        /// <summary>
        /// Gets locations by Id
        /// </summary>
        /// <param name="locationId">Id of specific location</param>
        /// <returns>Location</returns>
        public async Task<Location> GetById(int locationId)
        {
            return await context.Location.Include(x => x.City).Include(x => x.City.Country).FirstOrDefaultAsync(x => x.Id == locationId) ?? new Location();
        }

        /// <summary>
        /// Gets a list of locations with an specific availability
        /// </summary>
        /// <param name="from">Time where location should be opened</param>
        /// <param name="to">Time where location should be closed</param>
        /// <returns>List of locations</returns>
        public async Task<IEnumerable<Location>> GetByAvailability(int from, int to)
        {
            return await context.Location.Include(x => x.City).Include(x => x.City.Country).Where(x => x.OpenTime <= new TimeSpan(from, 0, 0) && x.CloseTime >= new TimeSpan(to, 0, 0)).ToArrayAsync();
        }
    }
}

