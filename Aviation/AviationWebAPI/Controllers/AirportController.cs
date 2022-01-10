using AviationWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AviationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly AirportRepository _airportRepository;
        public AirportController(AirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        [HttpGet]

        public IActionResult GetAirports()
        {
            try
            {
                var airports = _airportRepository.GetAirports();
                return Ok(airports);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("Descending")]
        public IActionResult GetAirportsDescending()
        {
            try
            {
                var airports = _airportRepository.GetAirports();
                var airportsDescending = airports.OrderByDescending(a => a.Name);
                return Ok(airportsDescending);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
