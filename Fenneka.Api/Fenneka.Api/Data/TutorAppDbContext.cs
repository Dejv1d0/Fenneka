using Microsoft.EntityFrameworkCore;
using Fenneka.Api.Models;

namespace Fenneka.Api.Data
{
    public class TutorAppDbContext : DbContext
    {
        public TutorAppDbContext(DbContextOptions<TutorAppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}