using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;

namespace TodoListApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {        
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<TodoTask> TodoTasks { get; set; }

        public DbSet<TodoList> TodoLists { get; set; }
    }
}
