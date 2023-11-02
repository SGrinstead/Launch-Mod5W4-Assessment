using GalaxyQuest.Models;

namespace GalaxyQuest.Interfaces
{
    public interface ISwApiService
    {
        Task<List<StarWarsPlanet>> GetPlanets();
    }
}
