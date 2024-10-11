using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : Controller
    {
        /// <summary>
        /// Returns a string representation of the current date, adjusted by the given number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by.</param>
        /// <returns>A string representation of the adjusted date in the format yyyy-MM-dd.</returns>
        /// <example>GET: http://localhost:7253/api/q7/timemachine?days=1</example>
        [HttpGet("timemachine")]
        public ActionResult<string> GetAdjustedDate([FromQuery] int days)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Add the specified number of days to the current date
            DateTime adjustedDate = currentDate.AddDays(days);

            // Return the adjusted date in the format yyyy-MM-dd
            string formattedDate = adjustedDate.ToString("yyyy-MM-dd");

            return Ok(formattedDate);
        }
    }
}
