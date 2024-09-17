namespace TaskManagment.Entities
{
    public class Task
    {
        public Task()
        {
            
        }
        public Guid ID { get; set; }
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
    }
}
