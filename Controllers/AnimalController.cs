using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafariAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SeenAnimal> GET(){
            var dbConnections = new SafariAdventureContext();
            var Animals = dbConnections.SeenAnimal;
            return Animals;
        }

        [HttpPost]
        public SeenAnimal Post ([FromBody] SeenAnimal animal){
            var dbConnection = new SafariAdventureContext();
            dbConnection.SeenAnimal.Add(animal);
            dbConnection.SaveChanges();
            return animal;
             

        }
    }

}