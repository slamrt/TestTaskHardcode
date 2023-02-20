using TestTaskHardcode.DAL;
using TestTaskHardcode.Models;
using System.Runtime.Serialization.Formatters.Binary;
using static TestTaskHardcode.Models.Product;

namespace TestTaskHardcode.Services
{
    public class ProductsService : IProductsService
    {
                  

        private readonly DataBaseContext _context;
        public ProductsService(DataBaseContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public string DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(p=>p.Id== productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return "Product has been deleted";
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(p=>p.CategoryId==categoryId).ToList(); 
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
