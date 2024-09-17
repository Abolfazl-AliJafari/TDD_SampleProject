using TaskManagment.Entities;
using TaskManagment.Enums;

namespace TaskManagment.Services
{
    public class TaskService
    {
        private List<Entities.Task> _tasks = new List<Entities.Task>();
        public TaskService()
        {

        }
        public void AddTask(string title)
        {
            var task = new Entities.Task()
            {
                ID = Guid.NewGuid(),
                Title = title,
                Status = TaskStatuses.InProgress
            };
            _tasks.Add(task);
        }
        public void RemoveTask(Entities.Task task)
        {
           
        }
        public List<Entities.Task> GetTasks()
        {
            return _tasks;
        }
        public List<Entities.Task> GetTaskByStatus(TaskStatuses status)
        {
           return _tasks;
        }
    }
}
