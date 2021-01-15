using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Exceptions
{
    public class InvalidCategoryException : Exception
    {
        public InvalidCategoryException()
            : base()
        {
        }

        public InvalidCategoryException(string message)
            : base(message)
        {
        }

        public InvalidCategoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
