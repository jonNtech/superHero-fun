using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace superHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes ()
        {
            return new List <SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };
        }
    }
}
