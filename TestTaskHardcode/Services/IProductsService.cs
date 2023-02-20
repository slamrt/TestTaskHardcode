using TestTaskHardcode.Models;

namespace TestTaskHardcode.Services
{
    public interface IProductsService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        string DeleteProduct(int productId);

        List<Product> GetProductsByCategoryId(int categoryId);

    }
}
