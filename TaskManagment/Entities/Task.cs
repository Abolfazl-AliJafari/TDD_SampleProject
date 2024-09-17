using TaskManagment.Enums;

namespace TaskManagment.Entities
{
    public class Task
    {
        public Task()
        {
            
        }
        public Guid ID { get; set; }
        public string Title { get; set; }
        public TaskStatuses Status { get; set; }
    }
}
