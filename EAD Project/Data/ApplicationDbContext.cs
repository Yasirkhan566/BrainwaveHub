using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EAD_Project.Models;
using EAD_Project.Data;

namespace EAD_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<Student> Students { get; set; } // This should be plural if it represents a collection of Student entities
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        // If you have more entities, you would add them here
    }
}

namespace EAD_Project.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
