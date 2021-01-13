using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Models
{
    public class TodoTask
    {
        [Key]
        public string TodoTaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string TodoListId { get; set; }

        [ForeignKey("TodoListId")]
        public TodoList TodoList { get; set; }
    }
}
