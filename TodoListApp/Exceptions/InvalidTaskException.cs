using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Exceptions
{
    public class InvalidTaskException : Exception
    {
        public InvalidTaskException()
        {
        }

        public InvalidTaskException(string message)
            : base(message)
        {
        }

        public InvalidTaskException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
