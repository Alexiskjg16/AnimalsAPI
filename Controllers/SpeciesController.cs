using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafariAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        //GET api/species
        [HttpGet("{location}")]
        public IEnumerable<SeenAnimal> GET(string location)
        {
            var dbConnections = new SafariAdventureContext();
            var Animals = dbConnections.SeenAnimal.Where(a => a.Location == location).ToList();
            return Animals; 
        }
        //GET api/species/{location}
        // [HttpGet]

    }
}