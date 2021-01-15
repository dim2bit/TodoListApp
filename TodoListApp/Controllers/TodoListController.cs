using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.ViewModels;
using TodoListApp.Services;

namespace TodoListApp.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ITodoTaskService _todoTaskService;

        public TodoListController(ITodoTaskService todoTaskService)
        {
            _todoTaskService = todoTaskService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<RedirectToActionResult> AddTaskAsync(TodoTaskViewModel todoTaskVm)
        {
            await _todoTaskService.AddTaskAsync(todoTaskVm);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<RedirectToActionResult> UpdateTaskAsync(TodoTaskViewModel todoTaskVm)
        {
            await _todoTaskService.UpdateTaskAsync(todoTaskVm);

            return RedirectToAction("Index");
        }

        [HttpGet("/tasks/remove/{taskId}")]
        public async Task<RedirectToActionResult> RemoveTaskByIdAsync(string taskId)
        {
            await _todoTaskService.RemoveTaskByIdAsync(taskId);

            return RedirectToAction("Index");
        }
    }
}
