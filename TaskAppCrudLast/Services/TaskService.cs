using TaskAppCrudLast.Repositories;
using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Services
{
    public class TaskService:ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<MyTask> GetAll() => _repository.GetAllTasks();

        public MyTask GetById(int id) => _repository.GetTaskById(id);

        public void Create(MyTask task) => _repository.AddTask(task);

        public void Update(MyTask task) => _repository.UpdateTask(task);

        public void Delete(int id) => _repository.DeleteTask(id);
    }
}
