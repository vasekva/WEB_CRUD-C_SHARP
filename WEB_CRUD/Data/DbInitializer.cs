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

            // Look for any prjoects.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
                new Project{ProjectName="Alexander",StartDate=DateTime.Parse("2005-09-01"),
                    CompletionDate=DateTime.Parse("2005-12-01"), Status=Status.Completed},
                new Project{ProjectName="Alonso",StartDate=DateTime.Parse("2002-06-12"),
                    CompletionDate=DateTime.Parse("2003-12-01"), Status=Status.Completed},
                new Project{ProjectName="Anand",StartDate=DateTime.Parse("2003-09-01"),
                    Status=Status.Active}
            };
            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var tasks = new TaskEntity[]
            {
            new TaskEntity{TaskEntityID=1,CourseID=1050,TaskStatus=TaskStatus.Done},
            new TaskEntity{TaskEntityID=1,CourseID=4022,TaskStatus=TaskStatus.InProgress},
            new TaskEntity{TaskEntityID=1,CourseID=4041,TaskStatus=TaskStatus.ToDo},
            new TaskEntity{TaskEntityID=2,CourseID=1045,TaskStatus=TaskStatus.ToDo},
            new TaskEntity{TaskEntityID=2,CourseID=3141,TaskStatus=TaskStatus.ToDo},
            new TaskEntity{TaskEntityID=2,CourseID=2021,TaskStatus=TaskStatus.ToDo},
            new TaskEntity{TaskEntityID=3,CourseID=1050,TaskStatus=TaskStatus.InProgress},
            new TaskEntity{TaskEntityID=4,CourseID=1050,TaskStatus=TaskStatus.ToDo},
            new TaskEntity{TaskEntityID=4,CourseID=4022,TaskStatus=TaskStatus.Done},
            new TaskEntity{TaskEntityID=5,CourseID=4041,TaskStatus=TaskStatus.Done},
            new TaskEntity{TaskEntityID=6,CourseID=1045,TaskStatus=TaskStatus.InProgress},
            new TaskEntity{TaskEntityID=7,CourseID=3141,TaskStatus=TaskStatus.InProgress}
            };
            foreach (TaskEntity t in tasks)
            {
                context.TasksEntities.Add(t);
            }
            context.SaveChanges();
        }
    }
}