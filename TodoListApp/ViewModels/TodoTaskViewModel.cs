using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.ViewModels
{
    public class TodoTaskViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string TodoListId { get; set; }
    }
}
