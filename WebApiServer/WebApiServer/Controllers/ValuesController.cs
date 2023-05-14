using Microsoft.AspNetCore.Mvc;
using WebApiServer.model;
namespace WebApiServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string[] Get(employees employees)
        {
            return new string[] {employees.Name, employees.Salary.ToString()};
        }
     
    }
}
