using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : Controller
    {
        /// <summary> Returns a welcome message </summary>
        /// <returns> A string message saying "Welcome to 5121!"</returns>
        /// <example> GET: http://localhost:7253/api/q1/welcome</example>
        [HttpGet("welcome")]
        public ActionResult<string> GetWelcomeMessage()
        {
            //Return the welcome message
            return "Welcome to 5125!";
        }
    }
}
