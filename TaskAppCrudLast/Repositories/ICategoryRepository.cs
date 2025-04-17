using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Repositories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
