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

    }
}
