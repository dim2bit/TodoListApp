using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Exceptions
{
    public class InvalidNewTaskException : Exception
    {
        public InvalidNewTaskException()
        {
        }

        public InvalidNewTaskException(string message)
            : base(message)
        {
        }

        public InvalidNewTaskException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
