using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : Controller
    {
        /// <summary>
        /// Returns an acknowledgement of the secret integer.
        /// </summary>
        /// <param name="secret">The secret integer to acknowledge.</param>
        /// <returns>A message saying "Shh.. the secret is {secret}".</returns>
        /// <example>POST: http://localhost:5289/api/q5/secret with a JSON body containing 5</example>
        [HttpPost(template: "secret")]
        public string PostSecret([FromBody] int secret)
        {
            // Return a message acknoqledging the secret integer
            return $"Shh.. the secret is {secret}";
        }
    }
}
