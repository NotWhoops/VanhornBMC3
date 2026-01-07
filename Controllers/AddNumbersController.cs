//http://localhost:5050/AddNumbers/AddingNumbers/num1/num2

using Microsoft.AspNetCore.Mvc;

namespace API_Rehash.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddNumbersController : ControllerBase
    {
        [HttpGet("AddingNumbers/{num1}/{num2}")]
        public int AddingNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}