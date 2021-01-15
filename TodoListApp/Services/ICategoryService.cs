using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoListApp.Services
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(string name);

        Task RemoveCategoryByIdAsync(string categoryId);
    }
}
