using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZondaTechAssesment.Common;
using ZondaTechAssesment.Models;
using ZondaTechAssesment.Services;

namespace ZondaTechAssesment.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController(MockDataService mockData, ILogger<CustomerController> logger) : ControllerBase
    {
        [HttpPost]
        public ActionResult<Response<Product>> AddProduct([FromBody] Product newProduct)
        {

            logger.LogInformation("POST /products - Adding new product");

            if (string.IsNullOrWhiteSpace(newProduct.Name))
            {
                return BadRequest(new Response<Product>("Product name is required", false));
            }

            if (mockData.Products.Any(p => p.Name.Equals(newProduct.Name, StringComparison.OrdinalIgnoreCase) && 
                p.CustomerId == newProduct.CustomerId)) 
            {
                return Conflict(new Response<Product>("Product name already exists.", false));
            }

            newProduct.Id = mockData.Products.Count != 0 ? mockData.Products.Max(p => p.Id) + 1 : 1;

            mockData.Products.Add(newProduct);

            return Ok(new Response<Product>(newProduct));
        }


        [HttpPut("{id}")]
        public ActionResult<Response<Product>> UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            logger.LogInformation("PUT /products - Updating product {id}", id);

            var product = mockData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new Response<Product>("Product not found"));
            }

            if (mockData.Products.Any(p =>
                 p.Id != updatedProduct.Id &&
                 p.Name.Equals(updatedProduct.Name, StringComparison.OrdinalIgnoreCase) &&
                 p.CustomerId == updatedProduct.CustomerId))
            {
                return Conflict(new Response<Product>("Product name already exists for this Customer.", false));
            }

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.CustomerId = updatedProduct.CustomerId;

            return Ok(new Response<Product>(product));
        }

        [HttpDelete("{id}")]
        public ActionResult<Response<string>> DeleteProduct(int id)
        {
            logger.LogInformation("Delete /products - Deleting product {id}", id);

            var product = mockData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new Response<string>("Product not found", false));
            }

            mockData.Products.Remove(product);

            return Ok(new Response<string>("Product deleted successfully"));
        }
    }
}
