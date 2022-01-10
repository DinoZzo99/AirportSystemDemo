using AviationWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AviationWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly AirportRepository _airportRepository;
        public CountryController(AirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            try
            {
                var countries = _airportRepository.GetCountries();
                return Ok(countries);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
