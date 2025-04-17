using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Services
{
    public interface ITaskService
    {
        IEnumerable<MyTask> GetAll();
        MyTask GetById(int id);
        void Create(MyTask task);
        void Update(MyTask task);
        void Delete(int id);
    }
}
