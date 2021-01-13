using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;
using TodoListApp.Data;

namespace TodoListApp.Repositories
{
    public class TodoTaskRepository : ITodoTaskRepository
    {
        private readonly AppDbContext _context;

        public TodoTaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoTask> GetTaskList(string taskListId)
        {
            return _context.TodoLists
                   .SingleOrDefault(list => list.TodoListId == taskListId)
                   .TodoTasks;
        }

        public TodoTask GetTask(string taskId)
        {
            return _context.TodoTasks
                  .SingleOrDefault(task => task.TodoTaskId == taskId);
        }

        public void AddTask(TodoTask task)
        {
            _context.TodoTasks.Add(task);
        }

        public void UpdateTask(TodoTask task)
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(TodoTask task)
        {
            _context.TodoTasks.Remove(task);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
