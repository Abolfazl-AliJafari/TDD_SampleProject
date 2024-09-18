using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
