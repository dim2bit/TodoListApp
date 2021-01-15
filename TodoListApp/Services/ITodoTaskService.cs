using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Repositories;
using TodoListApp.Models;
using TodoListApp.ViewModels;

namespace TodoListApp.Services
{
    public interface ITodoTaskService
    {
        Task AddTaskAsync(TodoTaskViewModel todoTaskVm);

        Task UpdateTaskAsync(TodoTaskViewModel todoTaskViewModel);

        Task RemoveTaskByIdAsync(string taskId);
    }
}
