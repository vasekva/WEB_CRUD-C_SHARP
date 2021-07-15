using System;
using System.Collections.Generic;

namespace WEB_CRUD.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}