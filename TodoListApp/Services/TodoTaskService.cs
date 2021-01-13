using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;
using TodoListApp.Repositories;
using TodoListApp.ViewModels;
using TodoListApp.Exceptions;

namespace TodoListApp.Services
{
    public class TodoTaskService : ITodoTaskService
    {
        private readonly ITodoTaskRepository _todoTaskRepository;

        public TodoTaskService(ITodoTaskRepository todoTaskRepository)
        {
            _todoTaskRepository = todoTaskRepository;
        }

        public void AddTask(TodoTaskViewModel todoTaskVm)
        {
            var name = todoTaskVm.Name;
            var description = todoTaskVm.Description;
            var todoListId = todoTaskVm.TodoListId;

            var todoList = _todoTaskRepository.GetTaskList(todoListId);

            if (!string.IsNullOrEmpty(name)
             && !string.IsNullOrEmpty(description)
             && !string.IsNullOrEmpty(todoListId)
             && todoList != null)
            {
                var newTask = new TodoTask
                {
                    Name = todoTaskVm.Name,
                    Description = todoTaskVm.Description,
                    TodoListId = todoTaskVm.TodoListId
                };

                _todoTaskRepository.AddTask(newTask);
                _todoTaskRepository.Save();
            }
            else
                throw new InvalidNewTaskException();
        }

        public void UpdateTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(string taskId)
        {
            var taskObj = _todoTaskRepository.GetTask(taskId);

            if (taskObj != null)
            {
                _todoTaskRepository.RemoveTask(taskObj);
                _todoTaskRepository.Save();
            }
            else
                throw new TaskNotExistsException();
        }
    }
}
