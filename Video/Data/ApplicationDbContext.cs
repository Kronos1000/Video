using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Video.Models;

namespace Video.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Video.Models.Member> Member { get; set; }
        public DbSet<Video.Models.Movie> Movie { get; set; }
        public DbSet<Video.Models.Rental> Rental { get; set; }
    }
}