using System.Threading.Tasks;
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
        public Guid AddTask(string title)
        {
            var task = new Entities.Task()
            {
                ID = Guid.NewGuid(),
                Title = title,
                Status = TaskStatuses.InProgress
            };
            _tasks.Add(task);
            return task.ID;
        }
        public void UpdateTask(Guid id,string title,TaskStatuses status)
        {
            var taskIndex = _tasks.IndexOf(_tasks.Where(t => t.ID == id).SingleOrDefault());
            if(taskIndex >= 0 )
            {
                _tasks[taskIndex].Title = title;
                _tasks[taskIndex].Status = status;
            }
        }
        public void RemoveTask(Guid id)
        {
            var task = GetTaskById(id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
        public List<Entities.Task> GetTasks()
        {
            return _tasks;
        }
        public List<Entities.Task> GetTaskByStatus(TaskStatuses status)
        {
           return _tasks.Where(t => t.Status== status).ToList();
        }
        public Entities.Task? GetTaskById(Guid id)
        {
            return _tasks.Where(t => t.ID == id).SingleOrDefault();
        }
    }
}
