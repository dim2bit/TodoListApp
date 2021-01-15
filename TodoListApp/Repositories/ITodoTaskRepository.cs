using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;

namespace TodoListApp.Repositories
{
    public interface ITodoTaskRepository
    {
        IEnumerable<TodoTask> GetTaskListById(string taskListId);

        TodoTask GetTaskById(string taskId);

        void AddTask(TodoTask task);

        void UpdateTask(TodoTask task);

        void RemoveTaskById(string taskId);

        Task SaveAsync();
    }
}
