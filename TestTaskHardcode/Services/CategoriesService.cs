using TestTaskHardcode.Services;
using TestTaskHardcode.DAL;
using TestTaskHardcode.Models;

namespace TestTaskHardcode.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly DataBaseContext _context;
        public CategoriesService(DataBaseContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public string Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category != null) 
            { 
                _context.Remove(category); 
                _context.SaveChanges(); 
            }

            return "Category has been deleted";
            
        }

        public Category GetById(int id)
        {

            return _context.Categories.SingleOrDefault(c=>c.Id == id);
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
