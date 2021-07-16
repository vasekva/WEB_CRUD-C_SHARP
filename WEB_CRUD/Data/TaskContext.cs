using WEB_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace WEB_CRUD.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskEntity>().ToTable("Task");
            modelBuilder.Entity<Project>().ToTable("Project");
        }
    }
}