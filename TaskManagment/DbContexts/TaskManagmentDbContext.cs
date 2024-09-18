using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TaskManagment.Entities;

namespace TaskManagment.DbContexts
{
    public class TaskManagmentDbContext : DbContext
    {
        public TaskManagmentDbContext(DbContextOptions<TaskManagmentDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Abolfazls-MacBook-Pro.local,1433;Initial Catalog=TaskManagment_Db;User ID=sa;Password=13851385Ab;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
