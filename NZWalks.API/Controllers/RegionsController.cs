using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    
    // https://Localhost:1234/api/
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // GET ALL REGIONS
        // GET: https://Localhost:1234/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "--"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "--"
                }
            };
            return Ok(regions);
        }
    }
}
