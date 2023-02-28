using Microsoft.AspNetCore.Mvc;
using YuxiTest.Models;
using YuxiTest.Repository;

namespace YuxiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController : ControllerBase
{
    private readonly ILogger<LocationController> logger;
    private readonly ILocationRepository locationRepository;

    public LocationController(
        ILogger<LocationController> _logger,
        ILocationRepository _locationRepository)
    {
        logger = _logger;
        locationRepository = _locationRepository;
    }

    [HttpGet]
    [Route("GetAll")]
    public async Task<IEnumerable<Location>> GetAll()
    {
        return await locationRepository.GetAll();
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<Location> GetById([FromQuery] int locationId)
    {
        return await locationRepository.GetById(locationId);
    }

    [HttpGet]
    [Route("GetByAvailability")]
    public async Task<IEnumerable<Location>> GetByAvailability([FromQuery] int from, [FromQuery] int to)
    {
        return await locationRepository.GetByAvailability(from, to);
    }
}

