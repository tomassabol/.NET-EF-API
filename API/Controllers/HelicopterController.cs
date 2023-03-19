using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            var result = helicopterService.GetAll();
            if (result is null)
            {
                return NotFound("No helicopters were found");
            }
            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Helicopter>> Get(int id)
        {
            var result = helicopterService.Get(id);

            if (result is null) {
                return NotFound("This helicopter was not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Helicopter>>> Create([FromBody]Helicopter helicopter)
        {
            var result = helicopterService.Create(helicopter);
            if (result is null)
            {
                return BadRequest("bad request");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Helicopter>>> Update(int id, [FromBody]Helicopter request)
        {
            var result = helicopterService.Update(id, request);


            if (result is null)
            {
                return NotFound("Helicopter was not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Helicopter>>> Delete(int id)
        {
            var result = helicopterService.Delete(id);

            if (result is null)
            {
                return NotFound("Helicopter was not ofund");
            }
            return Ok(result);
        }
    }
}

