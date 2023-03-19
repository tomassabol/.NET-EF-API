using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class HelicopterController : ControllerBase
    {

        private readonly IHelicopterService helicopterService;

        public HelicopterController(IHelicopterService helicopterService)
        {
            this.helicopterService = helicopterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Helicopter>>> GetAll()
        {
            var result = await helicopterService.GetAll();
            if (result is null)
            {
                return NotFound("No helicopters were found");
            }
            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Helicopter>> Get(int id)
        {
            Helicopter helicopter = await helicopterService.Get(id);

            if (helicopter is null)
            {
                return NotFound("This helicopter was not found");
            }
            return Ok(helicopter);
        }

        [HttpPost]
        public async Task<ActionResult<Boolean>> Create([FromBody] Helicopter helicopter)
        {
            int? result = await helicopterService.Create(helicopter);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Helicopter>> Update(int id, [FromBody] Helicopter helicopter)
        {
            var result = await helicopterService.Update(id, helicopter);
            if (result is null)
            {
                return NotFound("Helicopter was not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Boolean>> Delete(int id)
        {
            Boolean result = await helicopterService.Delete(id);

            if (result is false)
            {
                return NotFound("Helicopter was not ofund");
            }
            return Ok(result);
        }
    }
}

