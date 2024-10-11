using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : Controller
    {
        /// <summary>
        /// Returns the cube of the integer {base}.
        /// </summary>
        /// <param name="baseNumber">The integer whose cube needs to be calculated.</param>
        /// <returns>The cube of the integer {base}.</returns>
        /// <example>GET: http://localhost0000/api/q3/cube/4</example>
        [HttpGet("cube/{baseNumber}")]
        public ActionResult<int> GetCube(int baseNumber)
        {
            //calculate the cube of the baseNumber
            int result = baseNumber * baseNumber * baseNumber;
            //return the result
            return result;
        }
    }
}
