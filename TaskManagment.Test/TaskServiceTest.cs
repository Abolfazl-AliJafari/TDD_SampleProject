using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.Equal("TDD", tasks[1].Title);
            Assert.Equal(TaskStatuses.InProgress, tasks[0].Status);
        }

    }
}
