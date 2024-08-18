using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace newProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("GetStuents")]
        public IActionResult GetStuents()
        {
            string[] StudentData = new string[] { "John", "Json", "Harry" };
            return Ok(StudentData);
        }

        [HttpGet("GetOne")]
        public IActionResult GetOne()
        {
            string[] StudentData = new string[] { "John" };
            return Ok(StudentData);
        }

    }
}
