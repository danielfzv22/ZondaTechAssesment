using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZondaTechAssesment.Common;
using ZondaTechAssesment.Models;
using ZondaTechAssesment.Services;

namespace ZondaTechAssesment.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController(MockDataService mockData, ILogger<CustomerController> logger) : ControllerBase
    {
        [HttpGet]
        public ActionResult<Response<List<Customer>>> GetCustomers()
        {
            logger.LogInformation("GET /customers - Getting all customers");
            var customers = mockData.Customers;
            return Ok(new Response<List<Customer>>(customers));
        }

        [HttpGet("{id}")]
        public ActionResult<Response<Customer>> GetCustomerById(int id)
        {
            logger.LogInformation("GET /customers/{id} - Getting customer by id", id);
            var customer = mockData.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
            {
                logger.LogWarning("Customer with id {id} not found", id);
                return NotFound(new Response<Customer>("Customer Not Found"));
            }

            return Ok(new Response<Customer>(customer));
        }

        [HttpGet("{id}/products")]
        public ActionResult<Response<List<Product>>> GetProductsForCustomer(int id)
        {
            logger.LogInformation("GET /customers/{id}/products - Getting customer products", id);

            var customer = mockData.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
            {
                logger.LogWarning("Customer with id {id} not found", id);
                return NotFound(new Response<Customer>("Customer Not Found"));
            }

            var products = mockData.Products.Where(p => p.CustomerId == id).ToList();

            return Ok(new Response<List<Product>>(products));
        }
    }
}
