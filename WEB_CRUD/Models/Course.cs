using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_CRUD.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<TaskEntity> TasksEntities { get; set; }
    }
}