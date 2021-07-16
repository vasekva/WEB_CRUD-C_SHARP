namespace WEB_CRUD.Models
{
    public enum TaskStatus
    {
        ToDo, InProgress, Done
    }
    public class TaskEntity
	{
        public int TaskEntityID { get; set; }
        public string TaskName { get; set; }
        public TaskStatus? TaskStatus { get; set; }
        public string TaskDescriprion { get; set; }
        public int TaskPriority { get; set; }

        public int? ProjectId { get; set; }
        public Project Project { get; set; }
    }
}