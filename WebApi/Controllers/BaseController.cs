using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
namespace WebApi.Controllers;

[ApiController]
public abstract class BaseControllerContext<TEntity, TPrimaryKey> : ControllerBase where TEntity : BaseEntity<TPrimaryKey> where TPrimaryKey : struct
{
    protected TodoDbContext Context { get; }
    protected BaseControllerContext(TodoDbContext context)
    {
        Context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]TEntity entity)
    {
        try
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}