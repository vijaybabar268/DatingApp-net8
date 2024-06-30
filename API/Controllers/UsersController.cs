using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(DatingDataContext context) : ControllerBase
    {
        [HttpGet] //GET: https://localhost:5001/api/users
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id:int}")] //GET: https://localhost:5001/api/users/1
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x=>x.Id == id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}