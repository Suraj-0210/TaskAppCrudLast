using Microsoft.AspNetCore.Mvc;
using TaskAppCrudLast.Models;
using TaskAppCrudLast.Services;

namespace TaskAppCrudLast.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;

        public TaskController(ITaskService taskService, IUserService userService, ICategoryService categoryService)
        {
            _taskService = taskService;
            _userService = userService;
            _categoryService = categoryService;
        }

        // GET: Task
        public IActionResult Index()
        {
            var tasks = _taskService.GetAll(); // includes User & Category
            return View(tasks);
        }

        // GET: Task/Create
        public IActionResult Create()
        {
            ViewBag.Users = _userService.GetAllUsers(); // make sure this returns List<User>
            ViewBag.Categories = _categoryService.GetAllCategories(); // List<Category>
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MyTask task)
        {
           
                _taskService.Create(task);
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Task/Edit/5
        public IActionResult Edit(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();

            return View(task);
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MyTask task)
        {
            if (ModelState.IsValid)
            {
                _taskService.Update(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        // GET: Task/Delete/5
        public IActionResult Delete(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();

            return View(task);
        }

        // POST: Task/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _taskService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
