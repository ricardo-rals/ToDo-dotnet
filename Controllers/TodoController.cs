using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeuToDo.Models;
using MeuToDo.Data;

namespace MeuToDo.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class TodoController : ControllerBase
    {

        
        [HttpGet]
        [Route(template:"todos")]
        public async Task<IActionResult> GetAsync(
            [FromServices]AppDbContext context
        )
        {
            var todos = await context.Todos.AsNoTracking().ToListAsync();
            return Ok(todos);
        }

        
    }
}