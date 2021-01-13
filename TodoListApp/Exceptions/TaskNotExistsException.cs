using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Exceptions
{
    public class TaskNotExistsException : Exception
    {
        public TaskNotExistsException()
            : base()
        {
        }

        public TaskNotExistsException(string message)
            : base(message)
        {
        }

        public TaskNotExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
