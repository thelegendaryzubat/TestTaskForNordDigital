using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Data;
using WebApi.Data.Entities;

namespace WebApi.Controllers;

[Route("todos")]
public class TodoControllerContext : BaseControllerContext<Todo, Guid>
{
    public TodoControllerContext(TodoDbContext context) : base(context)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var todos = Context.Todos.ToList();
            return Ok(JsonConvert.SerializeObject(todos));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}