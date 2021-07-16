using System;
using System.Collections.Generic;

namespace WEB_CRUD.Models
{
    public enum Status
    {
        NotStarted, Active, Completed
    }
    public class Project
	{
        public int ID { get; set; }
        public string ProjectName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }

        public TaskEntity TaskEntity;
        public ICollection<TaskEntity> TasksEntities { get; set; }
        public Status? Status { get; set; }
        public int Priority { get; set; }
    }
}