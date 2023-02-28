using System;
using YuxiTest.Models;

namespace YuxiTest.Repository
{
	public interface ILocationRepository
    {
        Task<IEnumerable<Location>> GetAll();
        Task<Location> GetById(int locationId);
        Task<IEnumerable<Location>> GetByAvailability(int from, int to);
    }
}