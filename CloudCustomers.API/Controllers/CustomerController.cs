using CloudCustomers.API.Data;
using CloudCustomers.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CloudCustomerContext _context;

        public CustomerController(CloudCustomerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var customers = _context.Users.ToList();
            return Ok(customers);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok("Usuário adicionado com sucesso!");
        }
    }
}
