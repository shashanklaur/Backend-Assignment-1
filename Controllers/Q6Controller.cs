using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : Controller
    {
        /// <summary>
        /// Calculates the area of a regular hexagon with side length S.
        /// </summary>
        /// <param name="side">The side length of the hexagon.</param>
        /// <returns>The area of the hexagon.</returns>
        /// <example>GET: http://localhost:7235/api/q6/hexagon?side=1</example>
        [HttpGet("hexagon")]
        public ActionResult<double> GetHexagonArea([FromQuery] double side)
        {
            // Calculate the area using the given formula
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);

            // Return the calculated area
            return Ok(area);
        }
    }
}
