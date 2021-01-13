using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Models
{
    public class TodoList
    {
        [Key]
        public string TodoListId { get; set; }

        public List<TodoTask> TodoTasks { get; set; }

        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
