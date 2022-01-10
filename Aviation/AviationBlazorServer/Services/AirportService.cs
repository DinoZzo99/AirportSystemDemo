using DomainModel;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AviationBlazorServer.Services
{
    public class AirportService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44342/api";
        public AirportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Airport>> GetAirports()
        {
            return await _httpClient.GetFromJsonAsync<List<Airport>>(BaseApiUrl+"/Airport");
        }
        public async Task<List<Airport>> GetAirportsDescending()
        {
            return await _httpClient.GetFromJsonAsync<List<Airport>>(BaseApiUrl+"/Airport/Descending");
        }
        public async Task<List<Country>> GetCountries()
        {
            return await _httpClient.GetFromJsonAsync<List<Country>>(BaseApiUrl + "/Country");
        }
    }
}
