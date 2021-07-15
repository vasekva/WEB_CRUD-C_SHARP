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

            // Look for any students.
            if (context.Tasks.Any())
            {
                return;   // DB has been seeded
            }

            var tasks = new Task[]
            {
                new Task{TaskDescription="FirstTask",TaskName="FirstTask",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Task{TaskDescription="SecondTask",TaskName="SecondTask",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Task{TaskDescription="ThirdTask",TaskName="ThirdTask",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Task{TaskDescription="FourthTask",TaskName="FourthTask",EnrollmentDate=DateTime.Parse("2002-09-01")},
            };
            foreach (Task t in tasks)
            {
                context.Tasks.Add(t);
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

            var enrollments = new Enrollment[]
            {
                new Enrollment{TaskID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{TaskID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{TaskID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{TaskID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{TaskID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{TaskID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{TaskID=3,CourseID=1050},
                new Enrollment{TaskID=4,CourseID=1050},
                new Enrollment{TaskID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{TaskID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{TaskID=6,CourseID=1045},
                new Enrollment{TaskID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}