using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;

namespace TodoListApp.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        Category GetCategoryById(string categoryId);

        void AddCategory(Category category);

        void RemoveCategoryById(string categoryId);

        Task SaveAsync();
    }
}
