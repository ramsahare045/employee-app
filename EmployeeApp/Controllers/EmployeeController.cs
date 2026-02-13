using EmployeeApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "John", Department = "IT" },
            new Employee { Id = 2, Name = "Mary", Department = "HR" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }
    }
}
