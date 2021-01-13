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
        void AddTask(TodoTaskViewModel todoTaskVm);

        void UpdateTask(TodoTask task);

        void RemoveTask(string taskId);
    }
}
