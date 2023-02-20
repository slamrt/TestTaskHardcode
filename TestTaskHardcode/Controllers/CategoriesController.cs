using TestTaskHardcode.Models;
using TestTaskHardcode.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestTaskHardcode.Controllers
{
    public class CategoriesController : ControllerBase
    {
        ICategoriesService _service = null;

        public CategoriesController(ICategoriesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()//getting all categories from the db
        {
            return _service.GetCategories();
        }

        [HttpGet("{id}", Name ="Get")]
        public Category Get(int id) // getting a category from the db byt its id
        { 
            return _service.GetById(id);
        }

        [HttpPut("AddCategory")]//adding a category to the db
        public void Add(Category category)
        {
            _service.Add(category); 
        }

        [HttpPost("UpdateCategory")]//updating a category in the db
        public void Update(Category category)
        {
            _service.Update(category);
        }

        [HttpDelete("DeleteCategory")]//deleting a category from the db by its id
        public string Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
