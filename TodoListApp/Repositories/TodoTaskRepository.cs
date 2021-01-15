using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<TodoTask> GetTaskListById(string taskListId)
        {
            return _context.TodoLists.Find(taskListId).TodoTasks;
        }

        public TodoTask GetTaskById(string taskId)
        {
            return _context.TodoTasks.Find(taskId);
        }

        public void AddTask(TodoTask task)
        {
            _context.TodoTasks.Add(task);
        }

        public void UpdateTask(TodoTask task)
        {
            _context.Entry(task).State = EntityState.Modified;
        }

        public void RemoveTaskById(string taskId)
        {
            var task = GetTaskById(taskId);
            _context.TodoTasks.Remove(task);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
