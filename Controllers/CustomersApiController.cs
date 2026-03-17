using CrudPractice.Data;
using CrudPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Customers.ToList());
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok(customer);
        }
    }
}