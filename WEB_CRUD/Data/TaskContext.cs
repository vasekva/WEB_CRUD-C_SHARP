using WEB_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace WEB_CRUD.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<TaskEntity> TasksEntities { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<TaskEntity>().ToTable("TaskEntity");
            modelBuilder.Entity<Project>().ToTable("Project");
        }
    }
}