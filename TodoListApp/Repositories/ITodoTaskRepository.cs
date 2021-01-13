using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;

namespace TodoListApp.Repositories
{
    public interface ITodoTaskRepository
    {
        IEnumerable<TodoTask> GetTaskList(string taskListId);

        TodoTask GetTask(string taskId);

        void AddTask(TodoTask task);

        void UpdateTask(TodoTask task);

        void RemoveTask(TodoTask task);

        void Save();
    }
}
