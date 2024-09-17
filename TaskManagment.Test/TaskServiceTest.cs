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

        [Fact]
        public void getTasks_should_return_all_tasks()
        {
            // Arrange
            var taskService = new TaskService();
            taskService.AddTask("TDD");
            taskService.AddTask("BDD");

            // Act
            var tasks = taskService.GetTasks();

            // Assert
            Assert.Equal(2, tasks.Count);
        }

        [Fact]
        public void gettaskbystatus_filter_tasks_by_status()
        {
            // Arrange
            var taskService = new TaskService();
            var id1 = taskService.AddTask("TDD");
            var id2 = taskService.AddTask("BDD");
            taskService.UpdateTask(id1, "مطالعه C#", TaskStatuses.Done);

            // Act
            var completedTasks = taskService.GetTaskByStatus(TaskStatuses.Done);

            // Assert
            Assert.Single(completedTasks);
            Assert.Equal(TaskStatuses.Done, completedTasks[0].Status);
        }
    }
}
