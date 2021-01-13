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

        [HttpPost("/tasks/add")]
        public RedirectToActionResult AddTask(TodoTaskViewModel todoTaskVm)
        {
            _todoTaskService.AddTask(todoTaskVm);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult UpdateTask()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("/tasks/remove/{taskId}")]
        public RedirectToActionResult RemoveTask(string taskId)
        {
            _todoTaskService.RemoveTask(taskId);

            return RedirectToAction("Index");
        }
    }
}
