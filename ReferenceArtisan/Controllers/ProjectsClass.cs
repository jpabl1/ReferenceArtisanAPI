using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReferenceArtisan.Data;
using ReferenceArtisan.Entity;

namespace ReferenceArtisan.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsClass : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ProjectsClass(ApplicationDbContext context) 
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Projects>> Get()
        {
            return await context.Projects.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Projects>> Get(int id)
        {
            var project = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            if( project is null) return NotFound();
            return project;
        }


        [HttpPost]
        public async Task<ActionResult> Post(Projects project)
        {
            context.Add(project);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, Projects project) 
        {
          if ( id != project.Id)
          {
            return BadRequest("Los ids no coinciden.")
          }
          context.Update(project);
          await context.SaveChangesAsync();
          return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id) 
        {
          var registrorBorrados = await context.Projects.Where(
            x => x.Id == id
            ).ExecutableDeleteAsync();
        
          if ( registrosBorrados == 0 )
          {
            return NotFound();
          }
          return Ok();
        }

    }
}
