using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListApp.Repositories;
using TodoListApp.Models;
using TodoListApp.Exceptions;

namespace TodoListApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategoryAsync(string name)
        {
            var categoryObj = _categoryRepository.GetCategories()
                              .SingleOrDefault(category => category.Name == name);

            if (!string.IsNullOrEmpty(name) && categoryObj == null)
            {
                var newCategory = new Category
                {
                    Name = name
                };

                _categoryRepository.AddCategory(newCategory);
                await _categoryRepository.SaveAsync();
            }
            else
                throw new InvalidCategoryException();
        }

        public async Task RemoveCategoryByIdAsync(string categoryId)
        {
            var categoryObj = _categoryRepository.GetCategoryById(categoryId);

            if (categoryObj != null)
            {
                _categoryRepository.RemoveCategoryById(categoryId);
                await _categoryRepository.SaveAsync();
            }
            else
                throw new CategoryNotExistsException();
        }
    }
}
