using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Models;
using TodoListApp.Data;

namespace TodoListApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public Category GetCategoryById(string categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public void RemoveCategoryById(string categoryId)
        {
            var category = _context.Categories.Find(categoryId);
            _context.Categories.Remove(category);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
