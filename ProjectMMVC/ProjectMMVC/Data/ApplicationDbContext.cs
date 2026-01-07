using Microsoft.EntityFrameworkCore;
using ProjectMMVC.Models;

namespace ProjectMMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
    }
}
