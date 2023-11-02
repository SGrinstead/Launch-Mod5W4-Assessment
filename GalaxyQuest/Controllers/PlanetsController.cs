using GalaxyQuest.Interfaces;
using GalaxyQuest.Services;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyQuest.Controllers
{
    public class PlanetsController : Controller
    {
        private readonly ISwApiService _swApiService;

        public PlanetsController(ISwApiService swApiService)
        {
            _swApiService = swApiService;
        }

        public async Task<IActionResult> Index()
        {
            var milkyWayPlanets = MilkyWayGalaxy.Planets;
            var starWarsPlanets = await _swApiService.GetPlanets();
            ViewData["StarWarsPlanets"] = starWarsPlanets;
            
            return View(milkyWayPlanets);
        }
    }
}
