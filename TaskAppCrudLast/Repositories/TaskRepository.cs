using Microsoft.EntityFrameworkCore;
using TaskAppCrudLast.Data;
using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Repositories
{
    public class TaskRepository:ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MyTask> GetAllTasks()
        {
            return _context.MyTask.Include(t => t.Category).Include(t => t.AssignedUser).ToList();
        }

        public MyTask GetTaskById(int id)
        {
            return _context.MyTask.Find(id);
        }

        public void AddTask(MyTask task)
        {
            _context.MyTask.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(MyTask task)
        {
            _context.MyTask.Update(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var task = _context.MyTask.Find(id);
            if (task != null)
            {
                _context.MyTask.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}
