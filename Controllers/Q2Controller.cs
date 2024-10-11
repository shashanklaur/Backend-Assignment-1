using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : Controller
    {
        /// <summary>
        /// Returns a personalized greeting message.
        /// </summary>
        /// <param name="name">The name of the person for greeting</param>
        /// <returns>A greeting message saying "Hi {name}!"</returns>
        /// <example>GET: http://localhost:7253/api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public ActionResult<string> GetGreeting(string name) 
        {
            //Return a personal greeting
            return $"Hi {name}!";
        }
    }
}
