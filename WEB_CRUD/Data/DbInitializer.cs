using WEB_CRUD.Models;
using System;
using System.Linq;

namespace WEB_CRUD.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TaskContext context)
        {
            context.Database.EnsureCreated();

            // Look for any projects.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
                new Project
                {
                    ProjectName="Alexander",StartDate=DateTime.Parse("2005-09-01"),
                    CompletionDate=DateTime.Parse("2005-12-01"), Status=ProjectStatus.Completed, Priority=2
                },
                new Project
                {
                    ProjectName="Alonso",StartDate=DateTime.Parse("2002-06-12"),
                    CompletionDate=DateTime.Parse("2003-12-01"), Status=ProjectStatus.Completed, Priority=0
                },
                new Project
                {
                    ProjectName="Anand",StartDate=DateTime.Parse("2003-09-01"),
                    Status=ProjectStatus.Active, Priority=10
                }
            };
            context.AddRange(projects);
            context.SaveChanges();
        }
    }
}