using TestTaskHardcode.Models;

namespace TestTaskHardcode.Services
{
    public interface ICategoriesService
    {
        void Add(Category category/*, AttributeType attribute*/);
        List<Category> GetCategories();
        Category GetById(int id);
        void Update(Category category);
        string Delete(int id);  
    }
}
