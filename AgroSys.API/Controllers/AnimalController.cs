using AgroSys.Domain;
using AgroSys.Infrastructure.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgroSys.Controllers
{
    [ApiController]
    [Route("animal")]
    public class AnimalController : Controller
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_animalService.GetAnimals());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok(_animalService.GetAnimalByID(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Animal animal) 
        {
            if (animal == null)
            {
                return BadRequest();
            }
            _animalService.InsertAnimal(animal);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Animal animal)
        {
            if (animal == null)
            {
                return BadRequest();
            }
            _animalService.UpdateAnimal(animal);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int animalID)
        {
            if (animalID > 0)
            {
                return BadRequest();
            }
            _animalService.DeleteAnimal(animalID);
            return Ok();
        }
    }
}
