using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<MyTask> GetAllTasks();
        MyTask GetTaskById(int id);
        void AddTask(MyTask task);
        void UpdateTask(MyTask task);
        void DeleteTask(int id);
    }
}
