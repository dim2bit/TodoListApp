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

        public async Task AddTaskAsync(TodoTaskViewModel todoTaskVm)
        {
            var name = todoTaskVm.Name;
            var description = todoTaskVm.Description;
            var todoListId = todoTaskVm.TodoListId;

            var todoList = _todoTaskRepository.GetTaskListById(todoListId);

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
                await _todoTaskRepository.SaveAsync();
            }
            else
                throw new InvalidTaskException();
        }

        public async Task UpdateTaskAsync(TodoTaskViewModel todoTaskVm)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveTaskByIdAsync(string taskId)
        {
            var taskObj = _todoTaskRepository.GetTaskById(taskId);

            if (taskObj != null)
            {
                _todoTaskRepository.RemoveTaskById(taskId);
                await _todoTaskRepository.SaveAsync();
            }
            else
                throw new TaskNotExistsException();
        }
    }
}
