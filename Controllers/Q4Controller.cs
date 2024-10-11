using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : Controller
    {
        /// <summary>
        /// Starts a knock knock joke
        /// </summary>
        /// <returns>A string saying "Who's there?"</returns>
        /// <example>POST: http://localhost7253/api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public ActionResult<string> StartKnockKnockJoke()
        {
            //Return the response for the start of the joke
            return "Who's there?";
        }
    }
}
