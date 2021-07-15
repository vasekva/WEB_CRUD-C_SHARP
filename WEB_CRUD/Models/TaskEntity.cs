namespace WEB_CRUD.Models
{
    public enum TaskStatus
    {
        ToDo, InProgress, Done
    }
    public class TaskEntity
	{
        public int TaskEntityID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public TaskStatus TaskStatus { get; set; }

        public Course Course { get; set; }
        public Project Project { get; set; }
    }
}