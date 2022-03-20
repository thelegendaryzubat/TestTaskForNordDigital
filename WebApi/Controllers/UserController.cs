using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Data;
using WebApi.Data.Entities;

namespace WebApi.Controllers;

[Route("users")]
public class UserControllerContext : BaseControllerContext<User, Guid>
{
    
    public UserControllerContext(TodoDbContext context) : base(context)
    {
    }
    
    [HttpGet]
    public IActionResult Get(Guid id)
    {
        try
        {
            var user = Context.Users.Where(q => q.Id == id).Include(u=>u.Todos);
            return Ok(JsonConvert.SerializeObject(user));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            var user = await Context.FindAsync<User>(id);
            if (user is null)
            {
                return BadRequest("No such user");
            }
            Context.Remove(user);
            await Context.SaveChangesAsync();
            return Accepted();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}