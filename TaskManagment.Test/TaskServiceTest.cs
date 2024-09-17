using TaskManagment.Enums;
using TaskManagment.Services;

namespace TaskManagment.Test
{
    public class TaskServiceTest
    {
        [Fact]
        public void addtask_to_tasks_list()
        {
            //Arrange
            var taskService = new TaskService();
            //Act
            taskService.AddTask("TDD");
            //Assert
            var tasks = taskService.GetTasks();
            Assert.Single(tasks);
            Assert.Equal("TDD", tasks[0].Title);
            Assert.Equal(TaskStatuses.InProgress, tasks[0].Status);
        }

        [Fact]
        public void updatetask_should_update_title_status()
        {
            //Arrange
            var taskService = new TaskService();
            var id = taskService.AddTask("TDD");
            //Act
            taskService.UpdateTask(id, "BDD", TaskStatuses.Canceled);
            var task = taskService.GetTaskById(id);
            //Assert
            Assert.Equal("BDD", task.Title);
            Assert.Equal(TaskStatuses.Canceled, task.Status);
        }

        [Fact]
        public void removetask_should_remove_task_from_list()
        {
            // Arrange
            var taskService = new TaskService();
            var id = taskService.AddTask("TDD");

            // Act
            taskService.RemoveTask(id);

            // Assert
            var task = taskService.GetTaskById(id);
            Assert.Null(task); 
        }
    }
}
