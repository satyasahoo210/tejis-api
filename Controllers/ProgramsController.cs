using Microsoft.AspNetCore.Mvc;
using TejisApi.Models;
using TejisApi.Services;

namespace TejisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IService<ProgramEntity> service;
        public ProgramsController(IService<ProgramEntity> service)
        {
            this.service = service;
        }

        // GET: api/programs
        [HttpGet]
        public ActionResult<List<ProgramEntity>> Get()
        {
            return service.Get();
        }

        // GET: api/programs/{id}
        [HttpGet("{id:length(24)}")]
        public ActionResult<ProgramEntity> GetOne(string id)
        {
            var program = service.Get(id);
            if (program == null)
            {
                return NotFound($"Not Found");
            }
            return program;
        }

        // POST: api/programs
        [HttpPost]
        public ActionResult<ProgramEntity> Post([FromBody] ProgramEntity program)
        {
            service.Create(program);
            return CreatedAtAction(nameof(Get), new { id = program.Id }, program);
        }

        // PUT: api/programs/{id}
        [HttpPut("{id:length(24)}")]
        public ActionResult Put(string id, [FromBody] ProgramEntity program)
        {
            var existingProgram = service.Get(id);
            if (existingProgram == null)
            {
                return NotFound($"Not Found");
            }

            service.Update(id, program);

            return NoContent();
        }

        // DELETE: api/programs/{id}
        [HttpDelete("{id:length(24)}")]
        public ActionResult Delete(string id)
        {
            var existingProgram = service.Get(id);
            if (existingProgram == null)
            {
                return NotFound($"Not Found");
            }

            service.Delete(id);
            return Ok("Deleted successfully");
        }
    }
}
