using GalaxyQuest.Interfaces;
using GalaxyQuest.Models;
using System.Text.Json;

namespace GalaxyQuest.Services
{
    public class SwApiService : ISwApiService
    {
        private readonly HttpClient client;

        public SwApiService()
        {
            client = new HttpClient() { BaseAddress = new Uri("https://swapi.dev/api/") };
        }

        public async Task<List<StarWarsPlanet>> GetPlanets()
        {
            var url = "planets";
            var result = new List<StarWarsPlanet>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<List<StarWarsPlanet>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;
        }
    }
}
