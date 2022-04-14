using Microsoft.EntityFrameworkCore;
using homeworkS.Models;

namespace homeworkS.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
           : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}