using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using homeworkS.Models;
using homeworkS.Data;

namespace homeworkS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserListController : ControllerBase
    {
        private readonly UserDbContext _context;
        public UserListController(UserDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        => await _context.Users.ToListAsync();

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(null, new { id = user.Id }, user);
        }
    }
}