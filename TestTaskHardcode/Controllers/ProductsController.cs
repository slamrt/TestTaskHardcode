using TestTaskHardcode.Models;
using TestTaskHardcode.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestTaskHardcode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ProductsController : Controller
    {
        private IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet("allProducts")]
        public IActionResult GetAllProducts()//getting all products from the db
        {
            List<Product>? products = productsService.GetAllProducts();
            List<Product> result = products
                .Select(p => new Product()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryId= p.CategoryId,
                    //I've commented images so that I could return to implementing them
                    //Images= p.Images,   
                    Price= p.Price
                }).ToList();
            return Ok(result);
        }
        
        [HttpGet("{id}", Name ="Get")]
        public IActionResult GetProductById(int id)// getting a product by its id from the db
        {
            var product = productsService.GetProductById(id);
            if(product == null) { return View("Error"); }
            return Ok(product);
        }

        [HttpGet("{categoryId}/productsByCategoryId")]
        public List<Product> GetProductsByCategory(int categoryId) //getting all products by category from the db
        {
            List<Product> products = productsService.GetProductsByCategoryId(categoryId);
            return products;
        }

        [HttpPut("addProduct")]//adding a product to the db
        public IActionResult AddProduct(Product product)
        {
            if(product == null) 
            {
                return BadRequest(ModelState);
            }

            productsService.AddProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPost("AddProduct")]
        public IActionResult PostBody([FromBody] Product product) => AddProduct(product);

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(Product product)//updating a product in the db
        {

            if (product == null)
            {
                return BadRequest(ModelState);
            }

            productsService.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("deleteProduct")]//deleteing a product from the db by its id
        public string DeleteProduct(int id)
        {
            return productsService.DeleteProduct(id);
            
        }
    }
}
