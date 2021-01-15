using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Exceptions
{
    public class CategoryNotExistsException : Exception
    {
        public CategoryNotExistsException()
            : base()
        {
        }

        public CategoryNotExistsException(string message)
            : base(message)
        {
        }

        public CategoryNotExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
