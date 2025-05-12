using AgroSys.Domain;
using AgroSys.Infrastructure.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AgroSys.Controllers
{
    [ApiController]
    [Route("cattleman")]
    public class CattlemanController : Controller
    {
        private readonly ICattlemanService _cattlemanService;

        public CattlemanController(ICattlemanService cattlemanService)
        {
            _cattlemanService = cattlemanService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cattlemanService.GetCattlemans());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_cattlemanService.GetCattlemanByID(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cattleman cattleman)
        {
            if (cattleman == null)
            {
                return BadRequest();
            }
            _cattlemanService.InsertCattleman(cattleman);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cattleman cattleman)
        {
            if (cattleman == null)
            {
                return BadRequest();
            }
            _cattlemanService.UpdateCattleman(cattleman);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int cattlemanID)
        {
            if (cattlemanID > 0)
            {
                return BadRequest();
            }
            _cattlemanService.DeleteCattleman(cattlemanID);
            return Ok();
        }
    }
}
